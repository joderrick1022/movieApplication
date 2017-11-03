using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(movieApplication.Startup))]
namespace movieApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
