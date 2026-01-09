// variables names: ok
namespace SunamoConverters._public.SunamoEnums.Enums;

// variables names: ok
// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
/// <summary>
/// Specifies the format used for DateTime conversion.
/// </summary>
public enum FromToUseConverters
{
    /// <summary>
    /// Standard DateTime format.
    /// </summary>
    DateTime,

    /// <summary>
    /// Unix timestamp format (seconds since 1970-01-01).
    /// </summary>
    Unix,

    /// <summary>
    /// Unix timestamp format for time only (without date component).
    /// </summary>
    UnixJustTime,

    /// <summary>
    /// No specific format.
    /// </summary>
    None
}