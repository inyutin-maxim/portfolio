using System.Drawing;
using System.Windows.Forms;

namespace Led {
	/// <summary>
	/// Класс расширений
	/// </summary>
	public static class Extensions {
		/// <summary>
		/// Установить состояние включено/выключено для сегмента
		/// </summary>
		/// <param name="pictureBox">Изображение</param>
		/// <param name="on">включено/выключено</param>
		public static void SetColor(this PictureBox pictureBox, bool on) {
			pictureBox.BackColor = on ? Color.Red : Color.Gray;
		}
	}
}
