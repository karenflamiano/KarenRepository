using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LocalReportDemo.Startup))]
namespace LocalReportDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
