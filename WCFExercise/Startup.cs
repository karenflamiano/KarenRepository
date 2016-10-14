using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WCFExercise.Startup))]
namespace WCFExercise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
