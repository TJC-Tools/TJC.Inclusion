namespace TJC.Inclusion.Tests.Constructor;


public class InclusionConstructorTests
{
    [Fact]
    public void ConstructTrue_InternalTrue()
    {
        // Arrange
        var inclusion = new Inclusion(true);

        // Assert
        Assert.True(inclusion._included);
    }

    [Fact]
    public void ConstructFalse_InternalFalse()
    {
        // Arrange
        var inclusion = new Inclusion(false);

        // Assert
        Assert.False(inclusion._included);
    }
}
