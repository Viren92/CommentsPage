using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CommentsPage.Startup))]
namespace CommentsPage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
