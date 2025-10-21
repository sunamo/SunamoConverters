// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoConverters._sunamo.SunamoData.Data;


internal class ABT<Key, Value>
{
    internal Key A;
    internal Value B;
    internal ABT(Key a, Value b)
    {
        A = a;
        B = b;
    }
    internal ABT()
    {
    }
}