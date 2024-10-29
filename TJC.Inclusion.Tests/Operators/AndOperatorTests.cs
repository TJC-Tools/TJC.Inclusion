namespace TJC.Inclusion.Tests.Operators;

[TestClass]
public class AndOperatorTests
{
    [TestMethod]
    public void AndOperator_WithBool()
    {
        // Arrange
        var included = new Inclusion(true);
        var excluded = new Inclusion(false);

        // Assert
        Assert.IsTrue(included & true);
        Assert.IsFalse(included & false);
        Assert.IsTrue(included && true);
        Assert.IsFalse(included && false);
        Assert.IsFalse(excluded & true);
        Assert.IsFalse(excluded & false);
        Assert.IsFalse(excluded && true);
        Assert.IsFalse(excluded && false);
    }

    [TestMethod]
    public void AndOperator_WithInclusion()
    {
        // Arrange
        var included1 = new Inclusion(true);
        var included2 = new Inclusion(true);
        var excluded1 = new Inclusion(false);
        var excluded2 = new Inclusion(false);

        // Assert
        Assert.IsTrue(included1 & included2);
        Assert.IsFalse(included1 & excluded1);
        Assert.IsFalse(included1 & excluded2);
        Assert.IsFalse(excluded1 & excluded2);
        Assert.IsTrue(included1 && included2);
        Assert.IsFalse(included1 && excluded1);
        Assert.IsFalse(included1 && excluded2);
        Assert.IsFalse(excluded1 && excluded2);
    }
}
