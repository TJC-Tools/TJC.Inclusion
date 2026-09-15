namespace TJC.Inclusion.Tests.IncludeExclude;


public class ExcludeTests
{
    [Fact]
    public void CallExclude_InternalFalse()
    {
        // Arrange
        var inclusion = new Inclusion(true);

        // Act
        inclusion.Exclude();

        // Assert
        Assert.False(inclusion._included);
    }
}
