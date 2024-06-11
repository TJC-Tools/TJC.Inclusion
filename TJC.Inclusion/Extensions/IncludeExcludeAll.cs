namespace TJC.Inclusion.Extensions;

public static class IncludeExcludeAll
{
    public static void IncludeAll(this object instance)
    {
        var inclusions = instance.GetInclusions();
        foreach (var inclusion in inclusions)
        {
            var include = inclusion.PropertyType.GetMethod(nameof(Inclusion.Include));
            include?.Invoke(inclusion.GetValue(instance), null);
        }
    }

    public static void ExcludeAll(this object instance)
    {
        var inclusions = instance.GetInclusions();
        foreach (var inclusion in inclusions)
        {
            var exclude = inclusion.PropertyType.GetMethod(nameof(Inclusion.Exclude));
            exclude?.Invoke(inclusion.GetValue(instance), null);
        }
    }
}