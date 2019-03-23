using TMWork.Data.Core;
using TMWork.Data.Core.Domain;
using TMWork.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Linq;

namespace TMWork.Data.Persistance
{
    public class ECSeedData
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<AuthUser> _userManager;
        private readonly SignInManager<AuthUser> _signInManager;
        private readonly RoleManager<AuthRole> _roleManager;
        private readonly ECDbContext _tmContext;
        private readonly ILogger _logger;
        private GlobalService _globalService;

        public ECSeedData(
                            ECDbContext tmContext,
                            IUnitOfWork unitOfWork,
                            UserManager<AuthUser> userManager,
                            SignInManager<AuthUser> signInManager,
                            RoleManager<AuthRole> roleManager,
                            GlobalService globalService,
                            ILoggerFactory loggerFactory
            )
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _tmContext = tmContext;

            _globalService = globalService;
            _logger = loggerFactory.CreateLogger<ECSeedData>();
        }

        public async Task EnsureSeedData()
        {
            //await DeleteUser();
            await SeedAdminUsers();
            //await SeedContacts();
        }

        private async Task DeleteUser()
        {
            //Task<AuthUser> user = _userManager.FindByNameAsync("balda@balda.com");
            //// If we could not find the user, throw an exception
            //if (user == null)
            //{
            //    throw new Exception("Could not find the User");
            //}
            //_userManager.RemoveFromRoles(user, _userManager.GetRolesAsync(user).ToArray());
            //_userManager.Update(user);
            //_userManager.Delete(user);

            var user = await _userManager.FindByNameAsync("balda@balda.com");
            await _userManager.DeleteAsync(user);
        }

        private async Task SeedAdminUsers()
        {
            var user = new AuthUser
            {
                UserName = "balda@balda.com",
                NormalizedUserName = "balda@balda.com",
                Email = "balda@balda.com",
                NormalizedEmail = "balda@balda.com",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var roleStore = new RoleStore<AuthRole>(_tmContext);

            if (!_tmContext.Roles.Any(r => r.Name == SD.CanManageSite))
            {
                await roleStore.CreateAsync(new AuthRole { Name = SD.CanManageSite, NormalizedName = SD.CanManageSite, Description = "Site Administrator" });
            }


            if (!_tmContext.Users.Any(u => u.UserName == user.UserName))
            {
                var password = new PasswordHasher<AuthUser>();
                var hashed = password.HashPassword(user, "balda1234");
                user.PasswordHash = hashed;
                await _userManager.CreateAsync(user);
                await _userManager.AddToRoleAsync(user, SD.CanManageSite);
            }

            await _tmContext.SaveChangesAsync();
        }

        private async Task SeedContacts()
        {
            int contactCount = await _unitOfWork.Contacts.GetCount();

            if (contactCount == 0)
            {
                var contacts = new Contact[] {
                    new Contact
                    {

                        Name = "Contact 1",
                        Phone = "17145557788",
                        Email = "email@email.com",
                        Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        DateUpdated= DateTime.UtcNow,
                        UpdatedBy="APARAHNEVI",
                        DateCreated= DateTime.UtcNow,
                        CreatedBy="APARAHNEVI"
                    },
                new Contact
                    {

                        Name = "Contact 2",
                        Phone = "17145557788",
                        Email = "email@email.com",
                        Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        DateUpdated= DateTime.UtcNow,
                        UpdatedBy="APARAHNEVI",
                        DateCreated= DateTime.UtcNow,
                        CreatedBy="APARAHNEVI"
                    },
                new Contact
                    {

                        Name = "Contact 3",
                        Phone = "17145557788",
                        Email = "email@email.com",
                        Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        DateUpdated= DateTime.UtcNow,
                        UpdatedBy="APARAHNEVI",
                        DateCreated= DateTime.UtcNow,
                        CreatedBy="APARAHNEVI"
                    },


                };

                _unitOfWork.Contacts.AddRange(contacts);
                _unitOfWork.Complete();
            }
        }

    }
}
