using System.Windows.Forms;

namespace XOwf {
	/// <summary>
	/// Игровое поле
	/// </summary>
	public static class Field {

		/// <summary>
		/// Координата X игрового поля
		/// </summary>
		public static int X {
			get;
			set;
		}

		/// <summary>
		/// Координата Y игрового поля
		/// </summary>
		public static int Y {
			get;
			set;
		}

		/// <summary>
		/// Поле
		/// </summary>
		private static int[,] _field = {
			{ Global.Empty, Global.Empty, Global.Empty }, 
			{ Global.Empty, Global.Empty, Global.Empty }, 
			{ Global.Empty, Global.Empty, Global.Empty } 
		};

		/// <summary>
		/// Очистить поле
		/// </summary>
		public static void Clear() {
			_field = new[,]{
				{ Global.Empty, Global.Empty, Global.Empty }, 
				{ Global.Empty, Global.Empty, Global.Empty }, 
				{ Global.Empty, Global.Empty, Global.Empty } 
			};
		}

		/// <summary>
		/// Задать значение полю
		/// </summary>
		/// <param name="panel">Панель</param>
		public static void SetValue(this Panel panel) {
			// Только в пустую ячейку можно задать значение
			if ( !IsCellEmpty() || Game.State != false ) {
				return;
			}
			_field[X, Y] = Game.CurrentPlayer? Global.Cross: Global.Zero;
			panel.DrawFigure();
		}

		/// <summary>
		/// Клетка пуста?
		/// </summary>
		/// <returns>Клетка пуста?</returns>
		public static bool IsCellEmpty() {
			return IsCellEqual(Global.Empty);
		}

		/// <summary>
		/// Значение клетки равно значению?
		/// </summary>
		/// <param name="value">Значение</param>
		/// <returns>Значение клетки равно значению?</returns>
		public static bool IsCellEqual(int value) {
			if (_field[X, Y] == value) {
				return true;
			}
			return false;
		}

		/// <summary>
		/// Значение клетки равно значению?
		/// </summary>
		/// <param name="y">>Координата мыши Y</param>
		/// <param name="value">Значение</param>
		/// <param name="x">>Координата мыши Х</param>
		/// <returns>Значение клетки равно значению?</returns>
		public static bool IsCellEqual(int x, int y, int value) {
			return _field[x, y] == value;
		}

		/// <summary>
		/// Получить координаты клетки из координаты мыши
		/// </summary>
		/// <param name="x">Координата мыши Х</param>
		/// <param name="y">Координата мыши Y</param>
		/// <remarks>Так как поле 3х3 то максимальное значение координаты равно 2 (отчет в массиве начинается с 0)</remarks>
		public static void GetIdByCoord(int x, int y) {
			X = (x - Global.Margin) / Global.Length;
			Y = (y - Global.Margin) / Global.Length;
			if (X > 2) {
				X = 2;
			}
			if (Y > 2) {
				Y = 2;
			}
		}
	}
}
