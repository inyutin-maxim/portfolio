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
		private static readonly List<string> JsEvents = new List<string>();
		/// <summary>
		/// Заполнить список событий javascript
		/// </summary>
		private static void FillJsEvents() {
			JsEvents.Clear();
			JsEvents.Add( "onafterprint" );
			JsEvents.Add( "onbeforeprint" );
			JsEvents.Add( "onbeforeunload" );
			JsEvents.Add( "onerror" );
			JsEvents.Add( "onhashchange" );
			JsEvents.Add( "onload" );
			JsEvents.Add( "onmessage" );
			JsEvents.Add( "onoffline" );
			JsEvents.Add( "ononline" );
			JsEvents.Add( "onpagehide" );
			JsEvents.Add( "onpageshow" );
			JsEvents.Add( "onpopstate" );
			JsEvents.Add( "onresize" );
			JsEvents.Add( "onstorage" );
			JsEvents.Add( "onunload" );
			JsEvents.Add( "onblur" );
			JsEvents.Add( "onchange" );
			JsEvents.Add( "oncontextmenu" );
			JsEvents.Add( "onfocus" );
			JsEvents.Add( "oninput" );
			JsEvents.Add( "oninvalid" );
			JsEvents.Add( "onreset" );
			JsEvents.Add( "onsearch" );
			JsEvents.Add( "onselect" );
			JsEvents.Add( "onsubmit" );
			JsEvents.Add( "onkeydown" );
			JsEvents.Add( "onkeypress" );
			JsEvents.Add( "onkeyup" );
			JsEvents.Add( "onclick" );
			JsEvents.Add( "ondblclick" );
			JsEvents.Add( "ondrag" );
			JsEvents.Add( "ondragend" );
			JsEvents.Add( "ondragenter" );
			JsEvents.Add( "ondragleave" );
			JsEvents.Add( "ondragover" );
			JsEvents.Add( "ondragstart" );
			JsEvents.Add( "ondrop" );
			JsEvents.Add( "onmousedown" );
			JsEvents.Add( "onmousemove" );
			JsEvents.Add( "onmouseout" );
			JsEvents.Add( "onmouseover" );
			JsEvents.Add( "onmouseup" );
			JsEvents.Add( "onmousewheel" );
			JsEvents.Add( "onscroll" );
			JsEvents.Add( "onwheel" );
			JsEvents.Add( "oncopy" );
			JsEvents.Add( "oncut" );
			JsEvents.Add( "onpaste" );
			JsEvents.Add( "onabort" );
			JsEvents.Add( "oncanplay" );
			JsEvents.Add( "oncanplaythrough" );
			JsEvents.Add( "oncuechange" );
			JsEvents.Add( "ondurationchange" );
			JsEvents.Add( "onemptied" );
			JsEvents.Add( "onended" );
			JsEvents.Add( "onloadeddata" );
			JsEvents.Add( "onloadedmetadata" );
			JsEvents.Add( "onloadstart" );
			JsEvents.Add( "onpause" );
			JsEvents.Add( "onplay" );
			JsEvents.Add( "onplaying" );
			JsEvents.Add( "onprogress" );
			JsEvents.Add( "onratechange" );
			JsEvents.Add( "onseeked" );
			JsEvents.Add( "onseeking" );
			JsEvents.Add( "onstalled" );
			JsEvents.Add( "onsuspend" );
			JsEvents.Add( "ontimeupdate" );
			JsEvents.Add( "onvolumechange" );
			JsEvents.Add( "onwaiting" );
			JsEvents.Add( "onshow" );
			JsEvents.Add( "ontoggle" );
		}
		/// <summary>
		/// Обрезать Javascript
		/// </summary>
		/// <param name="content"></param>
		/// <returns></returns>
		public static string RemoveJs( this string content ) {
			FillJsEvents();
			var pattern = "(" + string.Join( "|", JsEvents ) + ")=\"[^\"]*\"";
			Regex regex = new Regex( pattern, RegexOptions.IgnoreCase );
			pattern = @"<script[^>]*>(.)*</script>";
			Regex script = new Regex( pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase );
			var result = regex.Replace( content, "" );
			result = script.Replace( result, "" );
			return result;
		}
	}
}