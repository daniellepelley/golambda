using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoLambda.Website.Mvc.Startup))]
namespace GoLambda.Website.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
