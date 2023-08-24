using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(test.StartupOwin))]

namespace test
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
