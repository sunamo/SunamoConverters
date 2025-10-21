// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoConverters.Converts;

public static class NullableConverter
{
    public static bool Bool(bool? nullable)
    {
        if (nullable == null)
        {
            return false;
        }
        return nullable.Value;
    }
}
