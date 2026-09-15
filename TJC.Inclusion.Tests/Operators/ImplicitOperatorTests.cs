namespace TJC.Inclusion.Tests.Operators;


public class ImplicitOperatorTests
{
    #region Get

    [Fact]
    public void GetWithImplicitOperator_True()
    {
        // Arrange
        var inclusion = new Inclusion(true);

        // Assert
        Assert.True(inclusion);
    }

    [Fact]
    public void GetWithImplicitOperator_False()
    {
        // Arrange
        var inclusion = new Inclusion(false);

        // Assert
        Assert.False(inclusion);
    }

    #endregion

    #region Set

    [Fact]
    public void SetWithImplicitOperator_True()
    {
        // Arrange
        var value = true;

        // Act
        Inclusion inclusion = value;

        // Assert
        Assert.True(inclusion._included);
    }

    [Fact]
    public void SetWithImplicitOperator_False()
    {
        // Arrange
        var value = false;

        // Act
        Inclusion inclusion = value;

        // Assert
        Assert.False(inclusion._included);
    }

    #endregion
}
