using System.Windows.Forms;

namespace Rome2Arab {
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
		/// Перевести
		/// </summary>
		private void btnConvert_Click( object sender, System.EventArgs e ) {
			if ( cmbSystem.SelectedIndex == 0 ) {
				rtbResult.Text = cmbSystem.Items[cmbSystem.SelectedIndex] + @": " + Converter.Rome2Arab( tbInput.Text );
			} else {
				int value;
				int.TryParse(tbInput.Text, out value );
				rtbResult.Text = cmbSystem.Items[ cmbSystem.SelectedIndex ] + @": " + Converter.ArabToRome( value );
			}
		}
		/// <summary>
		/// Вставить римскую цифру
		/// </summary>
		private void toolStripButton1_Click( object sender, System.EventArgs e ) {
			var tsb = sender as ToolStripButton;
			if ( tsb == null ) {
				return;
			}
			tbInput.AppendText( tsb.Text );
		}
		/// <summary>
		/// При выборе из выпадающего списка
		/// </summary>
		private void cmbSystem_SelectedIndexChanged( object sender, System.EventArgs e ) {
			RomeNumbersPanel.Visible = cmbSystem.SelectedIndex == 0;
		}
	}
}
