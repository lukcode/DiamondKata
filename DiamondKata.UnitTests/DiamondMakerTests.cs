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
}