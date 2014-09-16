using System;
using System.Windows.Forms;

namespace _2048 {
	/// <summary>
	/// Игровое поле
	/// </summary>
	public static class Field {
		/// <summary>
		/// Игровое поле
		/// </summary>
		private static int[,] _field = {
			{Global.Empty,Global.Empty,Global.Empty,Global.Empty},
			{Global.Empty,Global.Empty,Global.Empty,Global.Empty},
			{Global.Empty,Global.Empty,Global.Empty,Global.Empty},
			{Global.Empty,Global.Empty,Global.Empty,Global.Empty}
		};
		/// <summary>
		/// Временное поле
		/// </summary>
		private static int[,] _temp = {
			{Global.Empty,Global.Empty,Global.Empty,Global.Empty},
			{Global.Empty,Global.Empty,Global.Empty,Global.Empty},
			{Global.Empty,Global.Empty,Global.Empty,Global.Empty},
			{Global.Empty,Global.Empty,Global.Empty,Global.Empty}
		};
		/// <summary>
		/// Старое значение поля
		/// </summary>
		private readonly static int[,] OldField = {
			{Global.Empty,Global.Empty,Global.Empty,Global.Empty},
			{Global.Empty,Global.Empty,Global.Empty,Global.Empty},
			{Global.Empty,Global.Empty,Global.Empty,Global.Empty},
			{Global.Empty,Global.Empty,Global.Empty,Global.Empty}
		};
		/// <summary>
		/// Случайное число
		/// </summary>
		private readonly static Random RandomNumber = new Random();
		/// <summary>
		/// Проверка есть ли изменения
		/// </summary>
		/// <returns></returns>
		private static bool IsChanged {
			get {
				for (int line = 0; line < Global.Dimensionality; line++) {
					for (int column = 0; column < Global.Dimensionality; column++) {
						if (_field[line, column] != OldField[line, column]) {
							return true;
						}
					}
				}
				return false;
			}
		}
		/// <summary>
		/// Проверка сдвинуто ли
		/// </summary>
		/// <returns></returns>
		private static bool IsShifted {
			get;
			set;
		}
		/// <summary>
		/// Очистить поле
		/// </summary>
		public static void Clear() {
			_field = new[,] {
				{Global.Empty,Global.Empty,Global.Empty,Global.Empty},
				{Global.Empty,Global.Empty,Global.Empty,Global.Empty},
				{Global.Empty,Global.Empty,Global.Empty,Global.Empty},
				{Global.Empty,Global.Empty,Global.Empty,Global.Empty}
			};
			_temp = _field;
		}
		/// <summary>
		/// Установить значение
		/// </summary>
		/// <param name="line">Строка</param>
		/// <param name="column">Столбец</param>
		/// <param name="value">Значение</param>
		private static void Set(int line, int column, int value) {
			_field[line, column] = value;
		}
		/// <summary>
		/// Передвинуть если возможно
		/// </summary>
		/// <param name="key">Код нажатой клавиши</param>
		public static void Move(Keys key) {
			_field.CopyTo(OldField);
			IsShifted = false;
			switch (key) {
				case Keys.Down:
				case Keys.S:
				MoveToDown();
				break;
				case Keys.Left:
				case Keys.A:
				MoveToLeft();
				break;
				case Keys.Right:
				case Keys.D:
				MoveToRight();
				break;
				case Keys.Up:
				case Keys.W:
				MoveToUp();
				break;
			}
			if (IsChanged) {
				AddNewValue();
				Graphic.DrawContent();
			}
		}
		/// <summary>
		/// Передвинуть влево
		/// </summary>
		private static void MoveToLeft() {
			for (int line = 0; line < Global.Dimensionality; line++) {
				// 1) Сдвинуть влево
				ShiftToLeft(line, 0);
				// 2) Сложить слева направо одинаковые значения
				for (int column = 0; column < Global.Dimensionality - 1; column++) {
					if (_field[line, column] == _field[line, column + 1]) {
						_temp[line, column] *= 2;
						_field[line, column + 1] = Global.Empty;
						Game.PointCount += _temp[line, column];
						ShiftToLeft(line, 0);
					}
				}
				// 3) Сдвинуть влево
				ShiftToLeft(line, 0);
			}
			_field = _temp;
		}
		/// <summary>
		/// Передвинуть вправо
		/// </summary>
		private static void MoveToRight() {
			for (int line = 0; line < Global.Dimensionality; line++) {
				// 1) Сдвинуть вправо
				ShiftToRight(line, 0);
				// 2) Сложить справа налево одинаковые значения
				for (int column = Global.Dimensionality - 1; column > 0; column--) {
					if (_field[line, column] == _field[line, column - 1]) {
						_temp[line, column] *= 2;
						_field[line, column - 1] = Global.Empty;
						Game.PointCount += _temp[line, column];
						ShiftToRight(line, column + 1);
					}
				}
				// 3) Сдвинуть вправо
				ShiftToRight(line, 0);
			}
			_field = _temp;
		}
		/// <summary>
		/// Передвинуть вверх 
		/// </summary>
		private static void MoveToUp() {
			for (int line = 0; line < Global.Dimensionality - 1; line++) {
				// 1) Сдвинуть вверх
				ShiftToUp();
				// 2) Сложить сверху вниз одинаковые значения
				for (int column = 0; column < Global.Dimensionality; column++) {
					if (_field[line, column] == _field[line + 1, column]) {
						_temp[line, column] *= 2;
						_field[line + 1, column] = Global.Empty;
						Game.PointCount += _temp[line, column];
						ShiftToUp();
					}
				}
				// 3) Сдвинуть вверх
				ShiftToUp();
			}
			_field = _temp;
		}
		/// <summary>
		/// Передвинуть вниз
		/// </summary>
		private static void MoveToDown() {
			for (int line = Global.Dimensionality - 1; line > 0; line--) {
				// 1) Сдвинуть вниз
				ShiftToDown();
				// 2) Сложить снизу вверх одинаковые значения
				for (int column = 0; column < Global.Dimensionality; column++) {
					if (_field[line, column] == _field[line - 1, column]) {
						_temp[line, column] *= 2;
						_field[line - 1, column] = Global.Empty;
						Game.PointCount += _temp[line, column];
						ShiftToDown();
					}
				}
				// 1) Сдвинуть вниз
				ShiftToDown();
			}
			_field = _temp;
		}
		/// <summary>
		/// Сдвинуть влево
		/// </summary>
		/// <param name="line">Строка</param>
		/// <param name="column">Столбец</param>
		private static void ShiftToLeft(int line, int column) {
			for (int i = 0; i < 4; i++) {
				for (int j = column; j < Global.Dimensionality - 1; j++) {
					if (_field[line, j] == Global.Empty && _field[line, j + 1] != Global.Empty) {
						_field[line, j] = _field[line, j + 1];
						_field[line, j + 1] = 0;
						if (!IsShifted) {
							IsShifted = true;
						}
					}
				}
			}
		}

