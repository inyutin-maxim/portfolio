using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Kinoteatr.Properties;

namespace Kinoteatr {
	public partial class Main : Form {
		public Main() {
			InitializeComponent();
		}
		#region Глобальные переменные
		/// <summary>
		/// Шрифт для печати
		/// </summary>
		private Font _printFont;
		/// <summary>
		/// Поток для печати
		/// </summary>
		private StreamReader _streamToPrint;

		/// <summary>
		/// Список сеансов
		/// </summary>
		public List<Seans> SeansList = new List<Seans>();
		/// <summary>
		/// Координаты Х для кнопок
		/// </summary>
		public int[] BtnX = { 10, 45, 80, 115, 150, 185, 220, 255, 290, 325 };
		/// <summary>
		/// Координаты Y для кнопок
		/// </summary>
		public int[] BtnY = { 20, 45, 70, 95, 120, 145, 170, 195 };
		/// <summary>
		/// Цветовое выделение стоимости места
		/// </summary>
		public Color[] BtnClr = { Color.Green, Color.Red, Color.Blue, Color.Brown, Color.LightGray };
		/// <summary>
		/// Индекс текущего сеанса
		/// </summary>
		public int SeansIndex {
			get;
			set;
		}
		/// <summary>
		/// Список мест
		/// </summary>
		public List<Button> PlaceList = new List<Button>();
		/// <summary>
		/// Место
		/// </summary>
		public Place TempPlace = new Place();
		#endregion
		/// <summary>
		/// Выручка за день
		/// </summary>
		/// <returns></returns>
		public double RevenueForDay(List<Seans> seans) {
			return seans.Sum( item => item.Revenue() );
		}

