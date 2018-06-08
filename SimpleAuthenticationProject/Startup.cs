using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using SimpleAuthenticationProject.Models;

[assembly: OwinStartupAttribute(typeof(SimpleAuthenticationProject.Startup))]
namespace SimpleAuthenticationProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRoles();
        }

        private void CreateRoles()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            if (!roleManager.RoleExists("visitor"))
            {
                var role = new IdentityRole();
                role.Name = "visitor";
                roleManager.Create(role);
            }
            if (!roleManager.RoleExists("admin"))
            {
                var role = new IdentityRole();
                role.Name = "admin";
                roleManager.Create(role);
            }
        }
    }
}
