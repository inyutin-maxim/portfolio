using System;


namespace Kinoteatr {
	/// <summary>
	/// Информация о текущем сеансе
	/// </summary>
	public static class SeansInfo {
		private static Seans _seans;
		/// <summary>
		/// Название фильма
		/// </summary>
		public static Seans Seans {
			get {
				return _seans;
			}
			set {
				_seans = value;
			}
		}
		/// <summary>
		/// Название фильма
		/// </summary>
		public static string Film {
			get {
				return _seans.Film;
			}
		}
		/// <summary>
		/// Время сеанса
		/// </summary>
		public static DateTime Time {
			get {
				return _seans.Time;
			}
		}
	}
}
