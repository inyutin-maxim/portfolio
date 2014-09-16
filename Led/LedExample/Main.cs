using System;
using System.Windows.Forms;

namespace LedExample {
	/// <summary>
	/// Главная форма
	/// </summary>
	public partial class Main : Form {
		/// <summary>
		/// Конструктор
		/// </summary>
		public Main() {
			InitializeComponent();
		}
		/// <summary>
		/// Обновление времени
		/// </summary>
		private void time_Tick(object sender, EventArgs e) {
			var now = DateTime.Now;
			dliHour.SetValue(now.Hour);
			dliMinutes.SetValue(now.Minute);
			dliSeconds.SetValue(now.Second);
		}
	}
}
