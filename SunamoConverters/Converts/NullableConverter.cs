// variables names: ok
namespace SunamoConverters.Converts;

/// <summary>
/// Provides conversion methods for nullable types to non-nullable types.
/// </summary>
public static class NullableConverter
{
    /// <summary>
    /// Converts a nullable boolean to a non-nullable boolean.
    /// Returns false if the nullable boolean is null.
    /// </summary>
    /// <param name="nullable">The nullable boolean value.</param>
    /// <returns>The boolean value, or false if null.</returns>
    public static bool Bool(bool? nullable)
    {
        if (nullable == null)
        {
            return false;
        }
        return nullable.Value;
    }
}