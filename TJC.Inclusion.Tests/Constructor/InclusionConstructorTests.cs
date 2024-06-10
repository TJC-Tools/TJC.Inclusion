namespace TJC.Inclusion.Tests.Constructor;

[TestClass]
public class InclusionConstructorTests
{
    [TestMethod]
    public void ConstructTrue_InternalTrue()
    {
        // Arrange
        var inclusion = new Inclusion(true);

        // Assert
        Assert.IsTrue(inclusion._included);
    }

    [TestMethod]
    public void ConstructFalse_InternalFalse()
    {
        // Arrange
        var inclusion = new Inclusion(false);

        // Assert
        Assert.IsFalse(inclusion._included);
    }
}