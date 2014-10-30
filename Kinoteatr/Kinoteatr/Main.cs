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
		private readonly List<Seans> _seansList = new List<Seans>();
		/// <summary>
		/// Координаты Х для кнопок
		/// </summary>
		private readonly int[] _btnX = { 10, 45, 80, 115, 150, 185, 220, 255, 290, 325 };
		/// <summary>
		/// Координаты Y для кнопок
		/// </summary>
		private readonly int[] _btnY = { 20, 45, 70, 95, 120, 145, 170, 195 };
		/// <summary>
		/// Цветовое выделение стоимости места
		/// </summary>
		private readonly Color[] _btnClr = { Color.Green, Color.Red, Color.Blue, Color.Brown, Color.LightGray };
		/// <summary>
		/// Индекс текущего сеанса
		/// </summary>
		private int SeansIndex {
			get;
			set;
		}
		/// <summary>
		/// Список мест
		/// </summary>
		private readonly List<Button> _placeList = new List<Button>();
		/// <summary>
		/// Место
		/// </summary>
		private readonly Place _tempPlace = new Place();
		#endregion
		/// <summary>
		/// Выручка за день
		/// </summary>
		/// <returns></returns>
		private static double RevenueForDay( IEnumerable<Seans> seans ) {
			return seans.Sum( item => item.Revenue() );
		}

		/// <summary>
		/// Печать файла
		/// </summary>
		/// <param name="path">Путь к файлу</param>
		public void Printing( string path ) {
			try {
				_streamToPrint = new StreamReader( path );
				try {
					_printFont = new Font( "Arial", 10 );
					var pd = new PrintDocument();
					pd.PrintPage += pd_PrintPage;
					// Печать документа.
					pd.Print();
				} finally {
					_streamToPrint.Close();
				}
			} catch ( Exception ex ) {
				MessageBox.Show( ex.Message );
			}
		}
		/// <summary>
		///  Событие генерируемое для каждой распечатанной страницы
		/// </summary>
		private void pd_PrintPage( object sender, PrintPageEventArgs ev ) {
			var count = 0;
			float leftMargin = ev.MarginBounds.Left;
			float topMargin = ev.MarginBounds.Top;
			String line = null;

			// Вычислить число строк на страницу.
			var linesPerPage = ev.MarginBounds.Height /
								 _printFont.GetHeight( ev.Graphics );

			while ( count < linesPerPage &&
			   ( ( line = _streamToPrint.ReadLine() ) != null ) ) {
				var yPos = topMargin + ( count * _printFont.GetHeight( ev.Graphics ) );
				ev.Graphics.DrawString( line, _printFont, Brushes.Black,
				   leftMargin, yPos, new StringFormat() );
				count++;
			}

			// Нужно ли печатать дополнительную страницу
			ev.HasMorePages = line != null;
		}

		/// <summary>
		/// Загрузка данных в XML документ
		/// </summary>
		/// <param name="path">Путь к XML документу</param>
		private void LinqWriteXml( string path ) {

			if ( File.Exists( path ) ) {
				File.Delete( path );
			}

			var element = new XElement( "head" );
			foreach ( var item in _seansList ) {
				var subElement = new XElement( item.Film.Replace( " ", "_" ) );
				subElement.SetAttributeValue("time", item.Time);
				foreach ( var place in item.Places ) {
					subElement.Add(
						new XElement( "Place",
							new XElement( "Cost", place.Cost ),
							new XElement( "Occupied", place.IsOccupied )
						)
					);
				}
				element.Add( subElement );
			}
			var xDoc = new XDocument( element );
			xDoc.Save( path );
		}
		/// <summary>
		/// Прочитать XML документ
		/// </summary>
		/// <param name="path">Путь к XML документу</param>
		private void LinqReadXml( string path ) {
			if ( !File.Exists( path ) ) {
				return;
			}
			var doc = XDocument.Load( path );
			if ( doc.Root == null ) {
				return;
			}
			foreach ( var film in doc.Root.Elements() ) {
				var tempPlaces = new List<Place>();
				foreach ( var place in film.Elements() ) {
					foreach ( var item in place.Elements() ) {
						switch ( item.Name.LocalName ) {
							case "Cost": {
								double tempCost;
								double.TryParse( item.Value, out tempCost );
								_tempPlace.Cost = tempCost;
							}
							break;
							case "Occupied": {
								bool tempisOccupied;
								bool.TryParse( item.Value, out tempisOccupied );
								_tempPlace.IsOccupied = tempisOccupied;
							}
							break;
						}
					}
					tempPlaces.Add(
						new Place {
							Cost = _tempPlace.Cost,
							IsOccupied = _tempPlace.IsOccupied
						}
						);
				}
				var filmName = film.Name.LocalName;
				DateTime time;
				DateTime.TryParse( film.Attribute( "time" ).Value, out time );
				_seansList.Add(
					new Seans {
						Film = filmName,
						Places = tempPlaces,
						Time = time
					}
					);
			}
		}
		/// <summary>
		/// При загрузке главной формы
		/// </summary>
		private void Main_Load( object sender, EventArgs e ) {
			LinqReadXml( "data.xml" );
			// Заполняем список сеансов на форму
			foreach ( var seans in _seansList ) {
				lbSeansList.Items.Add( seans.Film );
			}
			var index = 0;
			// Заполнить список мест
			for ( var i = _btnY.Length - 1; i > 0; i-- ) {
				foreach ( var t in _btnX ) {
					_placeList.Add( AddBtn( t, _btnY[ i ], index, _btnClr[ GetColorIndex( index ) ] ) );
					index++;
				}
			}
			for ( var i = 3; i < 8; i++ ) {
				_placeList.Add( AddBtn( _btnX[ i ], _btnY[ 0 ], index, _btnClr[ GetColorIndex( index ) ] ) );
				index++;
			}
			btnShowClientForm.Visible = _seansList.Count > 0;
			btnSetTestData.Visible = !btnShowClientForm.Visible;
			if ( _seansList.Count > 0 ) {
				SeansInfo.Seans = _seansList[ 0 ];
				lbSeansList.SelectedIndex = 0;
			}
		}
		/// <summary>
		/// Заполнить места в зрительном зале
		/// </summary>
		/// <returns></returns>
		private static List<Place> FillPlaces() {
			var temp = new List<Place>();
			// Заполняем места
			for ( var i = 0; i < 75; i++ ) {
				temp.Add(
					new Place {
						Cost = ( GetColorIndex( i ) + 1 ) * 100,
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
		private Button AddBtn( int x, int y, int index, Color clr ) {
			var btn = new Button {
				Name = "Btn" + index,
				Text = ( index + 1 ) + "",
				Tag = index,
				BackColor = clr,
				Location = new Point( x, y ),
				Size = new Size( 30, 20 )
			};
			groupBox1.Controls.Add( btn );
			// Добавляем события 
			btn.Click += Btn_Click;
			return btn;
		}
		/// <summary>
		/// По нажатии на кнопку
		/// </summary>
		private void Btn_Click( object sender, EventArgs e ) {
			var btn = sender as Button;
			if ( btn == null ) {
				return;
			}
			var index = ( int )btn.Tag;
			if ( SeansIndex >= 0 ) {
				var isOccupied = _seansList[ SeansIndex ].Places[ index ].IsOccupied;
				if ( isOccupied ) {
					var response = MessageBox.Show( Resources.uncheck, Resources.info, MessageBoxButtons.YesNo );
					if ( response == DialogResult.No ) {
						return;
					}
				}
				_seansList[ SeansIndex ].Places[ index ].IsOccupied = !isOccupied;

				if ( _seansList[ SeansIndex ].Places[ index ].IsOccupied ) {
					btn.Text = string.Empty;
					btn.BackColor = Color.LightGray;

				} else {
					btn.Text = ( index + 1 ) + "";
					btn.BackColor = _btnClr[ GetColorIndex( index ) ];
				}
			} else {
				MessageBox.Show( Resources.PleaseSelectSeance );
			}
		}
		/// <summary>
		/// Получить индекс цвета
		/// <remarks>0,1,2,3 - Индексы для цвета кнопки</remarks>
		/// </summary>
		/// <returns>Индекс для цвета кнопки</returns>
		private static int GetColorIndex( int ind ) {
			if ( ind >= 60 ) {
				return 3;
			}
			if ( ind >= 40 ) {
				return 2;
			}
			return ind >= 20 ? 1 : 0;
		}

		/// <summary>
		/// При выборе сеанса
		/// </summary>
		private void lbSeansList_SelectedIndexChanged( object sender, EventArgs e ) {
			SeansIndex = lbSeansList.SelectedIndex;
			if ( _seansList.Count <= 0 ) {
				return;
			}
			SeansInfo.Seans = _seansList[ SeansIndex ];
			for ( var i = 0; i < 75; i++ ) {
				if ( SeansInfo.Seans.Places[ i ].IsOccupied ) {
					_placeList[ i ].BackColor = Color.LightGray;
					_placeList[ i ].Text = "";
				} else {
					_placeList[ i ].BackColor = _btnClr[ GetColorIndex( i ) ];
					_placeList[ i ].Text = ( i + 1 ) + "";
				}
			}
			groupBox1.Text = string.Format( "Сеанс - {0}. Начало сеанса: {1}", SeansInfo.Film, SeansInfo.Time );
		}
		/// <summary>
		/// Пункт меню "Прибыль за текущий сеанс"
		/// </summary>
		private void ToolStripMenuItemSeans_Click( object sender, EventArgs e ) {
			if ( SeansIndex >= 0 ) {
				MessageBox.Show( string.Format( "Прибыль за текущий сеанс составляет: {0} рублей", _seansList[ SeansIndex ].Revenue() ) );
			}
		}
		/// <summary>
		/// Пункт меню "Проверить наличие свободных мест"
		/// </summary>
		private void toolStripMenuItemFreePlaces_Click( object sender, EventArgs e ) {
			if ( SeansIndex >= 0 && _seansList[ SeansIndex ].EmptyPlaceExist() ) {
				MessageBox.Show( Resources.freePlaces );
			} else {
				MessageBox.Show( Resources.nonFreePlaces );
			}
		}
		/// <summary>
		/// Прибыль за день
		/// </summary>
		private void ToolStripMenuItemDay_Click( object sender, EventArgs e ) {
			if ( SeansIndex >= 0 ) {
				MessageBox.Show( string.Format( "Прибыль за текущий рабочий день составляет: {0} рублей", RevenueForDay( _seansList ) ) );
			}
		}
		/// <summary>
		/// Установить тестовые данные
		/// </summary>
		private void btnSetTestData_Click( object sender, EventArgs e ) {
			// Заполняем места
			for ( var i = 0; i < 75; i++ ) {
				placeList.Add(
					new Place {
						Cost = ( GetColorIndex( i ) + 1 ) * 100,
						IsOccupied = false
					}
				);
			}
			_seansList.Clear();
			// Заполняем список сеансов по умолчанию
			for ( var i = 0; i < 8; i++ ) {
				_seansList.Add(
					new Seans {
						Film = "Форсаж " + ( i + 1 ),
						Places = FillPlaces(),
						Time = DateTime.Today.AddHours( 9 + i * 2 )
					}
				);
			}
			lbSeansList.Items.Clear();
			// Заполняем список сеансов на форму
			foreach ( var seans in _seansList ) {
				lbSeansList.Items.Add( seans.Film );
			}
			btnShowClientForm.Visible = _seansList.Count > 0;
			btnSetTestData.Visible = !btnShowClientForm.Visible;
			if ( _seansList.Count > 0 ) {
				SeansInfo.Seans = _seansList[ 0 ];
				lbSeansList.SelectedIndex = 0;
			}
		}
		/// <summary>
		/// перед закрытием формы
		/// </summary>
		private void Form1_FormClosing( object sender, FormClosingEventArgs e ) {
			LinqWriteXml( "data.xml" );
		}
		/// <summary>
		/// Пункт меню "Добавить сеанс"
		/// </summary>
		private void добавитьСеансToolStripMenuItem_Click( object sender, EventArgs e ) {
			groupBox2.Visible = true;
			tbNewSeans.Focus();
		}
		/// <summary>
		/// Добавить сеанс
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnAddSeans_Click( object sender, EventArgs e ) {
			_seansList.Add(
				new Seans {
					Film = tbNewSeans.Text,
					Places = FillPlaces()
				}
			);
			lbSeansList.Items.Clear();
			// Заполняем список сеансов на форму
			foreach ( var item in _seansList ) {
				lbSeansList.Items.Add( item.Film );
			}
			groupBox2.Visible = false;
		}

		private void btnShowClientForm_Click( object sender, EventArgs e ) {
			var client = new Client();
			client.ShowDialog();
		}
	}
}
