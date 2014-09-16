using System;
using System.Windows.Forms;

namespace XOwf {
	/// <summary>
	/// Главная форма
	/// </summary>
	public partial class Main : Form {
		/// <summary>
		/// Точка входа
		/// </summary>
		public Main() {
			InitializeComponent();
		}
		/// <summary>
		/// Первый запуск
		/// </summary>
		bool _isFirstStart = true;
		/// <summary>
		/// Отрисовка панели
		/// </summary>
		private void panel1_Paint(object sender, PaintEventArgs e) {
			if (_isFirstStart) {
				Game.New(FieldPanel, rbTwoPlayer.Checked);
				status.Text = string.Format("Режим игры: " + Game.ModeToString());
			}
			_isFirstStart = false;
		}
		/// <summary>
		/// Клик мыши по панели
		/// </summary>
		private void panel1_MouseClick(object sender, MouseEventArgs e) {
			Field.GetIdByCoord(e.X, e.Y);
			FieldPanel.Cource();
			if ( Game.State == false ) {
				return;
			}
			var result = MessageBox.Show("Игра окончена. " + Game.Winner(),"Информация",MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes) {
				Game.New(FieldPanel, rbTwoPlayer.Checked);
			}
		}

		/// <summary>
		/// Пункт меню "Новая игра"
		/// </summary>
		private void newGameToolStripMenuItem_Click(object sender, EventArgs e) {
			Game.New(FieldPanel, rbTwoPlayer.Checked);
			status.Text = string.Format("Режим игры: " + Game.ModeToString());
		}

		/// <summary>
		/// Пункт меню "Выход"
		/// </summary>
		private void ExitToolStripMenuItem_Click(object sender, EventArgs e) {
			Application.Exit();
		}
		/// <summary>
		/// Кнопка "Новая игра"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NewGame_Click(object sender, EventArgs e) {
			Game.New(FieldPanel, rbTwoPlayer.Checked);
			status.Text = string.Format("Режим игры: " + Game.ModeToString());
		}
	}
}
