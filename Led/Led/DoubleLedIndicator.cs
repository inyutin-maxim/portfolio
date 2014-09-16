using System.Windows.Forms;

namespace Led {
	/// <summary>
	/// Сдвоенный индикатор
	/// </summary>
	public partial class DoubleLedIndicator : UserControl {
		/// <summary>
		/// Конструктор
		/// </summary>
		public DoubleLedIndicator() {
			InitializeComponent();
		}
		/// <summary>
		/// Максимальное значение индикатора
		/// </summary>
		public const int MaxValue = 99;
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
			if (inputValue > MaxValue) {
				tensLed.SetValue(9);
				unitsLed.SetValue(9);
			} else {
				tensLed.SetValue(inputValue / 10);
				unitsLed.SetValue(inputValue % 10);
			}
		}
		/// <summary>
		/// Сбросить Индикатор
		/// </summary>
		public void Reset() {
			tensLed.Reset();
			unitsLed.Reset();
		}
	}
}
