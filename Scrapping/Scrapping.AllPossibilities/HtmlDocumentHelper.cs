using HtmlAgilityPack;
using Scrapping.AllPossibilities.Enums;
using Attribute = Scrapping.AllPossibilities.Enums.Attribute;

namespace Scrapping.AllPossibilities
{
    public static class HtmlDocumentHelper
    {
        /// <summary>
        /// GetNodeByParams
        /// </summary>
        /// <param name="htmlNode">Agility node</param>
        /// <param name="tagName">HTML tag name by string</param>
        /// <param name="attributeName">HTML attribute name by string</param>
        /// <param name="attributeValue">attribute value</param>
        /// <returns></returns>
        public static HtmlNode GetNodeByParams(HtmlNode htmlNode, string tagName, string attributeName, string attributeValue)
        {
            return htmlNode.SelectSingleNode($".//{tagName}[@{attributeName}={attributeValue}]");
        }

        /// <summary>
        /// GetNodeByParams
        /// </summary>
        /// <param name="htmlNode">Agility node</param>
        /// <param name="tag">HTML tag name by Tag enum</param>
        /// <param name="attributeName">HTML attribute name by string</param>
        /// <param name="attributeValue">attribute value</param>
        /// <returns></returns>
        public static HtmlNode GetNodeByParams(HtmlNode htmlNode, Tag tag, string attributeName, string attributeValue)
        {
            return GetNodeByParams(htmlNode, tag.ToString(), attributeName, attributeValue);
        }

        /// <summary>
        /// GetNodeByParams
        /// </summary>
        /// <param name="htmlNode">Agility node</param>
        /// <param name="tag">HTML tag name by Tag enum</param>
        /// <param name="attribute">HTML attribute name by Attribute enum</param>
        /// <param name="attributeValue">attribute value</param>
        /// <returns></returns>
        public static HtmlNode GetNodeByParams(HtmlNode htmlNode, Tag tag, Attribute attribute, string attributeValue)
        {
            return GetNodeByParams(htmlNode, tag.ToString(), attribute.ToString().Replace("_", ""), attributeValue);
        }



        /// <summary>
        /// GetNodesByParams
        /// </summary>
        /// <param name="htmlNode">Agility node</param>
        /// <param name="tagName">HTML tag name by string</param>
        /// <param name="attributeName">HTML attribute name by string</param>
        /// <param name="attributeValue">attribute value</param>
        /// <returns></returns>
        public static HtmlNodeCollection GetNodesByParams(HtmlNode htmlNode, string tagName, string attributeName, string attributeValue)
        {
            return htmlNode.SelectNodes($".//{tagName}[@{attributeName}={attributeValue}]");
        }

        /// <summary>
        /// GetNodesByParams
        /// </summary>
        /// <param name="htmlNode">Agility node</param>
        /// <param name="tag">HTML tag name by Tag enum</param>
        /// <param name="attributeName">HTML attribute name by string</param>
        /// <param name="attributeValue">attribute value</param>
        /// <returns></returns>
        public static HtmlNodeCollection GetNodesByParams(HtmlNode htmlNode, Tag tag, string attributeName, string attributeValue)
        {
            return GetNodesByParams(htmlNode, tag.ToString(), attributeName, attributeValue);
        }

        /// <summary>
        /// GetNodesByParams
        /// </summary>
        /// <param name="htmlNode">Agility node</param>
        /// <param name="tag">HTML tag name by Tag enum</param>
        /// <param name="attribute">HTML attribute name by Attribute enum</param>
        /// <param name="attributeValue">attribute value</param>
        /// <returns></returns>
        public static HtmlNodeCollection GetNodesByParams(HtmlNode htmlNode, Tag tag, Attribute attribute, string attributeValue)
        {
            return GetNodesByParams(htmlNode, tag.ToString(), attribute.ToString().Replace("_", ""), attributeValue);
        }


        /// <summary>
        /// GetNodeByParamsByAttrValueContains
        /// </summary>
        /// <param name="htmlNode">Agility node</param>
        /// <param name="tagName">HTML tag name by string</param>
        /// <param name="attributeName">HTML attribute name by string</param>
        /// <param name="attributeValue">attribute value</param>
        /// <returns></returns>
        public static HtmlNode GetNodeByParamsByAttrValueContains(HtmlNode htmlNode, string tagName, string attributeName, string attributeValue)
        {
            return htmlNode.SelectSingleNode($".//{tagName}[contains(@{attributeName},{attributeValue})]");
        }

        /// <summary>
        /// GetNodeByParamsByAttrValueContains
        /// </summary>
        /// <param name="htmlNode">Agility node</param>
        /// <param name="tag">HTML tag name by Tag enum</param>
        /// <param name="attributeName">HTML attribute name by string</param>
        /// <param name="attributeValue">attribute value</param>
        /// <returns></returns>
        public static HtmlNode GetNodeByParamsByAttrValueContains(HtmlNode htmlNode, Tag tag, string attributeName, string attributeValue)
        {
            return GetNodeByParamsByAttrValueContains(htmlNode, tag.ToString(), attributeName, attributeValue);
        }

        /// <summary>
        /// GetNodeByParamsByAttrValueContains
        /// </summary>
        /// <param name="htmlNode"></param>
        /// <param name="tag"></param>
        /// <param name="attribute"></param>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        public static HtmlNode GetNodeByParamsByAttrValueContains(HtmlNode htmlNode, Tag tag, Attribute attribute, string attributeValue)
        {
            return GetNodeByParamsByAttrValueContains(htmlNode, tag.ToString(), attribute.ToString().Replace("_",""), attributeValue);
        }


        /// <summary>
        /// GetNodesByParamsByAttrValueContains
        /// </summary>
        /// <param name="htmlNode">Agility node</param>
        /// <param name="tagName">HTML tag name by string</param>
        /// <param name="attributeName">HTML attribute name by string</param>
        /// <param name="attributeValue">attribute value</param>
        /// <returns></returns>
        public static HtmlNodeCollection GetNodesByParamsByAttrValueContains(HtmlNode htmlNode, string tagName, string attributeName, string attributeValue)
        {
            return htmlNode.SelectNodes($".//{tagName}[contains(@{attributeName},{attributeValue})]");
        }

        /// <summary>
        /// GetNodesByParamsByAttrValueContains
        /// </summary>
        /// <param name="htmlNode">Agility node</param>
        /// <param name="tag">HTML tag name by Tag enum</param>
        /// <param name="attributeName">HTML attribute name by string</param>
        /// <param name="attributeValue">attribute value</param>
        /// <returns></returns>
        public static HtmlNodeCollection GetNodesByParamsByAttrValueContains(HtmlNode htmlNode, Tag tag, string attributeName, string attributeValue)
        {
            return GetNodesByParamsByAttrValueContains(htmlNode, tag.ToString(), attributeName, attributeValue);
        }

        /// <summary>
        /// GetNodesByParamsByAttrValueContains
        /// </summary>
        /// <param name="htmlNode">Agility node</param>
        /// <param name="tag">HTML tag name by Tag enum</param>
        /// <param name="attribute">HTML attribute name by Attribute enum</param>
        /// <param name="attributeValue">attribute value</param>
        /// <returns></returns>
        public static HtmlNodeCollection GetNodesByParamsByAttrValueContains(HtmlNode htmlNode, Tag tag, Attribute attribute, string attributeValue)
        {
            return GetNodesByParamsByAttrValueContains(htmlNode, tag.ToString(), attribute.ToString().Replace("_",""), attributeValue);
        }
    }
}
