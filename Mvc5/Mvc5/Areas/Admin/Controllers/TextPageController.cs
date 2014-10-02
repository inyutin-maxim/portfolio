using System;
using System.Web.Mvc;
using Mvc5.Areas.Admin.Models;

namespace Mvc5.Areas.Admin.Controllers {
	public class TextPageController : Controller {
		/// <summary>
		/// Список текстовых страниц
		/// </summary>
		/// <returns></returns>
		public ActionResult Index() {

			return View( DynamicPageModel.GetDynamicPage() );
		}

		/// <summary>
		/// Показать текстовую страницу как это будет выглядеть на сайте
		/// </summary>
		/// <param name="alias"></param>
		/// <returns></returns>
		public ActionResult Details( string alias ) {
			return View( DynamicPageModel.GetDynamicPage( alias ) );
		}

		//
		// GET: /Admin/DynamicTextPage/Create
		public ActionResult Create() {
			return View();
		}

		//
		// POST: /Admin/DynamicTextPage/Create
		[HttpPost]
		public ActionResult Create( FormCollection collection ) {
			try {
				// TODO: Add insert logic here

				return RedirectToAction( "Index" );
			} catch {
				return View();
			}
		}

		/// <summary>
		/// Изменить текстовую страницу
		/// </summary>
		/// <param name="alias"></param>
		/// <param name="collection"></param>
		/// <returns></returns>
		[HttpPost]
		public JsonResult Edit( string alias ) {
			var data = DynamicPageModel.GetDynamicPage( alias );
			data.alias = alias;
			data.content = Request[ "content" ];
			DynamicPageModel.Save( data );
			return Json( data );
		}

		/// <summary>
		/// Удалить текстовую страницу
		/// </summary>
		/// <param name="alias"></param>
		/// <returns></returns>
		[HttpPost]
		public JsonResult Delete( string alias ) {
			return Json( new {
				success = DynamicPageModel.Delete( alias )
			} );
		}
	}
}
