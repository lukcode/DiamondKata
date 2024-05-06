using NUnit.Framework;

namespace DiamondKata.UnitTests;

[TestFixture]
public class DiamondMakerTests
{
    [Test]
    public void CreateDiamond_ValidInput_InputA_ReturnsDiamondPattern()
    {
        // Arrange
        var diamondMaker = new DiamondMaker();
        string[] input = ["A"];
        const string expectedDiamond = "A";

        // Act
        var actualDiamond = diamondMaker.CreateDiamond(input);

        // Assert
        Assert.That(actualDiamond, Is.EqualTo(expectedDiamond));
    }

    [Test]
    public void CreateDiamond_ValidInput_InputC_ReturnsDiamondPattern()
    {
        // Arrange
        var diamondMaker = new DiamondMaker();
        string[] input = ["C"];
        const string expectedDiamond = @"  A
 B B
C   C
 B B
  A";

        // Act
        var actualDiamond = diamondMaker.CreateDiamond(input);

        // Assert
        Assert.That(actualDiamond, Is.EqualTo(expectedDiamond));
    }

    [Test]
    public void CreateDiamond_ValidInput_InputD_ReturnsDiamondPattern()
    {
        // Arrange
        var diamondMaker = new DiamondMaker();
        string[] input = ["D"];
        const string expectedDiamond = @"   A
  B B
 C   C
D     D
 C   C
  B B
   A";

        // Act
        var actualDiamond = diamondMaker.CreateDiamond(input);

        // Assert
        Assert.That(actualDiamond, Is.EqualTo(expectedDiamond));
    }

    [TestCaseSource(nameof(InvalidInputTestCases))]
    public void CreateDiamond_InvalidInput_ThrowsArgumentException(string[] input)
    {
        // Arrange
        var expectedErrorMessage = "Invalid input. Please provide one uppercase character from A to Z.";
        var diamondMaker = new DiamondMaker();

        // Act & Assert
        var exception = Assert.Throws<ArgumentException>(() => diamondMaker.CreateDiamond(input));
        Assert.That(exception?.Message, Is.EqualTo(expectedErrorMessage));
    }

    private static IEnumerable<string[]> InvalidInputTestCases()
    {
        yield return ["a"]; // Lowercase letter
        yield return ["0"]; // Digit
        yield return ["_"]; // Special character
        yield return [" "]; // Empty string
        yield return ["AB"]; // More than one character
        yield return ["z"]; // Valid character (but still throws because it's lowercase)
        yield return ["A","D"]; // More than 1 argument
    }
}