namespace TJC.Inclusion.Tests.Operators;

public class NotOperatorTests
{
    [Fact]
    public void NotOperator_InternalTrue_ReturnsFalse()
    {
        // Arrange
        var included = new Inclusion(true);

        // Assert
        Assert.True(included);
    }

    [Fact]
    public void NotOperator_InternalFalse_ReturnsTrue()
    {
        // Arrange
        var excluded = new Inclusion(false);

        // Assert
        Assert.False(excluded);
    }
}
