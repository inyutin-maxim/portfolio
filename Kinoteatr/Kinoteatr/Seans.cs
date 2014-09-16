using System.Collections.Generic;
using System.Linq;

namespace Kinoteatr {
	/// <summary>
	/// Сеанс
	/// </summary>
	public class Seans {
		/// <summary>
		/// Название фильма
		/// </summary>
		public string Film {
			get;
			set;
		}
		/// <summary>
		/// Места
		/// </summary>
		public List<Place> Places = new List<Place>();
		/// <summary>
		/// Наличие свободных мест
		/// </summary>
		public bool EmptyPlaceExist() {
			return Places.Any( item => !item.IsOccupied );
		}

		/// <summary>
		/// Выручка за сеанс
		/// </summary>
		/// <returns></returns>
		public double Revenue() {
			return Places.Where( item => item.IsOccupied ).Sum( item => item.Cost );
		}
	}
}
