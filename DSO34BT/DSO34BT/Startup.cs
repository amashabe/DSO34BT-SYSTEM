using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DSO34BT.Startup))]
namespace DSO34BT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