		/// <summary>
		/// Печать файла
		/// </summary>
		/// <param name="path">Путь к файлу</param>
		public void Printing(string path) {
			try {
				_streamToPrint = new StreamReader(path);
				try {
					_printFont = new Font("Arial", 10);
					PrintDocument pd = new PrintDocument();
					pd.PrintPage += pd_PrintPage;
					// Печать документа.
					pd.Print();
				} finally {
					_streamToPrint.Close();
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}
		/// <summary>
		///  Событие генерируемое для каждой распечатанной страницы
		/// </summary>
		private void pd_PrintPage(object sender, PrintPageEventArgs ev) {
			float linesPerPage = 0;
			float yPos = 0;
			int count = 0;
			float leftMargin = ev.MarginBounds.Left;
			float topMargin = ev.MarginBounds.Top;
			String line = null;

			// Вычислить число строк на страницу.
			linesPerPage = ev.MarginBounds.Height /
			   _printFont.GetHeight(ev.Graphics);

			while (count < linesPerPage &&
			   ((line = _streamToPrint.ReadLine()) != null)) {
				yPos = topMargin + (count * _printFont.GetHeight(ev.Graphics));
				ev.Graphics.DrawString(line, _printFont, Brushes.Black,
				   leftMargin, yPos, new StringFormat());
				count++;
			}

			// Нужно ли печатать дополнительную страницу
			if (line != null) {
				ev.HasMorePages = true;
			} else {
				ev.HasMorePages = false;
			}
		}

		/// <summary>
		/// Загрузка данных в XML документ
		/// </summary>
		/// <param name="path">Путь к XML документу</param>
		public void LinqWriteXml(string path) {

			if (File.Exists(path)) {
				File.Delete(path);
			}

			XElement element = new XElement("head");
			foreach (var item in SeansList) {
				XElement subElement = new XElement(item.Film.Replace(" ", "_"));
				foreach (var place in item.Places) {
					subElement.Add(
						new XElement("Place",
							new XElement("Cost", place.Cost),
							new XElement("Occupied", place.IsOccupied)
						)
					);
				}
				element.Add(subElement);
			}
			XDocument xDoc = new XDocument(element);
			xDoc.Save(path);
		}
		/// <summary>
		/// Прочитать XML документ
		/// </summary>
		/// <param name="path">Путь к XML документу</param>
		public void LinqReadXml(string path) {
			if (!File.Exists(path)) {
				return;
			}
			XDocument doc = XDocument.Load(path);
			string filmName = "";
			foreach (XElement film in doc.Root.Elements()) {
				List<Place> tempPlaces = new List<Place>();
				foreach (XElement place in film.Elements()) {
					foreach (XElement item in place.Elements()) {
						double tempCost = 0;
						bool tempisOccupied = false;
						switch (item.Name.LocalName) {
							case "Cost": {
								double.TryParse(item.Value, out tempCost);
								TempPlace.Cost = tempCost;
							}
							break;
							case "Occupied": {
								bool.TryParse(item.Value, out tempisOccupied);
								TempPlace.IsOccupied = tempisOccupied;
							}
							break;
						}
					}
					tempPlaces.Add(
						new Place {
							Cost = TempPlace.Cost,
							IsOccupied = TempPlace.IsOccupied
						}
					);
				}
				filmName = film.Name.LocalName;
				SeansList.Add(
					new Seans {
						Film = filmName,
						Places = tempPlaces
					}
				);
			}
		}
		/// <summary>
		/// При загрузке главной формы
		/// </summary>
		private void Main_Load(object sender, EventArgs e) {
			LinqReadXml("data.xml");
			// Заполняем список сеансов на форму
			foreach (var seans in SeansList) {
				lbSeansList.Items.Add(seans.Film);
			}
			int index = 0;
			// Заполнить список мест
			for (int i = BtnY.Length - 1; i > 0; i--) {
				foreach ( int t in BtnX ) {
					PlaceList.Add(AddBtn(t, BtnY[i], index, BtnClr[GetColorIndex(index)]));
					index++;
				}
			}
			for (int i = 3; i < 8; i++) {
				PlaceList.Add(AddBtn(BtnX[i], BtnY[0], index, BtnClr[GetColorIndex(index)]));
				index++;
			}
		}
		/// <summary>
		/// Заполнить места в зрительном зале
		/// </summary>
		/// <returns></returns>
		public List<Place> FillPlaces() {
			List<Place> temp = new List<Place>();
			// Заполняем места
			for (int i = 0; i < 75; i++) {
				temp.Add(
					new Place {
						Cost = (GetColorIndex(i) + 1) * 100,
						IsOccupied = false
					}
				);
			}
			return temp;
		}

		/// <summary>
		/// Добавить кнопку
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="index"></param>
		/// <param name="clr">Цвет</param>
		public Button AddBtn(int x, int y, int index, Color clr) {
			Button btn = new Button {
				Name = "Btn" + index,
				Text = ( index + 1 ) + "",
				Tag = index,
				BackColor = clr,
				Location = new Point( x, y ),
				Size = new Size( 30, 20 )
			};
			groupBox1.Controls.Add(btn);
			// Добавляем события 
			btn.Click += Btn_Click;
			return btn;
		}
		/// <summary>
		/// По нажатии на кнопку
		/// </summary>
		private void Btn_Click(object sender, EventArgs e) {
			Button btn = sender as Button;
			if ( btn == null ) {
				return;
			}
			int index = (int)btn.Tag;
			if (SeansIndex >= 0) {
				bool isOccupied = SeansList[SeansIndex].Places[index].IsOccupied;
				if (isOccupied) {
					var response = MessageBox.Show("Вы уверены что хотите снять бронь с этого места?", "Информация", MessageBoxButtons.YesNo);
					if (response == DialogResult.No) {
						return;
					}
				}
				SeansList[SeansIndex].Places[index].IsOccupied = !isOccupied;

				if (SeansList[SeansIndex].Places[index].IsOccupied) {
					btn.Text = string.Empty;
					btn.BackColor = Color.LightGray;

				} else {
					btn.Text = (index + 1) + "";
					btn.BackColor = BtnClr[GetColorIndex(index)];
				}
			} else {
				MessageBox.Show(Resources.PleaseSelectSeance);
			}
		}
		/// <summary>
		/// Получить индекс цвета
		/// <remarks>0,1,2,3 - Индексы для цвета кнопки</remarks>
		/// </summary>
		/// <returns>Индекс для цвета кнопки</returns>
		private static int GetColorIndex(int ind) {
			if (ind >= 60) {
				return 3;
			}
			if (ind >= 40) {
				return 2;
			}
			return ind >= 20 ? 1 : 0;
		}

		/// <summary>
		/// При выборе сеанса
		/// </summary>
		private void lbSeansList_SelectedIndexChanged(object sender, EventArgs e) {
			SeansIndex = lbSeansList.SelectedIndex;
			if ( SeansList.Count <= 0 ) {
				return;
			}
			for (int i = 0; i < 75; i++) {
				if (SeansList[SeansIndex].Places[i].IsOccupied) {
					PlaceList[i].BackColor = Color.LightGray;
					PlaceList[i].Text = "";
				} else {
					PlaceList[i].BackColor = BtnClr[GetColorIndex(i)];
					PlaceList[i].Text = (i + 1) + "";
				}
			}
		}

		private void ToolStripMenuItemSeans_Click(object sender, EventArgs e) {
			if (SeansIndex >= 0) {
				MessageBox.Show(string.Format("Прибыль за текущий сеанс составляет: {0} рублей", SeansList[SeansIndex].Revenue()));
			}
		}

		private void toolStripMenuItemFreePlaces_Click(object sender, EventArgs e) {
			if (SeansIndex >= 0 && SeansList[SeansIndex].EmptyPlaceExist()) {
				MessageBox.Show("На данный сеанс доступны свободные места.");
			} else {
				MessageBox.Show("Нет доступных свободных мест.");
			}
		}

		private void ToolStripMenuItemDay_Click(object sender, EventArgs e) {
			if (SeansIndex >= 0) {
				MessageBox.Show(string.Format("Прибыль за текущий рабочий день составляет: {0} рублей", RevenueForDay(SeansList)));
			}
		}

		private void btnSetTestData_Click(object sender, EventArgs e) {
			// Заполняем места
			for (var i = 0; i < 75; i++) {
				placeList.Add(
					new Place {
						Cost = (GetColorIndex(i) + 1) * 100,
						IsOccupied = false
					}
				);
			}
			SeansList.Clear();
			// Заполняем список сеансов по умолчанию
			for (int i = 0; i < 8; i++) {
				SeansList.Add(
					new Seans {
						Film = "Форсаж " + (i + 1),
						Places = FillPlaces()
					}
				);
			}
			lbSeansList.Items.Clear();
			// Заполняем список сеансов на форму
			foreach (var seans in SeansList) {
				lbSeansList.Items.Add(seans.Film);
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			LinqWriteXml("data.xml");
		}

		private void добавитьСеансToolStripMenuItem_Click(object sender, EventArgs e) {
			groupBox2.Visible = true;
			tbNewSeans.Focus();
		}

		private void btnAddSeans_Click(object sender, EventArgs e) {
			SeansList.Add(
				new Seans {
					Film = tbNewSeans.Text,
					Places = FillPlaces()
				}
			);
			lbSeansList.Items.Clear();
			// Заполняем список сеансов на форму
			foreach (var item in SeansList) {
				lbSeansList.Items.Add(item.Film);
			}
			groupBox2.Visible = false;
		}
	}
}
