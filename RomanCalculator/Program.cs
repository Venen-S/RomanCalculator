using NumericConverters;

int arabicNum = 3999;
string romanNum = RomanNumeralConverter.ArabicToRoman(arabicNum);
Console.WriteLine("{0} in roman numerals is {1}", arabicNum, romanNum);

romanNum = "MMMCMXCIX";
arabicNum = RomanNumeralConverter.RomanToArabic(romanNum);
Console.WriteLine("{0} in arabic numerals is {1}", romanNum, arabicNum);