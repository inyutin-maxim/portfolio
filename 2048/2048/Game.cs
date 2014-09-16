using System.Windows.Forms;
using _2048.Properties;

namespace _2048 {
	/// <summary>
	/// Игра
	/// </summary>
	public static class Game {
		/// <summary>
		/// Новая игра
		/// </summary>
		public static void New() {
			Graphic.DrawField();
			Field.Clear();
			// Должно быть 2 клетки заполнено с начала игры
			Field.AddNewValue();
			Field.AddNewValue();
			PointCount = 0;
			Graphic.DrawContent();
		}
		/// <summary>
		/// Количество очков
		/// </summary>
		public static int PointCount {
			get;
			set;
		}
		/// <summary>
		/// Сделать шаг
		/// </summary>
		/// <param name="key">Код клавиши</param>
		public static void DoStep(Keys key) {
			if (key == Keys.F2) {
				New();
			}
			Field.Move(key);
		}
		/// <summary>
		/// Проверка на победу
		/// </summary>
		/// <returns></returns>
		public static void IsVictory() {
			bool victory = false;
			// Проверка
			for (int i = 0; i < 4; i++) {
				for (int j = 0; j < 4; j++) {
					if (Field.GetValue(i, j) == 2048) {
						victory = true;
					}
				}
			}
			// Оповещение пользователя
			if (!IsContinueGame) {
				if (victory || Field.IsLose()) {
					string message = victory ? Resources.VictoryText : Resources.LoseText;
					var dialogResult = MessageBox.Show(message, Resources.InformationText, MessageBoxButtons.YesNo);
					if (dialogResult == DialogResult.Yes) {
						New();
					}
					if (Field.IsLose()) {
						Application.Exit();
					}
					IsContinueGame = true;
				}
			}
		}
		/// <summary>
		/// Продолжить игру
		/// </summary>
		private static bool IsContinueGame {
			get;
			set;
		}
	}
}
