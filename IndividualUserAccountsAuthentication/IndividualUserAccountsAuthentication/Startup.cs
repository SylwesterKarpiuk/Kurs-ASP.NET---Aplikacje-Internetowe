using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IndividualUserAccountsAuthentication.Startup))]
namespace IndividualUserAccountsAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
