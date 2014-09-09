namespace Rome2Arab {
	/// <summary>
	///     Класс для преобразования чисел
	/// </summary>
	public static class Converter {
		/// <summary>
		/// Римские цифры
		/// </summary>
		public static string[] RomeNumber = { "ↂ", "ↁ", "Ⅿ", "Ⅾ", "Ⅽ", "Ⅼ", "XL", "Ⅹ", "Ⅸ", "Ⅴ", "Ⅳ", "Ⅰ" };

		/// <summary>
		/// Арабские цифры
		/// </summary>
		public static int[] ArabNumber = { 10000, 5000, 1000, 500, 100, 50, 40, 10, 9, 5, 4, 1 };

		/// <summary>
		/// Римское в Арабское
		/// </summary>
		/// <param name="number">Число</param>
		/// <returns>Арабское число</returns>
		public static int Rome2Arab( string number ) {
			var result = 0; // результат
			var arab = 1; // арабское число
			// перебираем все римские цифры
			while ( number != "" ) {
				// Индекс текущей римской цифры
				for ( var i = 0; i < RomeNumber.Length; i++ ) {
					if ( RomeNumber[ i ] != number[ 0 ] + "" )
						continue;
					arab = i;
					break;
				}
				var temp = "";
				// Запись всех римских цифр кроме первой
				for ( var i = 1; i < number.Length; i++ ) {
					temp += number[ i ];
				}
				number = temp; // обновление входного значения
				// Добавить к результату переведенное арабское число
				result += ArabNumber[ arab ];
			}
			return result;
		}
		/// <summary>
		/// Арабское в римское
		/// </summary>
		/// <param name="arab">Арабское число</param>
		public static string ArabToRome( int arab ) {
			var result = ""; // Результат
			var index = 0; // Индекс
			while ( arab > 0 ) {
				while ( ArabNumber[ index ] <= arab ) {
					result += RomeNumber[ index ];
					arab -= ArabNumber[ index ];
				}
				index++;
			}
			return result;
		}
	}
}