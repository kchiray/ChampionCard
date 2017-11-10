using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChampionCards.Startup))]
namespace ChampionCards
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
