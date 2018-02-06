using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_13novemberlogin.Startup))]
namespace _13novemberlogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
