using System;
using System.Windows.Forms;

namespace Perestanovki {
	public partial class Main : Form {
		public Main() {
			InitializeComponent();
		}
		/// <summary>
		/// Факториал числа
		/// </summary>
		/// <param name="stringLength"></param>
		/// <returns></returns>
		private int Factorial(int stringLength) {
			int result = 1;
			for (int number = 1; number <= stringLength; number++) {
				result *= number;
			}
			return result;
		}
		private void Shift(string input) {
			int[] charIndexs = new int[input.Length];
			char[] chars = new char[input.Length];
			// Заполнение массива MAS числами от 1 до input.Length
			for (int i = 0; i < input.Length; i++) {
				charIndexs[i] = i;
				chars[i] = input[i];
			}
			// Выполняем перестановки
			for (int z = 0; z < Factorial(input.Length); z++) {
				//вывод перестановки
				for (int i = 0; i < input.Length; i++) {
					richTextBox1.AppendText(chars[charIndexs[i]] + "");
				}
				richTextBox1.AppendText("\n");

				int index = input.Length - 2;
				int j = input.Length - 1;
				while (charIndexs[index] > charIndexs[index + 1]) {
					index--;
					if (index == 0)
						break;
				}
				while (charIndexs[index] > charIndexs[j]) {
					j--;
				}
				// перестановка
				int y = charIndexs[index];
				charIndexs[index] = charIndexs[j];
				charIndexs[j] = y;
				index++;
				j = input.Length - 1;
				while (index < j) {
					y = charIndexs[index];
					charIndexs[index] = charIndexs[j];
					charIndexs[j] = y;
					index++;
					j--;
				}
			}
		}
		private void Generate_Click(object sender, EventArgs e) {
			richTextBox1.Clear();
			richTextBox1.AppendText("Количество перестановок: " + Factorial(textBox1.TextLength) + " раз. \n");
			richTextBox1.AppendText("========================================\n");
			Shift(textBox1.Text);
		}
	}
}
