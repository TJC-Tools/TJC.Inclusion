namespace TJC.Inclusion.Tests.Operators;


public class OrOperatorTests
{
    [Fact]
    public void OrOperator_WithBool()
    {
        // Arrange
        var included = new Inclusion(true);
        var excluded = new Inclusion(false);

        // Assert
        Assert.True(included | true);
        Assert.True(included | false);
        Assert.True(included || true);
        Assert.True(included || false);
        Assert.True(excluded | true);
        Assert.False(excluded | false);
        Assert.True(excluded || true);
        Assert.False(excluded || false);
    }

    [Fact]
    public void OrOperator_WithInclusion()
    {
        // Arrange
        var included1 = new Inclusion(true);
        var included2 = new Inclusion(true);
        var excluded1 = new Inclusion(false);
        var excluded2 = new Inclusion(false);

        // Assert
        Assert.True(included1 | included2);
        Assert.True(included1 | excluded1);
        Assert.True(included1 | excluded2);
        Assert.False(excluded1 | excluded2);
        Assert.True(included1 || included2);
        Assert.True(included1 || excluded1);
        Assert.True(included1 || excluded2);
        Assert.False(excluded1 || excluded2);
    }
}
