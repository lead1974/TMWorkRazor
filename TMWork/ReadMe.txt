Kendo Grid WebAPI
https://github.com/telerik/wrappers-getting-started/blob/master/aspnetmvc/aspnetmvc-episode4/aspnetmvc-episode4/Controllers/ProductsController.cs

Build web APIs with ASP.NET Core
https://docs.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-2.2
telerik/kendo-examples-asp-net
https://github.com/telerik/kendo-examples-asp-net/blob/master/grid-webapi-crud/Default.aspx
youtube:
https://www.youtube.com/watch?v=5I9W0uXVPeI&t=12s&list=WL&index=29

Postman WebAPI
https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-2.1&tabs=visual-studio

in StartUp.cs
            services.AddMvc(options =>
            {
                //The commented line causes WebApi POST/PUT/DELETE stop working, only GET works!
                //options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
                options.Filters.Add(new RequireHttpsAttribute());
            })