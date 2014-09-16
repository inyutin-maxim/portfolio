using System.Windows.Forms;
using _2048.Properties;

namespace _2048 {
	/// <summary>
	/// Главная форма
	/// </summary>
	public partial class Main : Form {
		/// <summary>
		/// Точка входа в приложение
		/// </summary>
		public Main() {
			InitializeComponent();
			Graphic.FieldBox = FieldBox;
		}
		/// <summary>
		/// Событие отпускания клавиши для главной формы 
		/// </summary>
		private void Main_KeyDown(object sender, KeyEventArgs e) {
			Game.DoStep(e.KeyCode);
			Status.Text = Resources.StatusText + Game.PointCount;
			Game.IsVictory();
		}
		
		/// <summary>
		/// Первый запуск. Нужно чтобы при запуске отрисовалось поле 1 раз
		/// </summary>
		private bool _isFirstStart = true;
		/// <summary>
		/// Перерисовать поле
		/// </summary>
		private void FieldBox_Paint(object sender, PaintEventArgs e) {
			if ( !_isFirstStart ) {
				return;
			}
			Game.New();
			_isFirstStart = false;
		}
		/// <summary>
		/// Клик по пункту меню "Новая игра"
		/// </summary>
		private void новаяИграToolStripMenuItem_Click(object sender, System.EventArgs e) {
			Game.New();
		}
		/// <summary>
		/// Клик по пункту меню "Выход"
		/// </summary>
		private void выходToolStripMenuItem_Click(object sender, System.EventArgs e) {
			Application.Exit();
		}
		/// <summary>
		/// Клик по пункту меню "О программе"
		/// </summary>
		private void справкаToolStripMenuItem_Click(object sender, System.EventArgs e) {
			MessageBox.Show(Resources.AboutText, Resources.InformationText);
			Graphic.DrawField();
			Graphic.DrawContent();
		}

		private void menuStrip1_MenuDeactivate(object sender, System.EventArgs e) {
			Graphic.DrawField();
			Graphic.DrawContent();
		}
	}
}
