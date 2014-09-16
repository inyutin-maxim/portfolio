
namespace Led {
	/// <summary>
	/// Константы
	/// </summary>
	public static class Constants {
		/// <summary>
		/// Цифра один
		/// </summary>
		/// <remarks>{5,7}</remarks>
		public static readonly Led7 One = new Led7 {
			// 1
			Top = false,
			// 2
			Center = false,
			// 3
			Bottom = false,
			// 4
			LeftTop = false,
			// 5
			RightTop = true,
			// 6
			LeftBottom = false,
			// 7
			RightBottom = true
		};
		/// <summary>
		/// Цифра два
		/// </summary>
		/// <remarks>{1,2,3,5,6}</remarks>
		public static readonly Led7 Two = new Led7 {
			// 1
			Top = true,
			// 2
			Center = true,
			// 3
			Bottom = true,
			// 4
			LeftTop = false,
			// 5
			RightTop = true,
			// 6
			LeftBottom = true,
			// 7
			RightBottom = false
		};
		/// <summary>
		/// Цифра три
		/// </summary>
		/// <remarks>{1,2,3,5,7}</remarks>
		public static readonly Led7 Three = new Led7 {
			// 1
			Top = true,
			// 2
			Center = true,
			// 3
			Bottom = true,
			// 4
			LeftTop = false,
			// 5
			RightTop = true,
			// 6
			LeftBottom = false,
			// 7
			RightBottom = true
		};
		/// <summary>
		/// Цифра четыре
		/// </summary>
		/// <remarks>{2,4,5,7}</remarks>
		public static readonly Led7 Four = new Led7 {
			// 1
			Top = false,
			// 2
			Center = true,
			// 3
			Bottom = false,
			// 4
			LeftTop = true,
			// 5
			RightTop = true,
			// 6
			LeftBottom = false,
			// 7
			RightBottom = true
		};
		/// <summary>
		/// Цифра пять
		/// </summary>
		/// <remarks>{1,2,3,4,7}</remarks>
		public static readonly Led7 Five = new Led7 {
			// 1
			Top = true,
			// 2
			Center = true,
			// 3
			Bottom = true,
			// 4
			LeftTop = true,
			// 5
			RightTop = false,
			// 6
			LeftBottom = false,
			// 7
			RightBottom = true
		};
		/// <summary>
		/// Цифра шесть
		/// </summary>
		/// <remarks>{1,2,3,4,6,7}</remarks>
		public static readonly Led7 Six = new Led7 {
			// 1
			Top = true,
			// 2
			Center = true,
			// 3
			Bottom = true,
			// 4
			LeftTop = true,
			// 5
			RightTop = false,
			// 6
			LeftBottom = true,
			// 7
			RightBottom = true
		};
		/// <summary>
		/// Цифра семь
		/// </summary>
		/// <remarks>{1,5,7}</remarks>
		public static readonly Led7 Seven = new Led7 {
			// 1
			Top = true,
			// 2
			Center = false,
			// 3
			Bottom = false,
			// 4
			LeftTop = false,
			// 5
			RightTop = true,
			// 6
			LeftBottom = false,
			// 7
			RightBottom = true
		};
		/// <summary>
		/// Цифра восемь
		/// </summary>
		/// <remarks>{1,2,3,4,5,6,7}</remarks>
		public static readonly Led7 Eight = new Led7 {
			// 1
			Top = true,
			// 2
			Center = true,
			// 3
			Bottom = true,
			// 4
			LeftTop = true,
			// 5
			RightTop = true,
			// 6
			LeftBottom = true,
			// 7
			RightBottom = true
		};
		/// <summary>
		/// Цифра девять
		/// </summary>
		/// <remarks>{1,2,3,4,5,7}</remarks>
		public static readonly Led7 Nine = new Led7 {
			// 1
			Top = true,
			// 2
			Center = true,
			// 3
			Bottom = true,
			// 4
			LeftTop = true,
			// 5
			RightTop = true,
			// 6
			LeftBottom = false,
			// 7
			RightBottom = true
		};
		/// <summary>
		/// Цифра ноль
		/// </summary>
		/// <remarks>{1,3,4,5,6,7}</remarks>
		public static readonly Led7 Zero = new Led7 {
			// 1
			Top = true,
			// 2
			Center = false,
			// 3
			Bottom = true,
			// 4
			LeftTop = true,
			// 5
			RightTop = true,
			// 6
			LeftBottom = true,
			// 7
			RightBottom = true
		};
		/// <summary>
		/// Выключенное состояние
		/// </summary>
		public static readonly Led7 Off = new Led7 {
			// 1
			Top = false,
			// 2
			Center = false,
			// 3
			Bottom = false,
			// 4
			LeftTop = false,
			// 5
			RightTop = false,
			// 6
			LeftBottom = false,
			// 7
			RightBottom = false
		};
	}
}
