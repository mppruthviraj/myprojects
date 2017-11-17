using Microsoft.Owin;
using Owin;
using System.Web.Http;


[assembly: OwinStartupAttribute(typeof(ABB_Portal.Startup))]
namespace ABB_Portal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            //HttpConfiguration config = GlobalConfiguration.Configuration;
            //config.Formatters.JsonFormatter.SerializerSettings.Converters.Add
            //            (new Newtonsoft.Json.Converters.StringEnumConverter());
        }
    }
}
