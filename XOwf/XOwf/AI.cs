using System;

namespace XOwf {
	/// <summary>
	/// Искусственный интеллект
	/// </summary>
	public static class AI {
		private static readonly Random R = new Random();
		/// <summary>
		/// Ход компьютера
		/// </summary>
		public static void Cource() {
			// Проверка нет ли выигрышного варианта для компьютера
			if (CheckNextIsVictory(Global.Zero)) {
				return;
			}
			// Проверка нет ли выигрышного варианта для игрока
			if (CheckNextIsVictory(Global.Cross)) {
				return;
			}
			SetRandom();
		}
		/// <summary>
		/// Установить 0 в случайной клетке
		/// </summary>
		private static void SetRandom() {
			Field.X = R.Next(3);
			Field.Y = R.Next(3);
			if (!Field.IsCellEmpty()) {
				for (int i = 0; i < 3; i++) {
					for (int j = 0; j < 3; j++) {
						Field.X = i;
						Field.Y = j;
						if (Field.IsCellEmpty()) {
							return;
						}
					}
				}
			}
		}
		/// <summary>
		/// Проверить следующий ход
		/// </summary>
		/// <param name="figure">Крестик / Нолик</param>
		/// <returns>Есть выигрышная позиция?</returns>
		public static bool CheckNextIsVictory(int figure) {
			for (int i = 0; i < 3; i++) {
				// Проверка по столбцам
				if (Field.IsCellEqual(i, 0, figure) && Field.IsCellEqual(i, 1, figure) && Field.IsCellEqual(i, 2, Global.Empty)) {
					Field.Y = 2;
					Field.X = i;
					return true;
				}
				if (Field.IsCellEqual(i, 0, figure) && Field.IsCellEqual(i, 2, figure) && Field.IsCellEqual(i, 1, Global.Empty)) {
					Field.Y = 1;
					Field.X = i;
					return true;
				}
				if (Field.IsCellEqual(i, 1, figure) && Field.IsCellEqual(i, 2, figure) && Field.IsCellEqual(i, 0, Global.Empty)) {
					Field.Y = 0;
					Field.X = i;
					return true;
				}
				// Проверка по строкам
				if (Field.IsCellEqual(0, i, figure) && Field.IsCellEqual(1, i, figure) && Field.IsCellEqual(2, i, Global.Empty)) {
					Field.Y = i;
					Field.X = 2;
					return true;
				}
				if (Field.IsCellEqual(0, i, figure) && Field.IsCellEqual(2, i, figure) && Field.IsCellEqual(1, i, Global.Empty)) {
					Field.Y = i;
					Field.X = 1;
					return true;
				}
				if (Field.IsCellEqual(1, i, figure) && Field.IsCellEqual(2, i, figure) && Field.IsCellEqual(0, i, Global.Empty)) {
					Field.Y = i;
					Field.X = 0;
					return true;
				}
			}
			// проверка по главной диагонали
			if (Field.IsCellEqual(0, 0, figure) && Field.IsCellEqual(1, 1, figure) && Field.IsCellEqual(2, 2, Global.Empty)) {
				Field.Y = 2;
				Field.X = 2;
				return true;
			}
			if (Field.IsCellEqual(0, 0, figure) && Field.IsCellEqual(2, 2, figure) && Field.IsCellEqual(1, 1, Global.Empty)) {
				Field.Y = 1;
				Field.X = 1;
				return true;
			}
			if (Field.IsCellEqual(1, 1, figure) && Field.IsCellEqual(2, 2, figure) && Field.IsCellEqual(0, 0, Global.Empty)) {
				Field.Y = 0;
				Field.X = 0;
				return true;
			}
			// проверка по обратной диагонали
			if (Field.IsCellEqual(0, 2, figure) && Field.IsCellEqual(1, 1, figure) && Field.IsCellEqual(2, 0, Global.Empty)) {
				Field.Y = 0;
				Field.X = 2;
				return true;
			}
			if (Field.IsCellEqual(0, 2, figure) && Field.IsCellEqual(2, 0, figure) && Field.IsCellEqual(1, 1, Global.Empty)) {
				Field.Y = 1;
				Field.X = 1;
				return true;
			}
			if (Field.IsCellEqual(1, 1, figure) && Field.IsCellEqual(2, 0, figure) && Field.IsCellEqual(0, 2, Global.Empty)) {
				Field.Y = 2;
				Field.X = 0;
				return true;
			}
			return false;
		}
	}
}
