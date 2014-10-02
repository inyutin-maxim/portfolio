using System.Web.Mvc;
using System.Web.Routing;
using Mvc5.Areas.Admin;
using Mvc5.Areas.Default;

namespace Mvc5 {
	public class MvcApplication : System.Web.HttpApplication {
		protected void Application_Start() {
			var adminArea = new AdminAreaRegistration();
			var adminAreaContext = new AreaRegistrationContext( adminArea.AreaName, RouteTable.Routes );
			adminArea.RegisterArea( adminAreaContext );

			var defaultArea = new DefaultAreaRegistration();
			var defaultAreaContext = new AreaRegistrationContext( defaultArea.AreaName, RouteTable.Routes );
			defaultArea.RegisterArea( defaultAreaContext );
		}
	}
}
