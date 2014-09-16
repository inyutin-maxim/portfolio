using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace _2048 {
	/// <summary>
	/// Статистика игры
	/// </summary>
	public static class Statistic {
		/// <summary>
		/// Количество очков
		/// </summary>
		public static int Points;
		/// <summary>
		/// Рекорд
		/// </summary>
		public static int Highscore;
		/// <summary>
		/// Времени в игре (в секундах)
		/// </summary>
		public static int GameTime;
		/// <summary>
		/// Инициализация статистики
		/// </summary>
		public static void Initialization() {
			if (Import()) {
				MessageBox.Show("it work!");
				return;
			} else {
				GameTime = 0;
				Highscore = 0;
				Points = 0;
				Export();
				Import();
			}
		}
		/// <summary>
		/// Выгрузка данных
		/// </summary>
		public static void Export() {
			XmlSerializer serializer = new XmlSerializer(typeof(StatisticFields));
			Stream writer = new FileStream(Global.StatisticFileName, FileMode.Create);
			StatisticFields Fields = new StatisticFields();
			Fields.Points = Points;
			Fields.Highscore = Highscore;
			Fields.GameTime = GameTime;
			serializer.Serialize(writer, Fields);
			writer.Close();
		}
		/// <summary>
		/// Загрузка данных из файла
		/// </summary>
		/// <returns></returns>
		private static bool Import() {
			if (File.Exists(Global.StatisticFileName)) {
				XmlSerializer xml = new XmlSerializer(typeof(StatisticFields));
				dynamic Fields;
				using (FileStream fs = new FileStream(Global.StatisticFileName, FileMode.Open)) {
					Fields = (StatisticFields)xml.Deserialize(fs);
				}
				GameTime = Fields.GameTime;
				Highscore = Fields.Highscore;
				Points = Fields.Points;
			} else {
				return false;
			}
			return true;
		}
	}
	[XmlRoot("statistic")]
	public class StatisticFields {
		[XmlElement("points")]
		public int Points;
		/// <summary>
		/// Рекорд
		/// </summary>
		[XmlElement("highscore")]
		public int Highscore;
		/// <summary>
		/// Времени в игре (в секундах)
		/// </summary>
		[XmlElement("gametime")]
		public int GameTime;
	}
}
