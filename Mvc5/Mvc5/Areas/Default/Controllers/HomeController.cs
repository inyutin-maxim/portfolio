using System.Web.Http;
using System.Web.Mvc;

namespace Mvc5.Areas.Default.Controllers {
	/// <summary>
	/// Контроллер главной страницы сайта
	/// </summary>
	public class HomeController : Controller {
		/// <summary>
		/// Главная страница сайта
		/// </summary>
		/// <returns></returns>
		public ActionResult Index() {
			return View();
		}
	}
}
