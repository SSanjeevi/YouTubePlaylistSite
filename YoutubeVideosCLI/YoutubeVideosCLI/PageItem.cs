using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeVideosCLI
{
    internal class PageItem
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class _79ae665dA99cA7f07706Cd98d3934e12
        {
            public string contentKey { get; set; }
            public string description { get; set; }
            public string key { get; set; }
            public string title { get; set; }
            public string type { get; set; }
        }

        public class E30f4a54Ec91A27e610d75c551da0c1f
        {
            public string contentKey { get; set; }
            public string description { get; set; }
            public string key { get; set; }
            public string title { get; set; }
            public string type { get; set; }
        }

        public class NewEmailTemplate
        {
            public string contentKey { get; set; }
            public string description { get; set; }
            public string key { get; set; }
            public string title { get; set; }
            public string type { get; set; }
            public List<Node> nodes { get; set; }
        }

        public class NewPageTemplate
        {
            public string contentKey { get; set; }
            public string description { get; set; }
            public string key { get; set; }
            public string title { get; set; }
            public string type { get; set; }
            public List<Node> nodes { get; set; }
        }

        public class _4659921aAa9cE259Fd946ccd28189e1b
        {
            public string type { get; set; }
            public string key { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string contentKey { get; set; }
        }

        public class _4ee4381936f3415dCfe9De514c4f0ca1
        {
            public string type { get; set; }
            public string key { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string contentKey { get; set; }
        }

        public class Blocks
        {
            [JsonProperty("79ae665d-a99c-a7f0-7706-cd98d3934e12")]
            public _79ae665dA99cA7f07706Cd98d3934e12 _79ae665dA99cA7f07706Cd98d3934e12 { get; set; }

            [JsonProperty("e30f4a54-ec91-a27e-610d-75c551da0c1f")]
            public E30f4a54Ec91A27e610d75c551da0c1f E30f4a54Ec91A27e610d75c551da0c1f { get; set; }

            [JsonProperty("new-email-template")]
            public NewEmailTemplate NewEmailTemplate { get; set; }

            [JsonProperty("new-page-template")]
            public NewPageTemplate NewPageTemplate { get; set; }

            [JsonProperty("4659921a-aa9c-e259-fd94-6ccd28189e1b")]
            public _4659921aAa9cE259Fd946ccd28189e1b _4659921aAa9cE259Fd946ccd28189e1b { get; set; }

            [JsonProperty("4ee43819-36f3-415d-cfe9-de514c4f0ca1")]
            public _4ee4381936f3415dCfe9De514c4f0ca1 _4ee4381936f3415dCfe9De514c4f0ca1 { get; set; }
        }

        public class _534aa61cB373FabeA38269af97efdbbb
        {
            public string contentKey { get; set; }
            public string description { get; set; }
            public string key { get; set; }
            public string title { get; set; }
            public List<Node> nodes { get; set; }
            public string type { get; set; }
        }

        public class Bace198bEcac670c82be658bf249f9c6
        {
            public string contentKey { get; set; }
            public string description { get; set; }
            public string key { get; set; }
            public string title { get; set; }
            public List<Node> nodes { get; set; }
            public string type { get; set; }
        }

        public class EmailTemplates
        {
            [JsonProperty("534aa61c-b373-fabe-a382-69af97efdbbb")]
            public _534aa61cB373FabeA38269af97efdbbb _534aa61cB373FabeA38269af97efdbbb { get; set; }

            [JsonProperty("bace198b-ecac-670c-82be-658bf249f9c6")]
            public Bace198bEcac670c82be658bf249f9c6 Bace198bEcac670c82be658bf249f9c6 { get; set; }
        }

        public class StickTo
        {
            public string lg { get; set; }
            public string md { get; set; }
            public string sm { get; set; }
            public string xl { get; set; }
            public string xs { get; set; }
        }

        public class Xl
        {
            public bool stretch { get; set; }
            public Alignment alignment { get; set; }
            public string left { get; set; }
            public string right { get; set; }
            public object bottom { get; set; }
            public object top { get; set; }
            public int maxWidth { get; set; }
            public string textAlign { get; set; }
        }

        public class Size
        {
            public Xl xl { get; set; }
            public Md md { get; set; }
            public Sm sm { get; set; }
            public Lg lg { get; set; }
            public Xs xs { get; set; }
            public int maxWidth { get; set; }
            public string maxHeight { get; set; }
            public string minHeight { get; set; }
            public string minWidth { get; set; }
        }

        public class Instance
        {
            public string key { get; set; }
            public StickTo stickTo { get; set; }
            public Size size { get; set; }
            public Container container { get; set; }

            [JsonProperty("grid-cell")]
            public GridCell GridCell { get; set; }
            public Padding padding { get; set; }
            public Grid grid { get; set; }
            public Margin margin { get; set; }
            public string id { get; set; }
            public Components components { get; set; }
        }

        public class Styles
        {
            public Instance instance { get; set; }
            public string appearance { get; set; }
            public Alignment alignment { get; set; }
            public Animations animations { get; set; }
            public Colors colors { get; set; }
            public Components components { get; set; }
            public Fonts fonts { get; set; }
            public Globals globals { get; set; }
            public Gradients gradients { get; set; }
            public Shadows shadows { get; set; }
            public Utils utils { get; set; }
        }

        public class Alignment
        {
            public string horizontal { get; set; }
            public string xs { get; set; }
            public string vertical { get; set; }
            public string md { get; set; }
            public string xl { get; set; }
        }

        public class Md
        {
            public Alignment alignment { get; set; }
            public string minWidth { get; set; }
            public int bottom { get; set; }
            public int top { get; set; }
            public int? left { get; set; }
            public int? right { get; set; }
            public int maxWidth { get; set; }
            public bool stretch { get; set; }
            public Position position { get; set; }
            public Span span { get; set; }
            public List<string> cols { get; set; }
            public List<string> rows { get; set; }
            public string textAlign { get; set; }
        }

        public class Lg
        {
            public Alignment alignment { get; set; }
            public int maxWidth { get; set; }
            public bool stretch { get; set; }
            public string left { get; set; }
            public string right { get; set; }
            public string textAlign { get; set; }
        }

        public class Container
        {
            public Xl xl { get; set; }
            public Md md { get; set; }
            public Lg lg { get; set; }
            public string overflow { get; set; }
        }

        public class Hyperlink
        {
            public string targetKey { get; set; }
            public string target { get; set; }
        }

        public class Node6
        {
            public string type { get; set; }
            public string text { get; set; }
            public string navigationItemKey { get; set; }
            public string layout { get; set; }
            public Styles styles { get; set; }
            public object roles { get; set; }
            public object identifier { get; set; }
            public List<Node> nodes { get; set; }
            public string caption { get; set; }
            public string sourceKey { get; set; }
            public Hyperlink hyperlink { get; set; }
            public string role { get; set; }
            public Attrs attrs { get; set; }
            public int? minHeading { get; set; }
            public int? maxHeading { get; set; }
            public string padding { get; set; }
            public List<Mark> marks { get; set; }
            public string width { get; set; }
            public string height { get; set; }
            public string alignment { get; set; }
            public string size { get; set; }
            public Background background { get; set; }
            public string placeholder { get; set; }
            public string label { get; set; }
            public string encType { get; set; }
            public string formAction { get; set; }
            public string formMethod { get; set; }
            public string formTarget { get; set; }
            public bool? isInline { get; set; }
            public string videoId { get; set; }
        }

        public class Position
        {
            public int col { get; set; }
            public int row { get; set; }
            public string position { get; set; }
            public string top { get; set; }
            public string left { get; set; }
            public int zIndex { get; set; }
        }

        public class Span
        {
            public int cols { get; set; }
            public int rows { get; set; }
        }

        public class Xs
        {
            public Alignment alignment { get; set; }
            public Position position { get; set; }
            public Span span { get; set; }
            public int bottom { get; set; }
            public int left { get; set; }
            public int right { get; set; }
            public int top { get; set; }
            public List<string> cols { get; set; }
            public List<string> rows { get; set; }
            public bool stretch { get; set; }
            public string textAlign { get; set; }
        }

        public class Sm
        {
            public Alignment alignment { get; set; }
            public int maxWidth { get; set; }
            public bool stretch { get; set; }
            public string left { get; set; }
            public string right { get; set; }
            public int bottom { get; set; }
            public int top { get; set; }
            public string textAlign { get; set; }
        }

        public class GridCell
        {
            public Md md { get; set; }
            public Xs xs { get; set; }
            public Sm sm { get; set; }
            public Xl xl { get; set; }
            public Lg lg { get; set; }
        }

        public class Padding
        {
            public Md md { get; set; }
            public Xs xs { get; set; }
            public int top { get; set; }
            public int left { get; set; }
            public int right { get; set; }
            public int bottom { get; set; }
        }

        public class Grid
        {
            public Xs xs { get; set; }
            public Md md { get; set; }
            public string colGap { get; set; }
            public List<string> cols { get; set; }
            public string rowGap { get; set; }
            public List<string> rows { get; set; }
        }

        public class Margin
        {
            public Xl xl { get; set; }
            public Xs xs { get; set; }
            public Md md { get; set; }
            public Lg lg { get; set; }
            public Sm sm { get; set; }
            public int bottom { get; set; }
            public int left { get; set; }
            public int right { get; set; }
            public int top { get; set; }
        }

        public class _06413c7c6d43987e7bfa4b7c0c400f29
        {
            public List<Node> nodes { get; set; }
            public string type { get; set; }
            public string key { get; set; }
            public Locales locales { get; set; }
        }

        public class Attrs
        {
            public string id { get; set; }
            public string target { get; set; }
            public string targetKey { get; set; }
            public string className { get; set; }
            public Styles styles { get; set; }
        }

        public class _06aae0ec8ed4F30fFe881565dad11bef
        {
            public List<Node> nodes { get; set; }
            public string type { get; set; }
            public string key { get; set; }
            public Locales locales { get; set; }
        }

        public class _0fad98caB406084814cf705a9d51df39
        {
            public List<Node> nodes { get; set; }
            public string type { get; set; }
            public string key { get; set; }
            public Locales locales { get; set; }
        }

        public class _223dcbfcC757A377195c8914643c55a2
        {
            public List<Node> nodes { get; set; }
            public string type { get; set; }
            public string key { get; set; }
            public Locales locales { get; set; }
        }

        public class _22ca5736A296D61d6bc24f2d819824dd
        {
            public List<Node> nodes { get; set; }
            public string type { get; set; }
            public string key { get; set; }
            public Locales locales { get; set; }
        }

        public class _423af72d00ec8514B49312180fb9827d
        {
            public List<Node> nodes { get; set; }
            public Styles styles { get; set; }
            public string type { get; set; }
        }

        public class Background
        {
            public string position { get; set; }
            public string size { get; set; }
            public string colorKey { get; set; }
            public List<Image> images { get; set; }
        }

        public class Mark
        {
            public Attrs attrs { get; set; }
            public string type { get; set; }
        }

        public class _6b4747ca1b9eA39d6d77Be0de4046856
        {
            public List<Node> nodes { get; set; }
            public string type { get; set; }
            public string key { get; set; }
            public Locales locales { get; set; }
        }

        public class _75b56f8eEc8aFed34bba16baeeb96fb3
        {
            public List<Node> nodes { get; set; }
            public string type { get; set; }
        }

        public class _9cc8dbffB351B878214d3a1357c81eb6
        {
            public List<Node> nodes { get; set; }
            public string type { get; set; }
            public string key { get; set; }
            public Locales locales { get; set; }
        }

        public class _9ee6da1b9c67A5b2Fb6917dc5859f52c
        {
            public List<Node> nodes { get; set; }
            public string type { get; set; }
            public string key { get; set; }
            public Locales locales { get; set; }
        }

        public class A4095a4c5147159623b4Bd77a6c5f6dc
        {
            public List<Node> nodes { get; set; }
            public string type { get; set; }
            public string key { get; set; }
            public Locales locales { get; set; }
        }

        public class Cd8e1361Fbb146962079536dd93e4c54
        {
            public List<Node> nodes { get; set; }
            public string type { get; set; }
            public string key { get; set; }
            public Locales locales { get; set; }
        }

        public class F8e79d81F2e73c7127211446fca49901
        {
            public List<Node> nodes { get; set; }
            public string type { get; set; }
        }

        public class Ffdcdb4eBad4Dfd73e9cC0b2a917b66a
        {
            public string key { get; set; }
            public List<Node> nodes { get; set; }
            public string type { get; set; }
        }

        public class C4f371951b65F93819f0F49477678663
        {
            public string type { get; set; }
            public Styles styles { get; set; }
            public List<Node> nodes { get; set; }
        }

        public class _99685cbc0cbaAee584f65a3cecafeea9
        {
            public string type { get; set; }
            public Styles styles { get; set; }
            public List<Node> nodes { get; set; }
        }

        public class _0a73943dD54cDc5840b73d6e6033fbb9
        {
            public string type { get; set; }
            public List<Node> nodes { get; set; }
            public string key { get; set; }
            public Locales locales { get; set; }
        }

        public class B03d854aA300475420baA811620dd8fc
        {
            public string type { get; set; }
            public Styles styles { get; set; }
            public List<Node> nodes { get; set; }
        }

        public class Translate
        {
            public string x { get; set; }
            public string y { get; set; }
        }

        public class Transform
        {
            public Translate translate { get; set; }
        }

        public class Bottom
        {
            public string colorKey { get; set; }
            public string style { get; set; }
            public string width { get; set; }
            public string color { get; set; }
        }

        public class Left
        {
            public string colorKey { get; set; }
            public string style { get; set; }
            public string width { get; set; }
            public string color { get; set; }
        }

        public class Right
        {
            public string colorKey { get; set; }
            public string style { get; set; }
            public string width { get; set; }
            public string color { get; set; }
        }

        public class Top
        {
            public string colorKey { get; set; }
            public string style { get; set; }
            public string width { get; set; }
            public string color { get; set; }
        }

        public class Border
        {
            public Bottom bottom { get; set; }
            public Left left { get; set; }
            public Right right { get; set; }
            public Top top { get; set; }
        }

        public class Default
        {
            public Position position { get; set; }
            public Background background { get; set; }
            public Transform transform { get; set; }
            public Size size { get; set; }
            public Padding padding { get; set; }
            public Container container { get; set; }
            public Border border { get; set; }
            public string displayName { get; set; }
            public string key { get; set; }
            public string value { get; set; }
            public List<string> allowedStates { get; set; }
            public BorderRadius borderRadius { get; set; }
            public string category { get; set; }
            public Margin margin { get; set; }
            public Shadow shadow { get; set; }
            public States states { get; set; }
            public Typography typography { get; set; }
            public Components components { get; set; }
            public string family { get; set; }
            public List<Variant> variants { get; set; }
        }

        public class PopupContainer
        {
            public Default @default { get; set; }
        }

        public class Components
        {
            public PopupContainer popupContainer { get; set; }
            public Dropdown dropdown { get; set; }
            public NavLink navLink { get; set; }
            public Button button { get; set; }
            public Card card { get; set; }
            public FormControl formControl { get; set; }
            public Menu menu { get; set; }
            public Navbar navbar { get; set; }
            public Picture picture { get; set; }
            public VideoPlayer videoPlayer { get; set; }
            public TabPanel tabPanel { get; set; }
            public Li li { get; set; }
        }

        public class E7fe8cfe9e88Fbcd08aa21a45e916ea2
        {
            public string type { get; set; }
            public string key { get; set; }
            public bool backdrop { get; set; }
            public Styles styles { get; set; }
            public List<Node> nodes { get; set; }
            public Locales locales { get; set; }
        }

        public class Files
        {
            [JsonProperty("06413c7c-6d43-987e-7bfa-4b7c0c400f29")]
            public _06413c7c6d43987e7bfa4b7c0c400f29 _06413c7c6d43987e7bfa4b7c0c400f29 { get; set; }

            [JsonProperty("06aae0ec-8ed4-f30f-fe88-1565dad11bef")]
            public _06aae0ec8ed4F30fFe881565dad11bef _06aae0ec8ed4F30fFe881565dad11bef { get; set; }

            [JsonProperty("0fad98ca-b406-0848-14cf-705a9d51df39")]
            public _0fad98caB406084814cf705a9d51df39 _0fad98caB406084814cf705a9d51df39 { get; set; }

            [JsonProperty("223dcbfc-c757-a377-195c-8914643c55a2")]
            public _223dcbfcC757A377195c8914643c55a2 _223dcbfcC757A377195c8914643c55a2 { get; set; }

            [JsonProperty("22ca5736-a296-d61d-6bc2-4f2d819824dd")]
            public _22ca5736A296D61d6bc24f2d819824dd _22ca5736A296D61d6bc24f2d819824dd { get; set; }

            [JsonProperty("423af72d-00ec-8514-b493-12180fb9827d")]
            public _423af72d00ec8514B49312180fb9827d _423af72d00ec8514B49312180fb9827d { get; set; }

            [JsonProperty("534aa61c-b373-fabe-a382-69af97efdbbb")]
            public _534aa61cB373FabeA38269af97efdbbb _534aa61cB373FabeA38269af97efdbbb { get; set; }

            [JsonProperty("6b4747ca-1b9e-a39d-6d77-be0de4046856")]
            public _6b4747ca1b9eA39d6d77Be0de4046856 _6b4747ca1b9eA39d6d77Be0de4046856 { get; set; }

            [JsonProperty("75b56f8e-ec8a-fed3-4bba-16baeeb96fb3")]
            public _75b56f8eEc8aFed34bba16baeeb96fb3 _75b56f8eEc8aFed34bba16baeeb96fb3 { get; set; }

            [JsonProperty("9cc8dbff-b351-b878-214d-3a1357c81eb6")]
            public _9cc8dbffB351B878214d3a1357c81eb6 _9cc8dbffB351B878214d3a1357c81eb6 { get; set; }

            [JsonProperty("9ee6da1b-9c67-a5b2-fb69-17dc5859f52c")]
            public _9ee6da1b9c67A5b2Fb6917dc5859f52c _9ee6da1b9c67A5b2Fb6917dc5859f52c { get; set; }

            [JsonProperty("a4095a4c-5147-1596-23b4-bd77a6c5f6dc")]
            public A4095a4c5147159623b4Bd77a6c5f6dc A4095a4c5147159623b4Bd77a6c5f6dc { get; set; }

            [JsonProperty("bace198b-ecac-670c-82be-658bf249f9c6")]
            public Bace198bEcac670c82be658bf249f9c6 Bace198bEcac670c82be658bf249f9c6 { get; set; }

            [JsonProperty("cd8e1361-fbb1-4696-2079-536dd93e4c54")]
            public Cd8e1361Fbb146962079536dd93e4c54 Cd8e1361Fbb146962079536dd93e4c54 { get; set; }

            [JsonProperty("f8e79d81-f2e7-3c71-2721-1446fca49901")]
            public F8e79d81F2e73c7127211446fca49901 F8e79d81F2e73c7127211446fca49901 { get; set; }

            [JsonProperty("ffdcdb4e-bad4-dfd7-3e9c-c0b2a917b66a")]
            public Ffdcdb4eBad4Dfd73e9cC0b2a917b66a Ffdcdb4eBad4Dfd73e9cC0b2a917b66a { get; set; }

            [JsonProperty("new-email-template")]
            public NewEmailTemplate NewEmailTemplate { get; set; }

            [JsonProperty("new-page-template")]
            public NewPageTemplate NewPageTemplate { get; set; }

            [JsonProperty("c4f37195-1b65-f938-19f0-f49477678663")]
            public C4f371951b65F93819f0F49477678663 C4f371951b65F93819f0F49477678663 { get; set; }

            [JsonProperty("99685cbc-0cba-aee5-84f6-5a3cecafeea9")]
            public _99685cbc0cbaAee584f65a3cecafeea9 _99685cbc0cbaAee584f65a3cecafeea9 { get; set; }

            [JsonProperty("0a73943d-d54c-dc58-40b7-3d6e6033fbb9")]
            public _0a73943dD54cDc5840b73d6e6033fbb9 _0a73943dD54cDc5840b73d6e6033fbb9 { get; set; }

            [JsonProperty("b03d854a-a300-4754-20ba-a811620dd8fc")]
            public B03d854aA300475420baA811620dd8fc B03d854aA300475420baA811620dd8fc { get; set; }

            [JsonProperty("e7fe8cfe-9e88-fbcd-08aa-21a45e916ea2")]
            public E7fe8cfe9e88Fbcd08aa21a45e916ea2 E7fe8cfe9e88Fbcd08aa21a45e916ea2 { get; set; }
        }

        public class Admin
        {
            public string name { get; set; }
        }

        public class Groups
        {
            public Admin admin { get; set; }
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

        public class Locales
        {
            [JsonProperty("en-us")]
            public EnUs EnUs { get; set; }

            [JsonProperty("ru-ru")]
            public RuRu RuRu { get; set; }
        }

        public class Layouts
        {
            [JsonProperty("06413c7c-6d43-987e-7bfa-4b7c0c400f29")]
            public _06413c7c6d43987e7bfa4b7c0c400f29 _06413c7c6d43987e7bfa4b7c0c400f29 { get; set; }

            [JsonProperty("0fad98ca-b406-0848-14cf-705a9d51df39")]
            public _0fad98caB406084814cf705a9d51df39 _0fad98caB406084814cf705a9d51df39 { get; set; }

            [JsonProperty("223dcbfc-c757-a377-195c-8914643c55a2")]
            public _223dcbfcC757A377195c8914643c55a2 _223dcbfcC757A377195c8914643c55a2 { get; set; }

            [JsonProperty("6b4747ca-1b9e-a39d-6d77-be0de4046856")]
            public _6b4747ca1b9eA39d6d77Be0de4046856 _6b4747ca1b9eA39d6d77Be0de4046856 { get; set; }

            [JsonProperty("cd8e1361-fbb1-4696-2079-536dd93e4c54")]
            public Cd8e1361Fbb146962079536dd93e4c54 Cd8e1361Fbb146962079536dd93e4c54 { get; set; }
        }

        public class RuRu
        {
            public string code { get; set; }
            public string displayName { get; set; }
            public string key { get; set; }
            public string contentKey { get; set; }
            public string description { get; set; }
            public string keywords { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class NavigationItem2
        {
            public string key { get; set; }
            public string label { get; set; }
            public string targetKey { get; set; }
            public string targetWindow { get; set; }
            public string anchor { get; set; }
            public object navigationItems { get; set; }
        }

        public class E0987ca1F458B54676977be594b35583
        {
            public string key { get; set; }
            public Locales locales { get; set; }
        }

        public class Pages
        {
            [JsonProperty("06aae0ec-8ed4-f30f-fe88-1565dad11bef")]
            public _06aae0ec8ed4F30fFe881565dad11bef _06aae0ec8ed4F30fFe881565dad11bef { get; set; }

            [JsonProperty("22ca5736-a296-d61d-6bc2-4f2d819824dd")]
            public _22ca5736A296D61d6bc24f2d819824dd _22ca5736A296D61d6bc24f2d819824dd { get; set; }

            [JsonProperty("9cc8dbff-b351-b878-214d-3a1357c81eb6")]
            public _9cc8dbffB351B878214d3a1357c81eb6 _9cc8dbffB351B878214d3a1357c81eb6 { get; set; }

            [JsonProperty("9ee6da1b-9c67-a5b2-fb69-17dc5859f52c")]
            public _9ee6da1b9c67A5b2Fb6917dc5859f52c _9ee6da1b9c67A5b2Fb6917dc5859f52c { get; set; }

            [JsonProperty("a4095a4c-5147-1596-23b4-bd77a6c5f6dc")]
            public A4095a4c5147159623b4Bd77a6c5f6dc A4095a4c5147159623b4Bd77a6c5f6dc { get; set; }

            [JsonProperty("e0987ca1-f458-b546-7697-7be594b35583")]
            public E0987ca1F458B54676977be594b35583 E0987ca1F458B54676977be594b35583 { get; set; }

            [JsonProperty("0a73943d-d54c-dc58-40b7-3d6e6033fbb9")]
            public _0a73943dD54cDc5840b73d6e6033fbb9 _0a73943dD54cDc5840b73d6e6033fbb9 { get; set; }
        }

        public class Site
        {
            public string author { get; set; }
            public string description { get; set; }
            public string faviconSourceKey { get; set; }
            public string hostname { get; set; }
            public string keywords { get; set; }
            public string title { get; set; }
        }

        public class Settings
        {
            public Site site { get; set; }
        }

        public class Bounce
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class BounceIn
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class BounceInDown
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class BounceInLeft
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class BounceInRight
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class BounceInUp
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class BounceOut
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class BounceOutDown
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class BounceOutLeft
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class BounceOutRight
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class BounceOutUp
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class FadeIn
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class FadeInDown
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class FadeInDownBig
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class FadeInLeft
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class FadeInLeftBig
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class FadeInRight
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class FadeInRightBig
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class FadeInUp
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class FadeInUpBig
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class FadeOut
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class FadeOutDown
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class FadeOutDownBig
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class FadeOutLeft
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class FadeOutLeftBig
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class FadeOutRight
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class FadeOutRightBig
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class FadeOutUp
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class FadeOutUpBig
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class Flash
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class FlipInX
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class FlipInY
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class FlipOutX
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class FlipOutY
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class HeadShake
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class HeartBeat
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class Hinge
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class JackInTheBox
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class Jello
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class LightSpeedIn
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class LightSpeedOut
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class Pulse
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class RollIn
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class RollOut
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class RotateIn
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class RotateInDownLeft
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class RotateInDownRight
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class RotateInUpLeft
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class RotateInUpRight
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class RotateOut
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class RotateOutDownLeft
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class RotateOutDownRight
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class RotateOutUpLeft
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class RotateOutUpRight
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class RubberBand
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class Shake
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class SlideInDown
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class SlideInLeft
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class SlideInRight
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class SlideInUp
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class SlideOutDown
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class SlideOutLeft
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class SlideOutRight
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class SlideOutUp
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class Swing
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class Tada
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class Wobble
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class ZoomIn
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class ZoomInDown
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class ZoomInLeft
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class ZoomInRight
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class ZoomInUp
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class ZoomOut
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class ZoomOutDown
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class ZoomOutLeft
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class ZoomOutRight
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class ZoomOutUp
        {
            public string displayName { get; set; }
            public int duration { get; set; }
            public string iterationCount { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string timingFunction { get; set; }
        }

        public class Animations
        {
            public Bounce bounce { get; set; }
            public BounceIn bounceIn { get; set; }
            public BounceInDown bounceInDown { get; set; }
            public BounceInLeft bounceInLeft { get; set; }
            public BounceInRight bounceInRight { get; set; }
            public BounceInUp bounceInUp { get; set; }
            public BounceOut bounceOut { get; set; }
            public BounceOutDown bounceOutDown { get; set; }
            public BounceOutLeft bounceOutLeft { get; set; }
            public BounceOutRight bounceOutRight { get; set; }
            public BounceOutUp bounceOutUp { get; set; }
            public FadeIn fadeIn { get; set; }
            public FadeInDown fadeInDown { get; set; }
            public FadeInDownBig fadeInDownBig { get; set; }
            public FadeInLeft fadeInLeft { get; set; }
            public FadeInLeftBig fadeInLeftBig { get; set; }
            public FadeInRight fadeInRight { get; set; }
            public FadeInRightBig fadeInRightBig { get; set; }
            public FadeInUp fadeInUp { get; set; }
            public FadeInUpBig fadeInUpBig { get; set; }
            public FadeOut fadeOut { get; set; }
            public FadeOutDown fadeOutDown { get; set; }
            public FadeOutDownBig fadeOutDownBig { get; set; }
            public FadeOutLeft fadeOutLeft { get; set; }
            public FadeOutLeftBig fadeOutLeftBig { get; set; }
            public FadeOutRight fadeOutRight { get; set; }
            public FadeOutRightBig fadeOutRightBig { get; set; }
            public FadeOutUp fadeOutUp { get; set; }
            public FadeOutUpBig fadeOutUpBig { get; set; }
            public Flash flash { get; set; }
            public FlipInX flipInX { get; set; }
            public FlipInY flipInY { get; set; }
            public FlipOutX flipOutX { get; set; }
            public FlipOutY flipOutY { get; set; }
            public HeadShake headShake { get; set; }
            public HeartBeat heartBeat { get; set; }
            public Hinge hinge { get; set; }
            public JackInTheBox jackInTheBox { get; set; }
            public Jello jello { get; set; }
            public LightSpeedIn lightSpeedIn { get; set; }
            public LightSpeedOut lightSpeedOut { get; set; }
            public Pulse pulse { get; set; }
            public RollIn rollIn { get; set; }
            public RollOut rollOut { get; set; }
            public RotateIn rotateIn { get; set; }
            public RotateInDownLeft rotateInDownLeft { get; set; }
            public RotateInDownRight rotateInDownRight { get; set; }
            public RotateInUpLeft rotateInUpLeft { get; set; }
            public RotateInUpRight rotateInUpRight { get; set; }
            public RotateOut rotateOut { get; set; }
            public RotateOutDownLeft rotateOutDownLeft { get; set; }
            public RotateOutDownRight rotateOutDownRight { get; set; }
            public RotateOutUpLeft rotateOutUpLeft { get; set; }
            public RotateOutUpRight rotateOutUpRight { get; set; }
            public RubberBand rubberBand { get; set; }
            public Shake shake { get; set; }
            public SlideInDown slideInDown { get; set; }
            public SlideInLeft slideInLeft { get; set; }
            public SlideInRight slideInRight { get; set; }
            public SlideInUp slideInUp { get; set; }
            public SlideOutDown slideOutDown { get; set; }
            public SlideOutLeft slideOutLeft { get; set; }
            public SlideOutRight slideOutRight { get; set; }
            public SlideOutUp slideOutUp { get; set; }
            public Swing swing { get; set; }
            public Tada tada { get; set; }
            public Wobble wobble { get; set; }
            public ZoomIn zoomIn { get; set; }
            public ZoomInDown zoomInDown { get; set; }
            public ZoomInLeft zoomInLeft { get; set; }
            public ZoomInRight zoomInRight { get; set; }
            public ZoomInUp zoomInUp { get; set; }
            public ZoomOut zoomOut { get; set; }
            public ZoomOutDown zoomOutDown { get; set; }
            public ZoomOutLeft zoomOutLeft { get; set; }
            public ZoomOutRight zoomOutRight { get; set; }
            public ZoomOutUp zoomOutUp { get; set; }
        }

        public class _15o9C
        {
            public string displayName { get; set; }
            public string key { get; set; }
            public string value { get; set; }
        }

        public class D1r8O
        {
            public string displayName { get; set; }
            public string key { get; set; }
            public string value { get; set; }
        }

        public class Dark
        {
            public string displayName { get; set; }
            public string key { get; set; }
            public string value { get; set; }
        }

        public class DefaultBg
        {
            public string displayName { get; set; }
            public string key { get; set; }
            public string value { get; set; }
        }

        public class LJzU8
        {
            public string displayName { get; set; }
            public string key { get; set; }
            public string value { get; set; }
        }

        public class Links
        {
            public string displayName { get; set; }
            public string key { get; set; }
            public string value { get; set; }
        }

        public class PrimaryBg
        {
            public string displayName { get; set; }
            public string key { get; set; }
            public string value { get; set; }
        }

        public class PrimaryText
        {
            public string displayName { get; set; }
            public string key { get; set; }
            public string value { get; set; }
        }

        public class Colors
        {
            public _15o9C _15o9C { get; set; }
            public D1r8O D1r8O { get; set; }
            public Dark dark { get; set; }
            public Default @default { get; set; }
            public DefaultBg defaultBg { get; set; }
            public LJzU8 lJzU8 { get; set; }
            public Links links { get; set; }
            public PrimaryBg primaryBg { get; set; }
            public PrimaryText primaryText { get; set; }
        }

        public class BorderRadius
        {
            public int bottomLeftRadius { get; set; }
            public int bottomRightRadius { get; set; }
            public int topLeftRadius { get; set; }
            public int topRightRadius { get; set; }
        }

        public class Shadow
        {
            public string shadowKey { get; set; }
        }

        public class Typography
        {
            public string colorKey { get; set; }
            public string fontStyle { get; set; }
            public string textDecoration { get; set; }
            public string shadowKey { get; set; }
            public string fontWeight { get; set; }
            public int fontSize { get; set; }
            public string fontKey { get; set; }
            public string textTransform { get; set; }
            public string textAlign { get; set; }
            public Lg lg { get; set; }
            public Md md { get; set; }
            public Sm sm { get; set; }
            public Xl xl { get; set; }
            public Xs xs { get; set; }
        }

        public class Hover
        {
            public Background background { get; set; }
            public Typography typography { get; set; }
        }

        public class States
        {
            public Hover hover { get; set; }
        }

        public class Image
        {
            public string position { get; set; }
            public string repeat { get; set; }
            public string size { get; set; }
            public string sourceKey { get; set; }
        }

        public class Einvh
        {
            public List<string> allowedStates { get; set; }
            public Background background { get; set; }
            public Border border { get; set; }
            public BorderRadius borderRadius { get; set; }
            public string category { get; set; }
            public string displayName { get; set; }
            public string key { get; set; }
            public Margin margin { get; set; }
            public Padding padding { get; set; }
            public Shadow shadow { get; set; }
            public States states { get; set; }
            public Typography typography { get; set; }
        }

        public class Primary
        {
            public List<string> allowedStates { get; set; }
            public Background background { get; set; }
            public string category { get; set; }
            public string displayName { get; set; }
            public string key { get; set; }
            public States states { get; set; }
            public Typography typography { get; set; }
        }

        public class Button
        {
            public Default @default { get; set; }
            public Einvh einvh { get; set; }
            public Primary primary { get; set; }
        }

        public class Card
        {
            public Default @default { get; set; }
        }

        public class FormControl
        {
            public Default @default { get; set; }
        }

        public class Dropdown
        {
            public Default @default { get; set; }
        }

        public class Active
        {
            public List<string> allowedStates { get; set; }
            public string displayName { get; set; }
            public string key { get; set; }
            public Typography typography { get; set; }
        }

        public class NavLink
        {
            public Active active { get; set; }
            public Default @default { get; set; }
        }

        public class _6jz0j
        {
            public string category { get; set; }
            public Components components { get; set; }
            public string displayName { get; set; }
            public string key { get; set; }
            public Margin margin { get; set; }
            public Padding padding { get; set; }
            public Typography typography { get; set; }
        }

        public class Menu
        {
            public _6jz0j _6jz0j { get; set; }
            public Default @default { get; set; }
        }

        public class Navbar
        {
            public Default @default { get; set; }
        }

        public class Vugi6
        {
            public BorderRadius borderRadius { get; set; }
            public string category { get; set; }
            public string displayName { get; set; }
            public string key { get; set; }
            public Shadow shadow { get; set; }
            public Size size { get; set; }
        }

        public class Picture
        {
            public Default @default { get; set; }
            public Vugi6 vugi6 { get; set; }
        }

        public class VideoPlayer
        {
            public Default @default { get; set; }
        }

        public class TabPanel
        {
            public Default @default { get; set; }
        }

        public class Variant
        {
            public string file { get; set; }
            public string style { get; set; }
            public object weight { get; set; }
        }

        public class JollyGood
        {
            public string displayName { get; set; }
            public string family { get; set; }
            public string key { get; set; }
            public List<Variant> variants { get; set; }
        }

        public class Fonts
        {
            public Default @default { get; set; }
            public JollyGood jollyGood { get; set; }
        }

        public class A
        {
            public Default @default { get; set; }
        }

        public class Blockquote
        {
            public Default @default { get; set; }
        }

        public class Yysx7
        {
            public string displayName { get; set; }
            public string key { get; set; }
            public Typography typography { get; set; }
        }

        public class Body
        {
            public Default @default { get; set; }
            public Yysx7 yysx7 { get; set; }
        }

        public class H1
        {
            public Default @default { get; set; }
        }

        public class H2
        {
            public Default @default { get; set; }
        }

        public class H3
        {
            public Default @default { get; set; }
        }

        public class H4
        {
            public Default @default { get; set; }
        }

        public class H5
        {
            public Default @default { get; set; }
        }

        public class H6
        {
            public Default @default { get; set; }
        }

        public class Li
        {
            public Default @default { get; set; }
        }

        public class Ol
        {
            public Default @default { get; set; }
        }

        public class P
        {
            public Default @default { get; set; }
        }

        public class Pre
        {
            public Default @default { get; set; }
        }

        public class Ul
        {
            public Default @default { get; set; }
        }

        public class Globals
        {
            public A a { get; set; }
            public Blockquote blockquote { get; set; }
            public Body body { get; set; }
            public H1 h1 { get; set; }
            public H2 h2 { get; set; }
            public H3 h3 { get; set; }
            public H4 h4 { get; set; }
            public H5 h5 { get; set; }
            public H6 h6 { get; set; }
            public Ol ol { get; set; }
            public P p { get; set; }
            public Pre pre { get; set; }
            public Ul ul { get; set; }
        }

        public class ColorStop
        {
            public string color { get; set; }
            public string length { get; set; }
        }

        public class Gradient1
        {
            public List<ColorStop> colorStops { get; set; }
            public string direction { get; set; }
            public string displayName { get; set; }
            public string key { get; set; }
        }

        public class Gradients
        {
            public Gradient1 gradient1 { get; set; }
        }

        public class None
        {
            public string displayName { get; set; }
            public string key { get; set; }
        }

        public class Shadow1
        {
            public int blur { get; set; }
            public string color { get; set; }
            public string displayName { get; set; }
            public string key { get; set; }
            public int offsetX { get; set; }
            public int offsetY { get; set; }
            public int spread { get; set; }
        }

        public class Shadow22
        {
            public int blur { get; set; }
            public string color { get; set; }
            public string displayName { get; set; }
            public string key { get; set; }
            public int offsetX { get; set; }
            public int offsetY { get; set; }
            public int spread { get; set; }
        }

        public class Shadow32
        {
            public int blur { get; set; }
            public string color { get; set; }
            public string displayName { get; set; }
            public bool inset { get; set; }
            public string key { get; set; }
            public int offsetX { get; set; }
            public int offsetY { get; set; }
            public int spread { get; set; }
        }

        public class Shadows
        {
            public None none { get; set; }
            public Shadow shadow1 { get; set; }
            public Shadow shadow2 { get; set; }
            public Shadow shadow3 { get; set; }
        }

        public class Class
        {
            public string xs { get; set; }
            public string lg { get; set; }
            public string md { get; set; }
            public string sm { get; set; }
            public string xl { get; set; }
        }

        public class Stretch
        {
            public Class @class { get; set; }
            public string displayName { get; set; }
        }

        public class Block
        {
            public Stretch stretch { get; set; }
        }

        public class AlignHorizontallyAround
        {
            public Class @class { get; set; }
            public string displayName { get; set; }
        }

        public class AlignHorizontallyBetween
        {
            public Class @class { get; set; }
            public string displayName { get; set; }
        }

        public class AlignHorizontallyCenter
        {
            public Class @class { get; set; }
            public string displayName { get; set; }
        }

        public class AlignHorizontallyEnd
        {
            public Class @class { get; set; }
            public string displayName { get; set; }
        }

        public class AlignHorizontallyStart
        {
            public Class @class { get; set; }
            public string displayName { get; set; }
        }

        public class AlignVerticallyAround
        {
            public Class @class { get; set; }
            public string displayName { get; set; }
        }

        public class AlignVerticallyBetween
        {
            public Class @class { get; set; }
            public string displayName { get; set; }
        }

        public class AlignVerticallyCenter
        {
            public Class @class { get; set; }
            public string displayName { get; set; }
        }

        public class AlignVerticallyEnd
        {
            public Class @class { get; set; }
            public string displayName { get; set; }
        }

        public class AlignVerticallyStart
        {
            public Class @class { get; set; }
            public string displayName { get; set; }
        }

        public class Content
        {
            public AlignHorizontallyAround alignHorizontallyAround { get; set; }
            public AlignHorizontallyBetween alignHorizontallyBetween { get; set; }
            public AlignHorizontallyCenter alignHorizontallyCenter { get; set; }
            public AlignHorizontallyEnd alignHorizontallyEnd { get; set; }
            public AlignHorizontallyStart alignHorizontallyStart { get; set; }
            public AlignVerticallyAround alignVerticallyAround { get; set; }
            public AlignVerticallyBetween alignVerticallyBetween { get; set; }
            public AlignVerticallyCenter alignVerticallyCenter { get; set; }
            public AlignVerticallyEnd alignVerticallyEnd { get; set; }
            public AlignVerticallyStart alignVerticallyStart { get; set; }
            public string key { get; set; }
        }

        public class AlignCenter
        {
            public Typography typography { get; set; }
        }

        public class AlignLeft
        {
            public string displayName { get; set; }
            public Typography typography { get; set; }
        }

        public class AlignRight
        {
            public Typography typography { get; set; }
        }

        public class Justify
        {
            public Typography typography { get; set; }
        }

        public class Text
        {
            public AlignCenter alignCenter { get; set; }
            public AlignLeft alignLeft { get; set; }
            public AlignRight alignRight { get; set; }
            public Justify justify { get; set; }
            public string key { get; set; }
        }

        public class Utils
        {
            public Block block { get; set; }
            public Content content { get; set; }
            public Text text { get; set; }
        }

        public class _0303ed5fA40785dfC0ceB5915246b4f5
        {
            public string description { get; set; }
            public string downloadUrl { get; set; }
            public string fileName { get; set; }
            public string key { get; set; }
            public string keywords { get; set; }
            public string mimeType { get; set; }
            public string permalink { get; set; }
        }

        public class _2651704d31d7Bf3545d533d0968254be
        {
            public string description { get; set; }
            public string downloadUrl { get; set; }
            public string fileName { get; set; }
            public string key { get; set; }
            public string keywords { get; set; }
            public string mimeType { get; set; }
            public string permalink { get; set; }
            public string targetKey { get; set; }
        }

        public class _350b10ca9a157fbb5bc4Ea5260936803
        {
            public string description { get; set; }
            public string downloadUrl { get; set; }
            public string fileName { get; set; }
            public string key { get; set; }
            public string keywords { get; set; }
            public string mimeType { get; set; }
            public string permalink { get; set; }
            public string targetKey { get; set; }
        }

        public class _50c850db1592Cd5e4327A68802e5826a
        {
            public string description { get; set; }
            public string downloadUrl { get; set; }
            public string fileName { get; set; }
            public string key { get; set; }
            public string keywords { get; set; }
            public string mimeType { get; set; }
            public string permalink { get; set; }
        }

        public class _5b2274e2Dc59Ff5e6cee5cd20d4e0c31
        {
            public string description { get; set; }
            public string downloadUrl { get; set; }
            public string fileName { get; set; }
            public string key { get; set; }
            public string keywords { get; set; }
            public string mimeType { get; set; }
            public string permalink { get; set; }
        }

        public class _5b9a572c5ede0da11ffaF2ce06ba0fae
        {
            public string description { get; set; }
            public string downloadUrl { get; set; }
            public string fileName { get; set; }
            public string key { get; set; }
            public string keywords { get; set; }
            public string mimeType { get; set; }
            public string permalink { get; set; }
            public string targetKey { get; set; }
        }

        public class _68aa54b59780B1ed6020Fbcb7933dc26
        {
            public string description { get; set; }
            public string downloadUrl { get; set; }
            public string fileName { get; set; }
            public string key { get; set; }
            public string keywords { get; set; }
            public string mimeType { get; set; }
            public string permalink { get; set; }
            public string targetKey { get; set; }
        }

        public class _6e91daccA34c0806C6068ec2533b14d8
        {
            public string description { get; set; }
            public string downloadUrl { get; set; }
            public string fileName { get; set; }
            public string key { get; set; }
            public string keywords { get; set; }
            public string mimeType { get; set; }
            public string permalink { get; set; }
        }

        public class _6ed3bd244cd49bfc48dc97f62a762e02
        {
            public string description { get; set; }
            public string downloadUrl { get; set; }
            public string fileName { get; set; }
            public string key { get; set; }
            public string keywords { get; set; }
            public string mimeType { get; set; }
            public string permalink { get; set; }
        }

        public class _80df9db7B08872705011D97535d630df
        {
            public string description { get; set; }
            public string downloadUrl { get; set; }
            public string fileName { get; set; }
            public string key { get; set; }
            public string keywords { get; set; }
            public string mimeType { get; set; }
            public string permalink { get; set; }
        }

        public class _88238d72237dEefcDa3e19bef9506808
        {
            public string description { get; set; }
            public string downloadUrl { get; set; }
            public string fileName { get; set; }
            public string key { get; set; }
            public string keywords { get; set; }
            public string mimeType { get; set; }
            public string permalink { get; set; }
        }

        public class _899148eb84c54aa140ca63d188a619cc
        {
            public string description { get; set; }
            public string downloadUrl { get; set; }
            public string fileName { get; set; }
            public string key { get; set; }
            public string keywords { get; set; }
            public string mimeType { get; set; }
            public string permalink { get; set; }
        }

        public class _8b7bdb015ea33b397a216f32e6f58bf0
        {
            public string description { get; set; }
            public string downloadUrl { get; set; }
            public string fileName { get; set; }
            public string key { get; set; }
            public string keywords { get; set; }
            public string mimeType { get; set; }
            public string permalink { get; set; }
        }

        public class _8c5cf5763212Ab064144464338e020ad
        {
            public string description { get; set; }
            public string downloadUrl { get; set; }
            public string fileName { get; set; }
            public string key { get; set; }
            public string keywords { get; set; }
            public string mimeType { get; set; }
            public string permalink { get; set; }
        }

        public class _92c8f9aaE2d17a731cdd1b9e39ba41e4
        {
            public string description { get; set; }
            public string downloadUrl { get; set; }
            public string fileName { get; set; }
            public string key { get; set; }
            public string keywords { get; set; }
            public string mimeType { get; set; }
            public string permalink { get; set; }
        }

        public class AdfbffadAc01Ed54Fbe06253d0c663fd
        {
            public string description { get; set; }
            public string downloadUrl { get; set; }
            public string fileName { get; set; }
            public string key { get; set; }
            public string keywords { get; set; }
            public string mimeType { get; set; }
            public string permalink { get; set; }
        }

        public class Bf5f5a14Fad72e5c9ad39750d3212648
        {
            public string description { get; set; }
            public string downloadUrl { get; set; }
            public string fileName { get; set; }
            public string key { get; set; }
            public string keywords { get; set; }
            public string mimeType { get; set; }
            public string permalink { get; set; }
        }

        public class C451c91e2e8f7fc92373Ae8ef9f0f154
        {
            public string description { get; set; }
            public string downloadUrl { get; set; }
            public string fileName { get; set; }
            public string key { get; set; }
            public string keywords { get; set; }
            public string mimeType { get; set; }
            public string permalink { get; set; }
        }

        public class Cc3b22afB12a716c366666971360eb09
        {
            public string description { get; set; }
            public string downloadUrl { get; set; }
            public string fileName { get; set; }
            public string key { get; set; }
            public string keywords { get; set; }
            public string mimeType { get; set; }
            public string permalink { get; set; }
        }

        public class F0b568bf703a0fa558b05b4574b18b93
        {
            public string description { get; set; }
            public string downloadUrl { get; set; }
            public string fileName { get; set; }
            public string key { get; set; }
            public string keywords { get; set; }
            public string mimeType { get; set; }
            public string permalink { get; set; }
        }

        public class F4f94aa8269b9d08424707981b8476c3
        {
            public string description { get; set; }
            public string downloadUrl { get; set; }
            public string fileName { get; set; }
            public string key { get; set; }
            public string keywords { get; set; }
            public string mimeType { get; set; }
            public string permalink { get; set; }
        }

        public class Uploads
        {
            [JsonProperty("0303ed5f-a407-85df-c0ce-b5915246b4f5")]
            public _0303ed5fA40785dfC0ceB5915246b4f5 _0303ed5fA40785dfC0ceB5915246b4f5 { get; set; }

            [JsonProperty("2651704d-31d7-bf35-45d5-33d0968254be")]
            public _2651704d31d7Bf3545d533d0968254be _2651704d31d7Bf3545d533d0968254be { get; set; }

            [JsonProperty("350b10ca-9a15-7fbb-5bc4-ea5260936803")]
            public _350b10ca9a157fbb5bc4Ea5260936803 _350b10ca9a157fbb5bc4Ea5260936803 { get; set; }

            [JsonProperty("50c850db-1592-cd5e-4327-a68802e5826a")]
            public _50c850db1592Cd5e4327A68802e5826a _50c850db1592Cd5e4327A68802e5826a { get; set; }

            [JsonProperty("5b2274e2-dc59-ff5e-6cee-5cd20d4e0c31")]
            public _5b2274e2Dc59Ff5e6cee5cd20d4e0c31 _5b2274e2Dc59Ff5e6cee5cd20d4e0c31 { get; set; }

            [JsonProperty("5b9a572c-5ede-0da1-1ffa-f2ce06ba0fae")]
            public _5b9a572c5ede0da11ffaF2ce06ba0fae _5b9a572c5ede0da11ffaF2ce06ba0fae { get; set; }

            [JsonProperty("68aa54b5-9780-b1ed-6020-fbcb7933dc26")]
            public _68aa54b59780B1ed6020Fbcb7933dc26 _68aa54b59780B1ed6020Fbcb7933dc26 { get; set; }

            [JsonProperty("6e91dacc-a34c-0806-c606-8ec2533b14d8")]
            public _6e91daccA34c0806C6068ec2533b14d8 _6e91daccA34c0806C6068ec2533b14d8 { get; set; }

            [JsonProperty("6ed3bd24-4cd4-9bfc-48dc-97f62a762e02")]
            public _6ed3bd244cd49bfc48dc97f62a762e02 _6ed3bd244cd49bfc48dc97f62a762e02 { get; set; }

            [JsonProperty("80df9db7-b088-7270-5011-d97535d630df")]
            public _80df9db7B08872705011D97535d630df _80df9db7B08872705011D97535d630df { get; set; }

            [JsonProperty("88238d72-237d-eefc-da3e-19bef9506808")]
            public _88238d72237dEefcDa3e19bef9506808 _88238d72237dEefcDa3e19bef9506808 { get; set; }

            [JsonProperty("899148eb-84c5-4aa1-40ca-63d188a619cc")]
            public _899148eb84c54aa140ca63d188a619cc _899148eb84c54aa140ca63d188a619cc { get; set; }

            [JsonProperty("8b7bdb01-5ea3-3b39-7a21-6f32e6f58bf0")]
            public _8b7bdb015ea33b397a216f32e6f58bf0 _8b7bdb015ea33b397a216f32e6f58bf0 { get; set; }

            [JsonProperty("8c5cf576-3212-ab06-4144-464338e020ad")]
            public _8c5cf5763212Ab064144464338e020ad _8c5cf5763212Ab064144464338e020ad { get; set; }

            [JsonProperty("92c8f9aa-e2d1-7a73-1cdd-1b9e39ba41e4")]
            public _92c8f9aaE2d17a731cdd1b9e39ba41e4 _92c8f9aaE2d17a731cdd1b9e39ba41e4 { get; set; }

            [JsonProperty("adfbffad-ac01-ed54-fbe0-6253d0c663fd")]
            public AdfbffadAc01Ed54Fbe06253d0c663fd AdfbffadAc01Ed54Fbe06253d0c663fd { get; set; }

            [JsonProperty("bf5f5a14-fad7-2e5c-9ad3-9750d3212648")]
            public Bf5f5a14Fad72e5c9ad39750d3212648 Bf5f5a14Fad72e5c9ad39750d3212648 { get; set; }

            [JsonProperty("c451c91e-2e8f-7fc9-2373-ae8ef9f0f154")]
            public C451c91e2e8f7fc92373Ae8ef9f0f154 C451c91e2e8f7fc92373Ae8ef9f0f154 { get; set; }

            [JsonProperty("cc3b22af-b12a-716c-3666-66971360eb09")]
            public Cc3b22afB12a716c366666971360eb09 Cc3b22afB12a716c366666971360eb09 { get; set; }

            [JsonProperty("f0b568bf-703a-0fa5-58b0-5b4574b18b93")]
            public F0b568bf703a0fa558b05b4574b18b93 F0b568bf703a0fa558b05b4574b18b93 { get; set; }

            [JsonProperty("f4f94aa8-269b-9d08-4247-07981b8476c3")]
            public F4f94aa8269b9d08424707981b8476c3 F4f94aa8269b9d08424707981b8476c3 { get; set; }
        }

        public class _031c7b4e49680975568fE5717fa05847
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class _05faa2cfEb8482fbA8beBf9e8a3a9fca
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class _0d5dd998A89c457dB33088c0d9205d81
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class _119909aaBc64245fEb554f841706f146
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class _20fc3ba515faAca7Ce439a226d11d3bc
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class _216085d3B6110d359ff202cd00aba6f2
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class _21d050c7015a0dc660f1F0fc66330c25
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class _2a1937bc2b6cEeb06276094ab9ba6af2
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class _33a6f86eBca305c7F2846e2c5e6abe3b
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class _4468cab0145500f0Bf70C006cee337c9
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class _45dba6c91fc8Db9d9bfaB5462dfee0ff
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class _4a0ebab0F605E452F546E94a5a3860c4
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class _5bd8f50b997bC014322c928541b22ae9
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class _66142f30E65f9bf60af93edfb26eb17f
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class _680ed39707df5554790bAcbd11090b4e
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class _6f6d6de643218ea1E9c7Aca1b713db9e
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class _71c1e85b7796F1719126A4725c67b7f9
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class _752114a6F84f22ca18a93740b0c8a6f2
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class _757bdcf0723797475368974f180fb33b
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class _7e33e9798a6d3834C6058d60d18e3d11
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class _82e518bc31447fd0Aa609b10341077e3
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class _95a89e302da7389d87c349211c4dc410
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class A5f45d50D599F004Aa754b21fa0af19a
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class A83d9114D34d7122693a7485a2b8ecce
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class Aad6187b08cbD1abD373C19ae9686efb
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class C59fcf7fFb277c2708b561684e11912d
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class C80d81c85213Fef945aaBd0d905ab4dd
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class C98dbd9f3c0fEba8Fbeb49216da7ee56
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class C9a948dcCcbc68149a1009b8c5716631
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class Ca48a393De5e1cdc6d7f27d67aa054f9
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class Cb2589a7Dae0E6386e156bbb13a26613
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class Cbb8f258C82549e0A40851502402159a
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class E7da07b8D303A860Acc79a01ea87e88a
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class Eb25e97cBf4fC4c9F4177ea0292badc6
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class Ef640d0c26778c30A0baE2abb3eb2964
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class F823df285901Ebbf2259Aa2bf2cbefeb
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class F93c17335991438c9af3885d7a91988f
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class Ff5773098e84218d04781a3283713ae7
        {
            public string key { get; set; }
            public string permalink { get; set; }
            public string title { get; set; }
        }

        public class Urls
        {
            [JsonProperty("031c7b4e-4968-0975-568f-e5717fa05847")]
            public _031c7b4e49680975568fE5717fa05847 _031c7b4e49680975568fE5717fa05847 { get; set; }

            [JsonProperty("05faa2cf-eb84-82fb-a8be-bf9e8a3a9fca")]
            public _05faa2cfEb8482fbA8beBf9e8a3a9fca _05faa2cfEb8482fbA8beBf9e8a3a9fca { get; set; }

            [JsonProperty("0d5dd998-a89c-457d-b330-88c0d9205d81")]
            public _0d5dd998A89c457dB33088c0d9205d81 _0d5dd998A89c457dB33088c0d9205d81 { get; set; }

            [JsonProperty("119909aa-bc64-245f-eb55-4f841706f146")]
            public _119909aaBc64245fEb554f841706f146 _119909aaBc64245fEb554f841706f146 { get; set; }

            [JsonProperty("20fc3ba5-15fa-aca7-ce43-9a226d11d3bc")]
            public _20fc3ba515faAca7Ce439a226d11d3bc _20fc3ba515faAca7Ce439a226d11d3bc { get; set; }

            [JsonProperty("216085d3-b611-0d35-9ff2-02cd00aba6f2")]
            public _216085d3B6110d359ff202cd00aba6f2 _216085d3B6110d359ff202cd00aba6f2 { get; set; }

            [JsonProperty("21d050c7-015a-0dc6-60f1-f0fc66330c25")]
            public _21d050c7015a0dc660f1F0fc66330c25 _21d050c7015a0dc660f1F0fc66330c25 { get; set; }

            [JsonProperty("2a1937bc-2b6c-eeb0-6276-094ab9ba6af2")]
            public _2a1937bc2b6cEeb06276094ab9ba6af2 _2a1937bc2b6cEeb06276094ab9ba6af2 { get; set; }

            [JsonProperty("33a6f86e-bca3-05c7-f284-6e2c5e6abe3b")]
            public _33a6f86eBca305c7F2846e2c5e6abe3b _33a6f86eBca305c7F2846e2c5e6abe3b { get; set; }

            [JsonProperty("4468cab0-1455-00f0-bf70-c006cee337c9")]
            public _4468cab0145500f0Bf70C006cee337c9 _4468cab0145500f0Bf70C006cee337c9 { get; set; }

            [JsonProperty("45dba6c9-1fc8-db9d-9bfa-b5462dfee0ff")]
            public _45dba6c91fc8Db9d9bfaB5462dfee0ff _45dba6c91fc8Db9d9bfaB5462dfee0ff { get; set; }

            [JsonProperty("4a0ebab0-f605-e452-f546-e94a5a3860c4")]
            public _4a0ebab0F605E452F546E94a5a3860c4 _4a0ebab0F605E452F546E94a5a3860c4 { get; set; }

            [JsonProperty("5bd8f50b-997b-c014-322c-928541b22ae9")]
            public _5bd8f50b997bC014322c928541b22ae9 _5bd8f50b997bC014322c928541b22ae9 { get; set; }

            [JsonProperty("66142f30-e65f-9bf6-0af9-3edfb26eb17f")]
            public _66142f30E65f9bf60af93edfb26eb17f _66142f30E65f9bf60af93edfb26eb17f { get; set; }

            [JsonProperty("680ed397-07df-5554-790b-acbd11090b4e")]
            public _680ed39707df5554790bAcbd11090b4e _680ed39707df5554790bAcbd11090b4e { get; set; }

            [JsonProperty("6f6d6de6-4321-8ea1-e9c7-aca1b713db9e")]
            public _6f6d6de643218ea1E9c7Aca1b713db9e _6f6d6de643218ea1E9c7Aca1b713db9e { get; set; }

            [JsonProperty("71c1e85b-7796-f171-9126-a4725c67b7f9")]
            public _71c1e85b7796F1719126A4725c67b7f9 _71c1e85b7796F1719126A4725c67b7f9 { get; set; }

            [JsonProperty("752114a6-f84f-22ca-18a9-3740b0c8a6f2")]
            public _752114a6F84f22ca18a93740b0c8a6f2 _752114a6F84f22ca18a93740b0c8a6f2 { get; set; }

            [JsonProperty("757bdcf0-7237-9747-5368-974f180fb33b")]
            public _757bdcf0723797475368974f180fb33b _757bdcf0723797475368974f180fb33b { get; set; }

            [JsonProperty("7e33e979-8a6d-3834-c605-8d60d18e3d11")]
            public _7e33e9798a6d3834C6058d60d18e3d11 _7e33e9798a6d3834C6058d60d18e3d11 { get; set; }

            [JsonProperty("82e518bc-3144-7fd0-aa60-9b10341077e3")]
            public _82e518bc31447fd0Aa609b10341077e3 _82e518bc31447fd0Aa609b10341077e3 { get; set; }

            [JsonProperty("95a89e30-2da7-389d-87c3-49211c4dc410")]
            public _95a89e302da7389d87c349211c4dc410 _95a89e302da7389d87c349211c4dc410 { get; set; }

            [JsonProperty("a5f45d50-d599-f004-aa75-4b21fa0af19a")]
            public A5f45d50D599F004Aa754b21fa0af19a A5f45d50D599F004Aa754b21fa0af19a { get; set; }

            [JsonProperty("a83d9114-d34d-7122-693a-7485a2b8ecce")]
            public A83d9114D34d7122693a7485a2b8ecce A83d9114D34d7122693a7485a2b8ecce { get; set; }

            [JsonProperty("aad6187b-08cb-d1ab-d373-c19ae9686efb")]
            public Aad6187b08cbD1abD373C19ae9686efb Aad6187b08cbD1abD373C19ae9686efb { get; set; }

            [JsonProperty("c59fcf7f-fb27-7c27-08b5-61684e11912d")]
            public C59fcf7fFb277c2708b561684e11912d C59fcf7fFb277c2708b561684e11912d { get; set; }

            [JsonProperty("c80d81c8-5213-fef9-45aa-bd0d905ab4dd")]
            public C80d81c85213Fef945aaBd0d905ab4dd C80d81c85213Fef945aaBd0d905ab4dd { get; set; }

            [JsonProperty("c98dbd9f-3c0f-eba8-fbeb-49216da7ee56")]
            public C98dbd9f3c0fEba8Fbeb49216da7ee56 C98dbd9f3c0fEba8Fbeb49216da7ee56 { get; set; }

            [JsonProperty("c9a948dc-ccbc-6814-9a10-09b8c5716631")]
            public C9a948dcCcbc68149a1009b8c5716631 C9a948dcCcbc68149a1009b8c5716631 { get; set; }

            [JsonProperty("ca48a393-de5e-1cdc-6d7f-27d67aa054f9")]
            public Ca48a393De5e1cdc6d7f27d67aa054f9 Ca48a393De5e1cdc6d7f27d67aa054f9 { get; set; }

            [JsonProperty("cb2589a7-dae0-e638-6e15-6bbb13a26613")]
            public Cb2589a7Dae0E6386e156bbb13a26613 Cb2589a7Dae0E6386e156bbb13a26613 { get; set; }

            [JsonProperty("cbb8f258-c825-49e0-a408-51502402159a")]
            public Cbb8f258C82549e0A40851502402159a Cbb8f258C82549e0A40851502402159a { get; set; }

            [JsonProperty("e7da07b8-d303-a860-acc7-9a01ea87e88a")]
            public E7da07b8D303A860Acc79a01ea87e88a E7da07b8D303A860Acc79a01ea87e88a { get; set; }

            [JsonProperty("eb25e97c-bf4f-c4c9-f417-7ea0292badc6")]
            public Eb25e97cBf4fC4c9F4177ea0292badc6 Eb25e97cBf4fC4c9F4177ea0292badc6 { get; set; }

            [JsonProperty("ef640d0c-2677-8c30-a0ba-e2abb3eb2964")]
            public Ef640d0c26778c30A0baE2abb3eb2964 Ef640d0c26778c30A0baE2abb3eb2964 { get; set; }

            [JsonProperty("f823df28-5901-ebbf-2259-aa2bf2cbefeb")]
            public F823df285901Ebbf2259Aa2bf2cbefeb F823df285901Ebbf2259Aa2bf2cbefeb { get; set; }

            [JsonProperty("f93c1733-5991-438c-9af3-885d7a91988f")]
            public F93c17335991438c9af3885d7a91988f F93c17335991438c9af3885d7a91988f { get; set; }

            [JsonProperty("ff577309-8e84-218d-0478-1a3283713ae7")]
            public Ff5773098e84218d04781a3283713ae7 Ff5773098e84218d04781a3283713ae7 { get; set; }
        }

        public class Blobs
        {
        }

        public class Popups
        {
            [JsonProperty("e7fe8cfe-9e88-fbcd-08aa-21a45e916ea2")]
            public E7fe8cfe9e88Fbcd08aa21a45e916ea2 E7fe8cfe9e88Fbcd08aa21a45e916ea2 { get; set; }
        }
    }
}
