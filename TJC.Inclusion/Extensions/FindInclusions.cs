using System.Reflection;
using TJC.Inclusion.Interfaces;

namespace TJC.Inclusion.Extensions;

internal static class FindInclusions
{
    internal static List<PropertyInfo> GetInclusions(this IIncludable instance)
    {
        var properties = instance.GetType().GetProperties();
        return properties.Where(x => x.PropertyType == typeof(Inclusion)).ToList();
    }
}