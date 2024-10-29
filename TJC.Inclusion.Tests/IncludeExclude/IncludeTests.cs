namespace TJC.Inclusion.Tests.IncludeExclude;

[TestClass]
public class IncludeTests
{
    [TestMethod]
    public void CallInclude_InternalTrue()
    {
        // Arrange
        var inclusion = new Inclusion(false);

        // Act
        inclusion.Include();

        // Assert
        Assert.IsTrue(inclusion._included);
    }
}
