using System.Web.Mvc;

namespace Mvc5.Areas.Default
{
    public class DefaultAreaRegistration : AreaRegistration 
    {
		public override string AreaName {
			get {
				return "Default";
			}
		}

		public override void RegisterArea( AreaRegistrationContext context ) {
			context.MapRoute(
				name: "default",
				url: "{controller}/{action}/{id}",
				defaults: new {
					controller = "Home",
					action = "Index",
					id = UrlParameter.Optional
				},
				namespaces: new[] { "Mvc5.Areas.Default.Controllers" }
			);
		}
    }
}