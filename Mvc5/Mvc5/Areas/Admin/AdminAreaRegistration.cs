using System.Web.Mvc;

namespace Mvc5.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
		public override string AreaName {
			get {
				return "Admin";
			}
		}

		public override void RegisterArea( AreaRegistrationContext context ) {
			context.MapRoute(
				name: "admin",
				url: "admin/{controller}/{action}/{id}",
				defaults: new {
					controller = "Home",
					action = "Index",
					id = UrlParameter.Optional
				},
				namespaces: new[] { "Mvc5.Areas.Admin.Controllers" }
			);
		}
    }
}