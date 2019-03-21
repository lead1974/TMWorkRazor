using AutoMapper;
using TMWork.Data.Core;
using TMWork.Data.Core.Domain;
using TMWork.Data.Persistance;
using TMWork.Services;
using TMWork.ViewModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using System;
using Microsoft.AspNetCore.Identity;
using static TMWork.Services.EmailSender;

namespace TMWork
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;
            _env = env;

            var builder = new ConfigurationBuilder()
                                .SetBasePath(env.ContentRootPath)
                                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);
            //.AddJsonFile("config.json");

            _config = builder.Build();
        }

        public IConfiguration Configuration { get; }
        private IHostingEnvironment _env;
        private IConfigurationRoot _config;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options => options.AddPolicy("Cors", builder =>
            {
                builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            }));

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //services.AddDbContext<ECDbContext>
            //                  (context => { context.UseInMemoryDatabase("TMWorkDB"); });

            services.AddDbContext<ECDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            //(options => options.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = TMWorkDB; Trusted_Connection = True; MultipleActiveResultSets = true"));

            ////services.AddAuthorization(options =>
            ////{
            ////    options.AddPolicy(SD.PolicyCanManageSite, p => p.RequireAuthenticatedUser().RequireRole(SD.CanManageSite));
            ////});

            services.AddIdentity<AuthUser, AuthRole>(options =>
            {
                options.User.RequireUniqueEmail = true;
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 4;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.SignIn.RequireConfirmedEmail = true;
            })
                .AddEntityFrameworkStores<ECDbContext>()
                .AddDefaultTokenProviders();

            services.AddAuthentication(Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.AccessDeniedPath = "/Home/ErrorForbidden";
                    options.LoginPath = "/Home/ErrorNotLoggedIn";
                });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = $"/Identity/Account/Login";
                options.LogoutPath = $"/Identity/Account/Logout";
                options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy(SD.PolicyCanManageSite, p => p.RequireAuthenticatedUser().RequireRole(SD.CanManageSite));
            });

            services.AddMvc(options =>
            {
                //The commented line causes WebApi POST/PUT/DELETE stop working, only GET works!
                //options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
                //options.Filters.Add(new RequireHttpsAttribute());
            })
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                //.ConfigureApiBehaviorOptions(options =>
                //{
                //    options.SuppressConsumesConstraintForFormFileParameters = true;
                //    options.SuppressInferBindingSourcesForParameters = true;
                //    options.SuppressModelStateInvalidFilter = true;
                //    options.SuppressMapClientErrors = true;

                //    options.ClientErrorMapping[404].Link = "https://httpstatuses.com/404";
                //})
                .AddJsonOptions(options =>
                {
                    options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore; //Ticket with Telerik 1397925
                    options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                });


            services.AddKendo();
            //services.AddAntiforgery();
            services.AddAntiforgery(o => o.HeaderName = "XSRF-TOKEN");
            //email settings
           
            // Add application services.
            services.AddSingleton(_config);
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddTransient<GlobalService, GlobalService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<ECSeedData>();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
            });

            services.Configure<EmailSettings>(Configuration.GetSection("EmailSettings"));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ECSeedData seedData)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                //app.UseHsts();
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            }


            //security: http to https forwarding
            //app.UseForwardedHeaders(new ForwardedHeadersOptions
            //{
            //    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            //});
            ////security: https forwarding

            //app.UseHttpsRedirection();

            Mapper.Initialize(config =>
            {
                config.CreateMap<ContactVM, Contact>().ReverseMap();
            });


            app.UseStaticFiles();

            app.UseCors("Cors");

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "api/{controller=Home}/{action=Index}/{id?}");
            });
            app.UseCookiePolicy();
            app.UseFileServer();

            seedData.EnsureSeedData().Wait();
        }
    }
}
