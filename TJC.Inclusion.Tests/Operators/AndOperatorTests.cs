namespace TJC.Inclusion.Tests.Operators;


public class AndOperatorTests
{
    [Fact]
    public void AndOperator_WithBool()
    {
        // Arrange
        var included = new Inclusion(true);
        var excluded = new Inclusion(false);

        // Assert
        Assert.True(included & true);
        Assert.False(included & false);
        Assert.True(included && true);
        Assert.False(included && false);
        Assert.False(excluded & true);
        Assert.False(excluded & false);
        Assert.False(excluded && true);
        Assert.False(excluded && false);
    }

    [Fact]
    public void AndOperator_WithInclusion()
    {
        // Arrange
        var included1 = new Inclusion(true);
        var included2 = new Inclusion(true);
        var excluded1 = new Inclusion(false);
        var excluded2 = new Inclusion(false);

        // Assert
        Assert.True(included1 & included2);
        Assert.False(included1 & excluded1);
        Assert.False(included1 & excluded2);
        Assert.False(excluded1 & excluded2);
        Assert.True(included1 && included2);
        Assert.False(included1 && excluded1);
        Assert.False(included1 && excluded2);
        Assert.False(excluded1 && excluded2);
    }
}
