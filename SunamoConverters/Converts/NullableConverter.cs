namespace SunamoConverters.Converts;

public static class NullableConverter
{
    public static bool Bool(bool? nullable)
    {
        if (nullable is null)
        {
            return false;
        }
        return nullable.Value;
    }
}
