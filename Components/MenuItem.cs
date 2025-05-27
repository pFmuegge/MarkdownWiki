namespace MarkdownWiki.Components
{
    public class MenuItem
    {
        public string Name { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;
        public string Extension { get; set; } = string.Empty;
        public bool IsFolder { get; set; }
        public bool IsPicture { get; set; }
        public List<MenuItem> Items { get; set; } = [];
    }
}
