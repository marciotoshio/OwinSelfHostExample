using System;
using Owin;
using System.Web.Http;
using System.Net.Http.Headers;

namespace OwinSelfHostExample.WebApi
{
	public class Startup
	{
		public void Configuration(IAppBuilder appBuilder) 
		{ 
			var config = new HttpConfiguration(); 

			config.Routes.MapHttpRoute( 
				name: "DefaultApi", 
				routeTemplate: "api/{controller}/{id}", 
				defaults: new { id = RouteParameter.Optional } 
			); 

			config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html") );

			appBuilder.UseWebApi(config); 
		}
	}
}

