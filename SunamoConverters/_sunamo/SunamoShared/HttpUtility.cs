// variables names: ok
namespace SunamoConverters._sunamo.SunamoShared;

/// <summary>
/// Not in sunamo, therefore will not be placed in NS namespace.
/// This class was created to avoid importing System.Web for methods that are not in WebUtility.
/// </summary>
internal class HttpUtility
{
    internal static NameValueCollection ParseQueryString(string queryString)
    {
        return HttpUtility.ParseQueryString(queryString);
    }
}