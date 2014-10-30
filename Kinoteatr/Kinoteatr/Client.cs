using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Kinoteatr {
	public partial class Client : Form {
		public Client() {
			InitializeComponent();
		}
		/// <summary>
		/// Список мест
		/// </summary>
		private readonly List<Button> _placeList = new List<Button>();
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
			return btn;
		}
		/// <summary>
		/// Получить индекс цвета
		/// <remarks>0,1,2,3 - Индексы для цвета кнопки</remarks>
		/// </summary>
		/// <returns>Индекс для цвета кнопки</returns>
		private static int GetColorIndex( int ind ) {
			if ( SeansInfo.Seans.Places[ ind ].IsOccupied ) {
				return 4;
			}
			if ( ind >= 60 ) {
				return 3;
			}
			if ( ind >= 40 ) {
				return 2;
			}
			return ind >= 20 ? 1 : 0;
		}
		private void Client_Load( object sender, EventArgs e ) {
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
			groupBox1.Text = string.Format( "Сеанс - {0}. Начало сеанса: {1}", SeansInfo.Film, SeansInfo.Time );
		}
	}
}
