using Microsoft.Owin;
using Owin;
using System.Web.Http;
using Swashbuckle.Application;
using WebApiContrib.IoC.Ninject;
using comData.api.App_Start;
[assembly: OwinStartup(typeof(comData.api.Startup))]

namespace comData.api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            HttpConfiguration config = new HttpConfiguration();

            WebApiConfig.Register(config);

            config.DependencyResolver = new NinjectResolver(NinjectConfig.CreateKernel());

            //config.Routes.MapHttpRoute("default", "api/{controller}/{id}", new { id = RouteParameter.Optional });

            config.EnableSwagger(c =>
            {
                c.SingleApiVersion("v1", "comData.api")
                    .Description("web api 1.0 en framework 4.0")
                    .TermsOfService("https://foundation.wikimedia.org/wiki/Terms_of_Use/en")
                    .Contact(cc => cc
                        .Name("Hernan Arturo cama Chamorro")
                        .Url("https://www.linkedin.com/in/hernan-cama-886b60147/")
                        .Email("hernan.arturo.cama.chamorro@gmail.com"))
                    .License(lc => lc
                        .Name("MIT")
                        .Url("https://opensource.org/licenses/MIT"));
            }).EnableSwaggerUi();
            app.UseWebApi(config);

        }
    }
}