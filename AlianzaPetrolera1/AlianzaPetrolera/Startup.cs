using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlianzaPetrolera.Startup))]
namespace AlianzaPetrolera
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
