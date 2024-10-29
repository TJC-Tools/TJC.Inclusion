namespace TJC.Inclusion.Tests.Operators;

internal class NotOperatorTests
{
    [TestMethod]
    public void NotOperator_InternalTrue_ReturnsFalse()
    {
        // Arrange
        var included = new Inclusion(true);

        // Assert
        Assert.IsFalse(!included);
    }

    [TestMethod]
    public void NotOperator_InternalFalse_ReturnsTrue()
    {
        // Arrange
        var excluded = new Inclusion(false);

        // Assert
        Assert.IsTrue(!excluded);
    }
}
