using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductEnum.Startup))]
namespace ProductEnum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
