using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesClub.Startup))]
namespace MoviesClub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
