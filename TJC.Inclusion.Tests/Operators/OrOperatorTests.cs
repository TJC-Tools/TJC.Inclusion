namespace TJC.Inclusion.Tests.Operators;

[TestClass]
public class OrOperatorTests
{
    [TestMethod]
    public void OrOperator_WithBool()
    {
        // Arrange
        var included = new Inclusion(true);
        var excluded = new Inclusion(false);

        // Assert
        Assert.IsTrue(included | true);
        Assert.IsTrue(included | false);
        Assert.IsTrue(included || true);
        Assert.IsTrue(included || false);
        Assert.IsTrue(excluded | true);
        Assert.IsFalse(excluded | false);
        Assert.IsTrue(excluded || true);
        Assert.IsFalse(excluded || false);
    }

    [TestMethod]
    public void OrOperator_WithInclusion()
    {
        // Arrange
        var included1 = new Inclusion(true);
        var included2 = new Inclusion(true);
        var excluded1 = new Inclusion(false);
        var excluded2 = new Inclusion(false);

        // Assert
        Assert.IsTrue(included1 | included2);
        Assert.IsTrue(included1 | excluded1);
        Assert.IsTrue(included1 | excluded2);
        Assert.IsFalse(excluded1 | excluded2);
        Assert.IsTrue(included1 || included2);
        Assert.IsTrue(included1 || excluded1);
        Assert.IsTrue(included1 || excluded2);
        Assert.IsFalse(excluded1 || excluded2);
    }
}