using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(my_aspnetmvc1.Startup))]
namespace my_aspnetmvc1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
