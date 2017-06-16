using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StaffReview.Startup))]
namespace StaffReview
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
