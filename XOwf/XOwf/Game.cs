using System.Windows.Forms;

namespace XOwf {
	/// <summary>
	/// Игра
	/// </summary>
	public static class Game {
		/// <summary>
		/// Состояние игры
		/// </summary>
		public static bool? State {
			get;
			set;
		}
		/// <summary>
		/// Текущий игрок
		/// </summary>
		public static bool CurrentPlayer {
			get;
			set;
		}
		/// <summary>
		/// Режим игры
		/// </summary>
		public static bool PvP {
			get;
			set;
		}
		/// <summary>
		/// Новая игра
		/// </summary>
		/// <param name="panel">Панель для игрового поля</param>
		/// <param name="mode">Режим игры</param>
		public static void New(Panel panel, bool mode) {
			Field.Clear();
			panel.DrawField();
			State = false;
			CurrentPlayer = true;
			PvP = mode;
		}
		/// <summary>
		/// Сделать ход
		/// </summary>
		public static void Cource(this Panel panel) {
			panel.SetValue();
			State = IsVictory();
			if (!PvP) {
				if (!CurrentPlayer) {
					AI.Cource();
					panel.SetValue();
				}
			}

			State = IsVictory();
		}
		/// <summary>
		/// Проверка на выигрыш
		/// </summary>
		/// <returns>Победа</returns>
		public static bool? IsVictory() {
			for (int i = 0; i < 3; i++) {
				// Проверка по столбцам
				if (
					(Field.IsCellEqual(i, 0, Global.Cross) && Field.IsCellEqual(i, 1, Global.Cross) && Field.IsCellEqual(i, 2, Global.Cross)) ||
					(Field.IsCellEqual(i, 0, Global.Zero) && Field.IsCellEqual(i, 1, Global.Zero) && Field.IsCellEqual(i, 2, Global.Zero))
					) {
					return true;
				}
				// проверка по строкам
				if (
					(Field.IsCellEqual(0, i, Global.Cross) && Field.IsCellEqual(1, i, Global.Cross) && Field.IsCellEqual(2, i, Global.Cross)) ||
					(Field.IsCellEqual(0, i, Global.Zero) && Field.IsCellEqual(1, i, Global.Zero) && Field.IsCellEqual(2, i, Global.Zero))
					) {
					return true;
				}
			}
			// проверка по диагоналям
			if (
				Field.IsCellEqual(0, 0, Global.Cross) && Field.IsCellEqual(1, 1, Global.Cross) && Field.IsCellEqual(2, 2, Global.Cross)
				|| (Field.IsCellEqual(0, 2, Global.Cross) && Field.IsCellEqual(1, 1, Global.Cross) && Field.IsCellEqual(2, 0, Global.Cross))
				|| (Field.IsCellEqual(0, 0, Global.Zero) && Field.IsCellEqual(1, 1, Global.Zero) && Field.IsCellEqual(2, 2, Global.Zero))
				|| (Field.IsCellEqual(0, 2, Global.Zero) && Field.IsCellEqual(1, 1, Global.Zero) && Field.IsCellEqual(2, 0, Global.Zero))
			) {
				return true;
			}
			for (int i = 0; i < 3; i++) {
				for (int j = 0; j < 3; j++) {
					if (Field.IsCellEqual(i, j, Global.Empty)) {
						return false;
					}
				}
			}
			return null;
		}
		/// <summary>
		/// Текст сообщения результата игры
		/// </summary>
		/// <returns></returns>
		public static string Winner() {
			string result = "Победили ";
			if (State.HasValue) {
				result += CurrentPlayer ? "Нолики" : "Крестики";
			} else {
				result = "Ничья";
			}
			return result;
		}
		/// <summary>
		/// Представить режим игры как текст
		/// </summary>
		/// <returns></returns>
		public static string ModeToString() {
			return PvP ? "С Человеком" : "Против компьютера";
		}
	}
}
