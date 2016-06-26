using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MedicineMaster.Startup))]
namespace MedicineMaster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
