using FluentValidation.WebApi;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHostWebAPI
{
    public class StartUp
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        {
            // Configure Web API for self-host. 
            HttpConfiguration config = new HttpConfiguration();

            
            config.Filters.Add(new ValidateModelStateFilter());

            config.MessageHandlers.Add(new ResponseWrappingHandler());

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            FluentValidationModelValidatorProvider.Configure(config);
            //FluentValidationModelValidatorProvider.Configure(config, provider => {
            //    provider.ValidatorFactory = new MyCustomValidatorFactory();
            //});

            appBuilder.UseWebApi(config);
        }
    }
}
