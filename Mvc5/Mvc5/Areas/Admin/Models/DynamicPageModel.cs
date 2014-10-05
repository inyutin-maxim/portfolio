using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Http;
using Mvc5.Entities;
using Mvc5.Helpers;

namespace Mvc5.Areas.Admin.Models
{
    public class DynamicPageModel : ApiController
    {
		/// <summary>
		/// Контекст обращения к таблице динамических страниц
		/// </summary>
		private static  dynamic_pageDataContext Context = new dynamic_pageDataContext( ConfigurationManager.ConnectionStrings[ "mvc5ConnectionString" ].ConnectionString );

        /// <summary>
        /// Получить список динамических страниц
        /// </summary>
        /// <returns></returns>
		public static IEnumerable<dynamic_page> GetDynamicPage()
        {
            return Context.dynamic_page.Where( dp => !dp.deleted );
        }

        /// <summary>
        /// Получить динамическую страницу по алиасу
        /// </summary>
        /// <param name="alias"></param>
        /// <returns></returns>
		public static dynamic_page GetDynamicPage( string alias )
        {
            return Context.dynamic_page
				.Where( dp => !dp.deleted )
				.FirstOrDefault(dp => dp.alias == alias );
        }

		/// <summary>
		/// Сохранить изменения
		/// </summary>
		/// <param name="data">Данные страницы</param>
		public static void Save( dynamic_page data ) {
			data.content = data.content.RemoveJs();
			data.alias = data.content.RemoveJs();
			data.title = data.title.RemoveJs();

			if ( data.id <= 0 ) {
				data.create_date = DateTime.Now;
				Context.dynamic_page.InsertOnSubmit( data );
				return;
			}
			Context.dynamic_page.Context.SubmitChanges();
		}

	    /// <summary>
	    /// Удалить страницу
	    /// </summary>
	    /// <param name="alias"></param>
	    public static bool Delete( string alias ) {
			var data = Context.dynamic_page.FirstOrDefault( n => n.alias == alias );
			if ( data == null ) {
				return false;
			}
			data.deleted = true;
			Context.dynamic_page.Context.SubmitChanges();
			return true;
		}

		/// <summary>
		/// Показывать страницу
		/// </summary>
		/// <param name="alias"></param>
		public static bool Show( string alias ) {
			var data = Context.dynamic_page.FirstOrDefault( n => n.alias ==  alias);
			if ( data == null ) {
				return false;
			}
			data.visible = !data.visible;
			Context.dynamic_page.Context.SubmitChanges();
			return true;
		}
    }
}