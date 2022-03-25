using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace YoutubeVideosCLI
{
    [Serializable]
    public class Paperbits
    {
        public Dictionary<string, Page> files { get; set; }
        public Dictionary<string, Page> pages { get; set; }
        public object blocks { get; set; }
        public object emailTemplates { get; set; }
        public object groups { get; set; }
        public object layouts { get; set; }
        public Locales locales { get; set; }
        public List<NavigationItem> navigationItems { get; set; }
        public object settings { get; set; }
        public object styles { get; set; }
        public object uploads { get; set; }
        public object urls { get; set; }
        public object blobs { get; set; }
        public object popups { get; set; }
    }
    public class NavigationItem
    {
        public string key { get; set; }
        public string label { get; set; }
        public string targetKey { get; set; }
        public string targetWindow { get; set; }
        public string anchor { get; set; }
        public List<NavigationItem> navigationItems { get; set; }
    }

    public class Page
    {
        public List<Node> nodes { get; set; }
        public string type { get; set; }
        public string key { get; set; }
        public Locales locales { get; set; }
    }

    public class Locales
    {
        [JsonProperty("en-us")]
        public EnUs EnUs { get; set; }

        [JsonProperty("ru-ru")]
        public EnUs RuRu { get; set; }
    }

    public class EnUs
    {
        public string contentKey { get; set; }
        public string description { get; set; }
        public string permalinkTemplate { get; set; }
        public string title { get; set; }
        public string keywords { get; set; }
        public string permalink { get; set; }
    }

    public class Node
    {
        public string type { get; set; }
        public string? text { get; set; }
        public string navigationItemKey { get; set; }
        public string layout { get; set; }
        public object styles { get; set; }
        public object roles { get; set; }
        public object identifier { get; set; }
        public List<Node> nodes { get; set; }
        public string caption { get; set; }
        public string sourceKey { get; set; }
        public object hyperlink { get; set; }
        public string role { get; set; }
        public object attrs { get; set; }
        public int? minHeading { get; set; }
        public int? maxHeading { get; set; }
        public string padding { get; set; }
        public List<object> marks { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string alignment { get; set; }
        public object size { get; set; }
        public object background { get; set; }
        public string placeholder { get; set; }
        public string label { get; set; }
        public string encType { get; set; }
        public string formAction { get; set; }
        public string formMethod { get; set; }
        public string formTarget { get; set; }
        public bool? isInline { get; set; }
        public string videoId { get; set; }
    }

}
