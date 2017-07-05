using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DropDownCascata.Startup))]
namespace DropDownCascata
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
