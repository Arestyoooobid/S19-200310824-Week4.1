using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(S19_200310824_Week4._1.Startup))]
namespace S19_200310824_Week4._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
