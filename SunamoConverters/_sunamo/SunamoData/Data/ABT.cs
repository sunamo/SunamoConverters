// variables names: ok
namespace SunamoConverters._sunamo.SunamoData.Data;

/// <summary>
/// A simple tuple-like class that holds two values of different types.
/// </summary>
/// <typeparam name="Key">The type of the first value.</typeparam>
/// <typeparam name="Value">The type of the second value.</typeparam>
internal class ABT<Key, Value>
{
    internal Key A;
    internal Value B;

    /// <summary>
    /// Initializes a new instance with the specified values.
    /// </summary>
    /// <param name="a">The first value.</param>
    /// <param name="b">The second value.</param>
    internal ABT(Key a, Value b)
    {
        A = a;
        B = b;
    }

    /// <summary>
    /// Initializes a new instance with default values.
    /// </summary>
    internal ABT()
    {
        A = default!;
        B = default!;
    }
}