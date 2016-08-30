using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(rado_blog.Startup))]
namespace rado_blog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
