using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aula03_Autenticacao.Startup))]
namespace Aula03_Autenticacao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
