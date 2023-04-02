using backend.backend_DAL.Entities;
using Microsoft.AspNetCore.Identity;

namespace backend.backend_DAL
{
    public class InitialSeed { 
        public readonly RoleManager<Role> _roleManager;

        public InitialSeed(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }

        public async void CreateRoles()
        {
            string[] roleNames =
            {
                    "Admin",
                    "BasicUser",
                    "Partner"
            };

            foreach (var roleName in roleNames)
            {
                var role = new Role
                {
                    Name = roleName
                };

                await _roleManager.CreateAsync(role);
            }
        }
    }
}
