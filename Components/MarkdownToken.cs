namespace MarkdownWiki.Components;

public class MarkdownToken(string token, bool isLink)
{
    public string Value { get; set; } = token;

    public bool IsLink { get; set; } = isLink;

    public string FullValue => IsLink ? "![[" + Value + "]]" : "[[" + Value + "]]";

    public string Cleaned => CleanValue();

    public string Refine(List<MenuItem> menuitems)
    {
        return Value;
    }

    private string CleanValue()
    {
        if (Value.Contains("|"))
        {
            return Value.Split("|")[0];
        }
        else
        {
            return Value;
        }
    }
}
