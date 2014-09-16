using System.Drawing;
using System.Windows.Forms;

namespace XOwf {
	/// <summary>
	/// Графика игры
	/// </summary>
	public static class Graphics {

		/// <summary>
		/// Перо для отрисовки поля
		/// </summary>
		private static readonly Pen Pen = new Pen(Color.Black, 3);

		/// <summary>
		/// Нарисовать поле
		/// </summary>
		/// <param name="panel">Панель для отрисовки поля</param>
		public static void DrawField(this Panel panel) {
			panel.CreateGraphics().Clear(Color.White);
			for (int i = 0; i < 3; i++) {
				for (int j = 0; j < 3; j++) {
					panel.CreateGraphics().DrawRectangle(Pen, Global.Margin + j * Global.Length, Global.Margin + i * Global.Length, Global.Length, Global.Length);
				}
			}
		}

		/// <summary>
		/// Нарисовать фигуру
		/// </summary>
		/// <param name="panel"></param>
		public static void DrawFigure(this Panel panel) {
			if (Game.CurrentPlayer) {
				DrawDagger(panel);
			} else {
				DrawZero(panel);
			}
			Game.CurrentPlayer = !Game.CurrentPlayer;
		}

		/// <summary>
		/// Нарисовать крестик
		/// </summary>
		/// <param name="panel">Панель для отрисовки крестика</param>
		private static void DrawDagger(this Panel panel) {
			panel.CreateGraphics().DrawLine(
				Pen
				, Field.X * Global.Length + Global.Margin
				, Field.Y * Global.Length + Global.Margin
				, Field.X * Global.Length + Global.Length + Global.Margin
				, Field.Y * Global.Length + Global.Length + Global.Margin
			);
			panel.CreateGraphics().DrawLine(
				Pen
				, Field.X * Global.Length + Global.Length + Global.Margin
				, Field.Y * Global.Length + Global.Margin
				, Field.X * Global.Length + Global.Margin
				, Field.Y * Global.Length + Global.Length + Global.Margin
			);
		}

		/// <summary>
		/// Нарисовать нолик
		/// </summary>
		/// <param name="panel">Панель для отрисовки нолика</param>
		private static void DrawZero(this Panel panel) {
			panel.CreateGraphics().DrawEllipse(
				Pen
				, Field.X * Global.Length + Global.Margin
				, Field.Y * Global.Length + Global.Margin
				, Global.Length
				, Global.Length
			);
		}

	}
}
