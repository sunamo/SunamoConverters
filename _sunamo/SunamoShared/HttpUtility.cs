namespace SunamoConverters._sunamo.SunamoShared;

/// <summary>
///     Není ve sunamo, tím pádem nebudu dávat do NS
///     Třída byla vytvořena abych nemusel importovat System.Web pro metody jež nejsou v WebUtility
/// </summary>
internal class HttpUtility : SunamoExceptions.InSunamoIsDerivedFrom.HttpUtility
{
    internal static NameValueCollection ParseQueryString(string responseContent)
    {
        return HttpUtility.ParseQueryString(responseContent);
    }
    internal static string HtmlDecode(string v)
    {
        return WebUtility.HtmlDecode(v);
    }
    internal static string HtmlEncode(string html)
    {
        return HtmlEncodeWithCompatibility(html);
    }
    internal static string HtmlEncodeWithCompatibility(string html, bool backwardCompatibility = true)
    {
        if (html == null)
        {
            throw new Exception("html");
        }
        // replace & by &amp; but only once!
        Regex rx = backwardCompatibility
            ? new Regex("&(?!(amp;)|(lt;)|(gt;)|(quot;))", RegexOptions.IgnoreCase)
            : new Regex("&(?!(amp;)|(lt;)|(gt;)|(quot;)|(nbsp;)|(reg;))", RegexOptions.IgnoreCase);
        return rx.Replace(html, "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("\"", "&quot;");
    }
    internal static string UrlEncode(string slnName)
    {
        return WebUtility.UrlEncode(slnName);
    }
    internal static string UrlDecode(string v)
    {
        return WebUtility.UrlDecode(v);
    }
}
