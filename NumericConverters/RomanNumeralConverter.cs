using System.Text;

namespace NumericConverters
{
    public static class RomanNumeralConverter
    {
        /// <summary>
        /// Метод, который принимает арабское число и возвращает его представление в виде римского числа.
        /// </summary>
        /// <param name="arabicNumeral">Арабское число, которое нужно преобразовать в римское число.</param>
        /// <returns>Римское число, представляющее переданное арабское число.</returns>
        public static string ArabicToRoman(int arabicNumeral)
        {
            if (arabicNumeral < 1 || arabicNumeral > 3999)
            {
                throw new ArgumentException("The input must be between 1 and 3999.");
            }

            // Создаем массив, содержащий римские цифры и их арабские эквиваленты.
            string[] romanNumerals = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] arabicEquivalents = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            StringBuilder result = new StringBuilder();

            // Проходим по всем римским цифрам в массиве.
            for (int i = 0; i < romanNumerals.Length; i++)
            {
                // Пока переданное арабское число больше или равно текущему арабскому эквиваленту римской цифры.
                while (arabicNumeral >= arabicEquivalents[i])
                {
                    // Добавляем текущую римскую цифру к результату.
                    result.Append(romanNumerals[i]);

                    // Вычитаем из переданного арабского числа текущий арабский эквивалент римской цифры.
                    arabicNumeral -= arabicEquivalents[i];
                }
            }

            // Возвращаем результат в виде строки.
            return result.ToString();
        }

        /// <summary>
        /// Конвертирует римское число в арабское число.
        /// </summary>
        /// <param name="romanNumeral">Римское число.</param>
        /// <returns>Арабское число.</returns>
        public static int RomanToArabic(string romanNumeral)
        {
            // Создаем словарь для хранения значений римских цифр
            Dictionary<char, int> romanToArabic = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int arabicNumeral = 0;
            int lastValue = 0;

            // Итерируемся по символам римской цифры в обратном порядке
            for (int i = romanNumeral.Length - 1; i >= 0; i--)
            {
                int currentValue = romanToArabic[romanNumeral[i]];

                // Если значение левого символа меньше значения текущего символа, вычитаем значение левого символа
                if (currentValue < lastValue)
                {
                    arabicNumeral -= currentValue;
                }
                // Иначе, прибавляем значение текущего символа
                else
                {
                    arabicNumeral += currentValue;
                }

                lastValue = currentValue;
            }

            return arabicNumeral;
        }



    }
}

