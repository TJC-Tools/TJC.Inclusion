using TJC.Inclusion.Extensions;
using TJC.Inclusion.Interfaces;

namespace TJC.Inclusion.Tests.IncludeExclude;


public class IncludeExcludeAllTests
{
    [Fact]
    public void IncludeAll_UpdatesEveryInclusionProperty()
    {
        var options = new IncludableOptions(false, false);

        options.IncludeAll();

        Assert.True(options.First);
        Assert.True(options.Second);
    }

    [Fact]
    public void ExcludeAll_UpdatesEveryInclusionProperty()
    {
        var options = new IncludableOptions(true, true);

        options.ExcludeAll();

        Assert.False(options.First);
        Assert.False(options.Second);
    }

    private sealed class IncludableOptions(bool first, bool second) : IIncludable
    {
        public Inclusion First { get; } = new(first);
        public Inclusion Second { get; } = new(second);
        public string Ignored { get; } = "ignored";
    }
}