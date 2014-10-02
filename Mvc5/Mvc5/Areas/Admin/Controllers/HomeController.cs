using System.Web.Mvc;
using Mvc5.Areas.Admin.Models;

namespace Mvc5.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Главная страница администраторского раздела
        /// </summary>
        /// <returns></returns>
        public ActionResult Index() {
	        var model = DynamicPageModel.GetDynamicPage( "main" );
			return View( model );
        }

    }
}
