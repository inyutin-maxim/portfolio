using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Mvc;
using Mvc5.Entities;

namespace Mvc5.Areas.Default.Models
{
    public class DynamicTextPageModel : Controller
    {
		/// <summary>
		/// Контекст обращения к таблице динамических страниц
		/// </summary>
		private static dynamic_pageDataContext Context = new dynamic_pageDataContext( ConfigurationManager.ConnectionStrings[ "mvc5ConnectionString" ].ConnectionString );

		/// <summary>
		/// Получить список динамических страниц
		/// </summary>
		/// <returns></returns>
		public static IEnumerable<dynamic_page> GetDynamicPage() {
			return Context.dynamic_page.Where( dp => !dp.deleted && dp.visible );
		}

		/// <summary>
		/// Получить динамическую страницу по алиасу
		/// </summary>
		/// <param name="alias"></param>
		/// <returns></returns>
		public static dynamic_page GetDynamicPage( string alias ) {
			return Context.dynamic_page
				.Where( dp => !dp.deleted && dp.visible )
				.FirstOrDefault( dp => dp.alias == alias );
		}
	}
}