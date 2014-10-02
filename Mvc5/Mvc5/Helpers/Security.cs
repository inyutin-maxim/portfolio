using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Mvc5.Helpers {
	/// <summary>
	/// Безопасность
	/// </summary>
	public static class Security {
		/// <summary>
		/// Список событий javascript
		/// </summary>
		private static readonly List<string> JSEvents = new List<string>();
		/// <summary>
		/// Заполнить список событий javascript
		/// </summary>
		private static void FillJSEvents() {
			JSEvents.Clear();
			JSEvents.Add( "onAbort" );
			JSEvents.Add( "onBlur" );
			JSEvents.Add( "onChange" );
			JSEvents.Add( "onClick" );
			JSEvents.Add( "onDblClick" );
			JSEvents.Add( "onError" );
			JSEvents.Add( "onFocus" );
			JSEvents.Add( "onKeyDown" );
			JSEvents.Add( "onKeyPress" );
			JSEvents.Add( "onKeyUp" );
			JSEvents.Add( "onLoad" );
			JSEvents.Add( "onMouseDown" );
			JSEvents.Add( "onMouseMove" );
			JSEvents.Add( "onMouseOut" );
			JSEvents.Add( "onMouseOver" );
			JSEvents.Add( "onMouseUp" );
			JSEvents.Add( "onMove" );
			JSEvents.Add( "onReset" );
			JSEvents.Add( "onResize" );
			JSEvents.Add( "onSelect" );
			JSEvents.Add( "onSubmit" );
			JSEvents.Add( "onUnload" );
		}
		/// <summary>
		/// Обрезать Javascript
		/// </summary>
		/// <param name="content"></param>
		/// <returns></returns>
		public static string RemoveJS( this string content ) {
			FillJSEvents();
			var pattern = "(" + string.Join( "|", JSEvents ) + ")=\"[^\"]*\"";
			Regex regex = new Regex( pattern );
			pattern = @"<script[^>]>(.)*</script>";
			Regex script = new Regex( pattern, RegexOptions.Singleline );
			var result = regex.Replace( content, "" );
			result = script.Replace( result, "" );
			return result;
		}
	}
}