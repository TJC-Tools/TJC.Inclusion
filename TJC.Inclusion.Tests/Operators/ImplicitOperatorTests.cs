namespace TJC.Inclusion.Tests.Operators;

[TestClass]
public class ImplicitOperatorTests
{
    #region Get

    [TestMethod]
    public void GetWithImplicitOperator_True()
    {
        // Arrange
        var inclusion = new Inclusion(true);

        // Assert
        Assert.IsTrue(inclusion);
    }

    [TestMethod]
    public void GetWithImplicitOperator_False()
    {
        // Arrange
        var inclusion = new Inclusion(false);

        // Assert
        Assert.IsFalse(inclusion);
    }

    #endregion

    #region Set

    [TestMethod]
    public void SetWithImplicitOperator_True()
    {
        // Arrange
        var value = true;

        // Act
        Inclusion inclusion = value;

        // Assert
        Assert.IsTrue(inclusion._included);
    }

    [TestMethod]
    public void SetWithImplicitOperator_False()
    {
        // Arrange
        var value = false;

        // Act
        Inclusion inclusion = value;

        // Assert
        Assert.IsFalse(inclusion._included);
    }

    #endregion
}
