using System.Windows.Forms;

namespace Led {
	/// <summary>
	/// Семисегментный индикатор
	/// </summary>
	public partial class LedIndicator : UserControl {
		public LedIndicator() {
			InitializeComponent();
		}
		
		/// <summary>
		/// Задать значение Индикатору
		/// </summary>
		/// <param name="value">Значения сегментов индикатора</param>
		private void SetValue(Led7 value) {
			pbTop.SetColor(value.Top);
			pbCenter.SetColor(value.Center);
			pbBottom.SetColor(value.Bottom);
			pbLeftTop.SetColor(value.LeftTop);
			pbRightTop.SetColor(value.RightTop);
			pbLeftBottom.SetColor(value.LeftBottom);
			pbRightBottom.SetColor(value.RightBottom);
		}
		/// <summary>
		/// Задать значение Индикатору
		/// </summary>
		/// <param name="inputValue">Входное значение</param>
		public void SetValue(string inputValue) {
			int val;
			int.TryParse(inputValue.Trim(), out val);
			SetValue(val);
		}
		/// <summary>
		/// Задать значение Индикатору
		/// </summary>
		/// <param name="inputValue">Входное значение</param>
		public void SetValue(int inputValue) {
			switch (inputValue) {
				case 0:
				SetValue(Constants.Zero);
				break;
				case 1:
				SetValue(Constants.One);
				break;
				case 2:
				SetValue(Constants.Two);
				break;
				case 3:
				SetValue(Constants.Three);
				break;
				case 4:
				SetValue(Constants.Four);
				break;
				case 5:
				SetValue(Constants.Five);
				break;
				case 6:
				SetValue(Constants.Six);
				break;
				case 7:
				SetValue(Constants.Seven);
				break;
				case 8:
				SetValue(Constants.Eight);
				break;
				case 9:
				SetValue(Constants.Nine);
				break;
			}
		}
		/// <summary>
		/// Сбросить Индикатор
		/// </summary>
		public void Reset() {
			SetValue(Constants.Off);
		}
	}
}
