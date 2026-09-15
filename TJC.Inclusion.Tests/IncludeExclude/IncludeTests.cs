namespace TJC.Inclusion.Tests.IncludeExclude;


public class IncludeTests
{
    [Fact]
    public void CallInclude_InternalTrue()
    {
        // Arrange
        var inclusion = new Inclusion(false);

        // Act
        inclusion.Include();

        // Assert
        Assert.True(inclusion._included);
    }
}
