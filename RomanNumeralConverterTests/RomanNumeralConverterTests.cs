using NumericConverters;
using Xunit;

namespace RomanNumeralConverterTests;

public class RomanNumeralConverterTests
{
    [Fact]
    public void ArabicToRoman_ShouldReturnI_WhenPassed1()
    {
        // Arrange
        int input = 1;
        string expectedOutput = "I";
        // Act
        string result = RomanNumeralConverter.ArabicToRoman(input);

        // Assert
        Assert.Equal(expectedOutput, result);
    }

    [Fact]
    public void ArabicToRoman_ShouldReturnMMXXI_WhenPassed2021()
    {
        // Arrange
        int input = 2021;
        string expectedOutput = "MMXXI";

        // Act
        string result = RomanNumeralConverter.ArabicToRoman(input);

        // Assert
        Assert.Equal(expectedOutput, result);
    }

    [Fact]
    public void RomanToArabic_ShouldReturn1_WhenPassedI()
    {
        // Arrange
        string input = "I";
        int expectedOutput = 1;

        // Act
        int result = RomanNumeralConverter.RomanToArabic(input);

        // Assert
        Assert.Equal(expectedOutput, result);
    }

    [Fact]
    public void RomanToArabic_ShouldReturn2021_WhenPassedMMXXI()
    {
        // Arrange
        string input = "MMXXI";
        int expectedOutput = 2021;

        // Act
        int result = RomanNumeralConverter.RomanToArabic(input);

        // Assert
        Assert.Equal(expectedOutput, result);
    }

    [Fact]
    public void RomanToArabic_ReturnsZero_ForEmptyString()
    {
        var result = RomanNumeralConverter.RomanToArabic("");
        Assert.Equal(0, result);
    }

    [Fact]
    public void RomanToArabic_ReturnsCorrectArabicNumeral_ForValidRomanNumeral()
    {
        var result = RomanNumeralConverter.RomanToArabic("MCMXCIV");
        Assert.Equal(1994, result);
    }

    [Fact]
    public void ArabicToRoman_ReturnsCorrectRomanNumeral_ForValidArabicNumeral()
    {
        var result = RomanNumeralConverter.ArabicToRoman(1994);
        Assert.Equal("MCMXCIV", result);
    }

    [Fact]
    public void ArabicToRoman_ReturnsCorrectRomanNumeral_ForMinimalValidArabicNumeral()
    {
        var result = RomanNumeralConverter.ArabicToRoman(1);
        Assert.Equal("I", result);
    }

    [Fact]
    public void ArabicToRoman_ReturnsCorrectRomanNumeral_ForMaximumValidArabicNumeral()
    {
        var result = RomanNumeralConverter.ArabicToRoman(3999);
        Assert.Equal("MMMCMXCIX", result);
    }
}