		/// <summary>
		/// Сдвинуть вправо
		/// </summary>
		/// <param name="line">Строка</param>
		/// <param name="column">Столбец</param>
		private static void ShiftToRight(int line, int column) {
			for (int i = 0; i < 4; i++) {
				for (int j = Global.Dimensionality - 1; j > column; j--) {
					if (_field[line, j] == Global.Empty && _field[line, j - 1] != Global.Empty) {
						_field[line, j] = _field[line, j - 1];
						_field[line, j - 1] = 0;
						if (!IsShifted) {
							IsShifted = true;
						}
					}
				}
			}
		}
		/// <summary>
		/// Сдвинуть вниз
		/// </summary>
		private static void ShiftToDown() {
			for (int line = 1; line < 4; line++) {
				for (int column = 0; column < 4; column++) {
					if (_field[line, column] == Global.Empty && _field[line - 1, column] != Global.Empty) {
						_field[line, column] = _field[line - 1, column];
						_field[line - 1, column] = 0;
						if (!IsShifted) {
							IsShifted = true;
						}
					}
				}
			}
		}
		/// <summary>
		/// Сдвинуть вверх
		/// </summary>
		private static void ShiftToUp() {
			for (int line = 2; line > -1; line--) {
				for (int column = 0; column < 4; column++) {
					if (_field[line, column] == Global.Empty && _field[line + 1, column] != Global.Empty) {
						_field[line, column] = _field[line + 1, column];
						_field[line + 1, column] = 0;
						if (!IsShifted) {
							IsShifted = true;
						}
					}
				}
			}
		}
		/// <summary>
		/// Проверка на проигрыш
		/// </summary>
		public static bool IsLose() {
			bool hasEmpty = false;
			for (int line = 2; line > -1; line--) {
				for (int column = 0; column < 4; column++) {
					if (_field[line, column] == Global.Empty) {
						hasEmpty = true;
					}
				}
			}
			return !hasEmpty && !IsShifted;
		}
		/// <summary>
		/// Добавить новое случайное значение
		/// </summary>
		public static void AddNewValue() {
			int line = RandomNumber.Next(Global.Dimensionality);
			int column = RandomNumber.Next(Global.Dimensionality);
			if (_field[line, column] == Global.Empty) {
				Set(line, column, RandomValue());
			} else {
				for (int i = 0; i < Global.Dimensionality; i++) {
					for (int j = 0; j < Global.Dimensionality; j++) {
						if (_field[i, j] == Global.Empty) {
							Set(i, j, RandomValue());
							return;
						}
					}
				}
			}
		}
		/// <summary>
		/// Случайное значение
		/// </summary>
		/// <returns>С 80% вероятностью возвращает 2, в остальных 20% случаев 4</returns>
		private static int RandomValue() {
			if (RandomNumber.Next(100) >= 80) {
				return 4;
			} 
				return 2;
		}
		/// <summary>
		/// Получить значение клетки
		/// </summary>
		/// <param name="line">Строка</param>
		/// <param name="column">Столбец</param>
		/// <returns>Значение</returns>
		public static int GetValue(int line, int column) {
			return _field[line, column];
		}
		/// <summary>
		/// Копирование из одного массива в другой
		/// </summary>
		/// <param name="current">Исходный массив</param>
		/// <param name="destiny">Массив назначения</param>
		private static void CopyTo(this int[,] current, int[,] destiny) {
			for (int line = 0; line < Global.Dimensionality; line++) {
				for (int column = 0; column < Global.Dimensionality; column++) {
					destiny[line, column] = current[line, column];
				}
			}
		}
	}
}
