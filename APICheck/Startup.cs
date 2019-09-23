using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(APICheck.Startup))]
namespace APICheck
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
