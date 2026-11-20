namespace SunamoConverters.Converts;

/// <summary>
/// Represents the nullable converter type.
/// </summary>
public static class NullableConverter
{
    /// <summary>
    /// Bool.
    /// </summary>
    /// <param name="nullable">The nullable.</param>
    /// <returns>The bool result.</returns>
    public static bool Bool(bool? nullable)
    {
        if (nullable is null)
        {
            return false;
        }
        return nullable.Value;
    }
}
