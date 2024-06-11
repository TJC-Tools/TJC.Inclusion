namespace TJC.Inclusion.Tests.IncludeExclude;

[TestClass]
public class ExcludeTests
{
    [TestMethod]
    public void CallExclude_InternalFalse()
    {
        // Arrange
        var inclusion = new Inclusion(true);

        // Act
        inclusion.Exclude();

        // Assert
        Assert.IsFalse(inclusion._included);
    }
}