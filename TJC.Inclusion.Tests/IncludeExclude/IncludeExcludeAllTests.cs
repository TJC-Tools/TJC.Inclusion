using TJC.Inclusion.Extensions;
using TJC.Inclusion.Interfaces;

namespace TJC.Inclusion.Tests.IncludeExclude;

[TestClass]
public class IncludeExcludeAllTests
{
    [TestMethod]
    public void IncludeAll_UpdatesEveryInclusionProperty()
    {
        var options = new IncludableOptions(false, false);

        options.IncludeAll();

        Assert.IsTrue(options.First);
        Assert.IsTrue(options.Second);
    }

    [TestMethod]
    public void ExcludeAll_UpdatesEveryInclusionProperty()
    {
        var options = new IncludableOptions(true, true);

        options.ExcludeAll();

        Assert.IsFalse(options.First);
        Assert.IsFalse(options.Second);
    }

    private sealed class IncludableOptions(bool first, bool second) : IIncludable
    {
        public Inclusion First { get; } = new(first);
        public Inclusion Second { get; } = new(second);
        public string Ignored { get; } = "ignored";
    }
}
