using HtmlAgilityPack;
using Scrapping.AllPossibilities.Enums;
using Attribute = Scrapping.AllPossibilities.Enums.Attribute;

namespace Scrapping.AllPossibilities
{
    public static class HtmlDocumentHelper
    {
        public static HtmlNode GetNodeByParams(HtmlNode htmlNode, string tagName, string attributeName, string attributeValue)
        {
            return htmlNode.SelectSingleNode($".//{tagName}[@{attributeName}={attributeValue}]");
        }

        public static HtmlNode GetNodeByParams(HtmlNode htmlNode, Tag tag, string attributeName, string attributeValue)
        {
            return GetNodeByParams(htmlNode, tag.ToString(), attributeName, attributeValue);
        }
        public static HtmlNode GetNodeByParams(HtmlNode htmlNode, Tag tag, Attribute attribute, string attributeValue)
        {
            return GetNodeByParams(htmlNode, tag.ToString(), attribute.ToString().Replace("_", ""), attributeValue);
        }




        public static HtmlNodeCollection GetNodesByParams(HtmlNode htmlNode, string tagName, string attributeName, string attributeValue)
        {
            return htmlNode.SelectNodes($".//{tagName}[@{attributeName}={attributeValue}]");
        }

        public static HtmlNodeCollection GetNodesByParams(HtmlNode htmlNode, Tag tag, string attributeName, string attributeValue)
        {
            return GetNodesByParams(htmlNode, tag.ToString(), attributeName, attributeValue);
        }
        public static HtmlNodeCollection GetNodesByParams(HtmlNode htmlNode, Tag tag, Attribute attribute, string attributeValue)
        {
            return GetNodesByParams(htmlNode, tag.ToString(), attribute.ToString().Replace("_", ""), attributeValue);
        }





        public static HtmlNode GetNodeByParamsByAttrValueContains(HtmlNode htmlNode, string tagName, string attributeName, string attributeValue)
        {
            return htmlNode.SelectSingleNode($".//{tagName}[contains(@{attributeName},{attributeValue})]");
        }
        public static HtmlNode GetNodeByParamsByAttrValueContains(HtmlNode htmlNode, Tag tag, string attributeName, string attributeValue)
        {
            return GetNodeByParamsByAttrValueContains(htmlNode, tag.ToString(), attributeName, attributeValue);
        }
        public static HtmlNode GetNodeByParamsByAttrValueContains(HtmlNode htmlNode, Tag tag, Attribute attribute, string attributeValue)
        {
            return GetNodeByParamsByAttrValueContains(htmlNode, tag.ToString(), attribute.ToString().Replace("_",""), attributeValue);
        }




        public static HtmlNodeCollection GetNodesByParamsByAttrValueContains(HtmlNode htmlNode, string tagName, string attributeName, string attributeValue)
        {
            return htmlNode.SelectNodes($".//{tagName}[contains(@{attributeName},{attributeValue})]");
        }
        public static HtmlNodeCollection GetNodesByParamsByAttrValueContains(HtmlNode htmlNode, Tag tag, string attributeName, string attributeValue)
        {
            return GetNodesByParamsByAttrValueContains(htmlNode, tag.ToString(), attributeName, attributeValue);
        }
        public static HtmlNodeCollection GetNodesByParamsByAttrValueContains(HtmlNode htmlNode, Tag tag, Attribute attribute, string attributeValue)
        {
            return GetNodesByParamsByAttrValueContains(htmlNode, tag.ToString(), attribute.ToString().Replace("_",""), attributeValue);
        }
    }
}
