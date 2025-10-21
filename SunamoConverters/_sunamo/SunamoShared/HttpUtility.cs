// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoConverters._sunamo.SunamoShared;

/// <summary>
///     Není ve sunamo, tím pádem nebudu dávat do NS
///     Třída byla vytvořena abych nemusel importovat System.Web pro metody jež nejsou v WebUtility
/// </summary>
internal class HttpUtility //: SunamoExceptions.InSunamoIsDerivedFrom.HttpUtility
{
    internal static NameValueCollection ParseQueryString(string responseContent)
    {
        return HttpUtility.ParseQueryString(responseContent);
    }
}
