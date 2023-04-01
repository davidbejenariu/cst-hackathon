using backend.backend_DAL.Entities;
using Microsoft.AspNetCore.Identity;

namespace backend.backend_DAL
{
    public class InitialSeed
    {
       
        public readonly RoleManager<IdentityRole> _roleManager;

        public InitialSeed(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async void CreateRoles()
        {
            string[] roleNames =
            {
                "Admin",
                "Partner",
                "BasicUser"
            };

            foreach (var roleName in roleNames)
            {
                var role = new IdentityRole
                {
                    Name = roleName
                };

                await _roleManager.CreateAsync(role);
            }
        }
    }

}
