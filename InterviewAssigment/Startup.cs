using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InterviewAssigment.Startup))]
namespace InterviewAssigment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
