using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab1.Startup))]
namespace Lab1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
	    int a = 5;
	    a = a + 5;
            ConfigureAuth( app);

        }
    }
}
