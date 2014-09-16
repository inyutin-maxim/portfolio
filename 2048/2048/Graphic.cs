using System.Drawing;
using System.Windows.Forms;

namespace _2048 {
	/// <summary>
	/// Графика
	/// </summary>
	public static class Graphic {
		/// <summary>
		/// Объект для рисования прямых линий
		/// </summary>
		private readonly static Pen Pen = new Pen(Color.Black, Global.PenWidth);
		/// <summary>
		/// Компонент для отрисовки поля
		/// </summary>
		public static Panel FieldBox {
			private get;
			set;
		}
		/// <summary>
		/// Получить цвет для клетки по значению
		/// </summary>
		/// <returns></returns>
		private static Color GetColor(int value) {
			Color color;
			switch (value) {
				case 0:
				color = Color.White;
				break;
				case 2:
				color = ColorTranslator.FromHtml("#eee4da");
				break;
				case 4:
				color = ColorTranslator.FromHtml("#ede0c8");
				break;
				case 8:
				color = ColorTranslator.FromHtml("#f2b179");
				break;
				case 16:
				color = ColorTranslator.FromHtml("#f59563");
				break;
				case 32:
				color = ColorTranslator.FromHtml("#f67c5f");
				break;
				case 64:
				color = ColorTranslator.FromHtml("#f65e3b");
				break;
				case 128:
				color = ColorTranslator.FromHtml("#edcf72");
				break;
				case 256:
				color = ColorTranslator.FromHtml("#edcc61");
				break;
				case 512:
				color = ColorTranslator.FromHtml("#edc850");
				break;
				case 1024:
				color = ColorTranslator.FromHtml("#edc53f");
				break;
				case 2048:
				color = ColorTranslator.FromHtml("#edc22e");
				break;
				default:
				color = ColorTranslator.FromHtml("#3c3a32");
				break;
			}

			return color;
		}
		/// <summary>
		/// Нарисовать игровое поле
		/// </summary>
		public static void DrawField() {
			FieldBox.CreateGraphics().Clear(Color.White);
			for (int i = 0; i < 5; i++) {
				int lineValue = i * Global.CellSize + Global.Margin;
				// Горизонтальные линии
				FieldBox.CreateGraphics().DrawLine(
					Pen
					, Global.Margin
					, lineValue
					, Global.EdgeOfField + Global.Margin
					, lineValue
				);
				// Вертикальные линии
				FieldBox.CreateGraphics().DrawLine(
					Pen
					, lineValue
					, Global.Margin
					, lineValue
					, Global.EdgeOfField + Global.Margin
				);
			}
		}
		/// <summary>
		/// Нарисовать содержимое поля
		/// </summary>
		public static void DrawContent() {
			for (int line = 0; line < Global.Dimensionality; line++) {
				for (int column = 0; column < Global.Dimensionality; column++) {
					FieldBox.CreateGraphics().FillRectangle(
						new SolidBrush(GetColor(Field.GetValue(line, column)))
						, column * Global.CellSize + Global.FillMargin
						, line * Global.CellSize + Global.FillMargin
						, Global.FillCellSize
						, Global.FillCellSize
					);
					string value = Field.GetValue(line, column) > 0 ? Field.GetValue(line, column) + string.Empty : string.Empty;
					FieldBox.CreateGraphics().DrawString(
						value
						, new Font("Arial", 14)
						, new SolidBrush(Color.Black)
						, new PointF(column * Global.CellSize + Global.FillMargin
						, line * Global.CellSize + Global.TextMargin)
					);
				}
			}
		}
	}
}
