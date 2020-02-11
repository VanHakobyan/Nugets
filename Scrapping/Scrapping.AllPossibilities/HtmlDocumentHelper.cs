using HtmlAgilityPack;
using Scrapping.AllPossibilities.Enums;
using HtmlAttribute = Scrapping.AllPossibilities.Enums.HtmlAttribute;

namespace Scrapping.AllPossibilities
{
    public static class HtmlDocumentHelper
    {
        #region ByXpath=

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
            return htmlNode.SelectSingleNode($".//{tagName}[@{attributeName}='{attributeValue}']");
        }

        /// <summary>
        /// GetNodeByParams
        /// </summary>
        /// <param name="htmlNode">Agility node</param>
        /// <param name="htmlTag">HTML tag name by Tag enum</param>
        /// <param name="attributeName">HTML attribute name by string</param>
        /// <param name="attributeValue">attribute value</param>
        /// <returns></returns>
        public static HtmlNode GetNodeByParams(HtmlNode htmlNode, HtmlTag htmlTag, string attributeName, string attributeValue)
        {
            return GetNodeByParams(htmlNode, htmlTag.ToString(), attributeName, attributeValue);
        }

        /// <summary>
        /// GetNodeByParams
        /// </summary>
        /// <param name="htmlNode">Agility node</param>
        /// <param name="htmlTag">HTML tag name by Tag enum</param>
        /// <param name="htmlAttribute">HTML attribute name by Attribute enum</param>
        /// <param name="attributeValue">attribute value</param>
        /// <returns></returns>
        public static HtmlNode GetNodeByParams(HtmlNode htmlNode, HtmlTag htmlTag, HtmlAttribute htmlAttribute, string attributeValue)
        {
            return GetNodeByParams(htmlNode, htmlTag.ToString(), htmlAttribute.ToString().Replace("_", ""), attributeValue);
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
            return htmlNode.SelectNodes($".//{tagName}[@{attributeName}='{attributeValue}']");
        }

        /// <summary>
        /// GetNodesByParams
        /// </summary>
        /// <param name="htmlNode">Agility node</param>
        /// <param name="htmlTag">HTML tag name by Tag enum</param>
        /// <param name="attributeName">HTML attribute name by string</param>
        /// <param name="attributeValue">attribute value</param>
        /// <returns></returns>
        public static HtmlNodeCollection GetNodesByParams(HtmlNode htmlNode, HtmlTag htmlTag, string attributeName, string attributeValue)
        {
            return GetNodesByParams(htmlNode, htmlTag.ToString(), attributeName, attributeValue);
        }

        /// <summary>
        /// GetNodesByParams
        /// </summary>
        /// <param name="htmlNode">Agility node</param>
        /// <param name="htmlTag">HTML tag name by Tag enum</param>
        /// <param name="htmlAttribute">HTML attribute name by Attribute enum</param>
        /// <param name="attributeValue">attribute value</param>
        /// <returns></returns>
        public static HtmlNodeCollection GetNodesByParams(HtmlNode htmlNode, HtmlTag htmlTag, HtmlAttribute htmlAttribute, string attributeValue)
        {
            return GetNodesByParams(htmlNode, htmlTag.ToString(), htmlAttribute.ToString().Replace("_", ""), attributeValue);
        }

        #endregion

        #region ByXpathContains
        /// <summary>
        /// GetNodeByParamsByAttrValueContains
        /// </summary>
        /// <param name="htmlNode">Agility node</param>
        /// <param name="tagName">HTML tag name by string</param>
        /// <param name="attributeName">HTML attribute name by string</param>
        /// <param name="attributeValue">attribute value</param>
        /// <returns></returns>
        public static HtmlNode GetNodeByParamsUseXpathContains(HtmlNode htmlNode, string tagName, string attributeName, string attributeValue)
        {
            return htmlNode.SelectSingleNode($".//{tagName}[contains(@{attributeName},'{attributeValue}')]");
        }

        /// <summary>
        /// GetNodeByParamsByAttrValueContains
        /// </summary>
        /// <param name="htmlNode">Agility node</param>
        /// <param name="htmlTag">HTML tag name by Tag enum</param>
        /// <param name="attributeName">HTML attribute name by string</param>
        /// <param name="attributeValue">attribute value</param>
        /// <returns></returns>
        public static HtmlNode GetNodeByParamsUseXpathContains(HtmlNode htmlNode, HtmlTag htmlTag, string attributeName, string attributeValue)
        {
            return GetNodeByParamsUseXpathContains(htmlNode, htmlTag.ToString(), attributeName, attributeValue);
        }

        /// <summary>
        /// GetNodeByParamsByAttrValueContains
        /// </summary>
        /// <param name="htmlNode"></param>
        /// <param name="htmlTag"></param>
        /// <param name="htmlAttribute"></param>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        public static HtmlNode GetNodeByParamsUseXpathContains(HtmlNode htmlNode, HtmlTag htmlTag, HtmlAttribute htmlAttribute, string attributeValue)
        {
            return GetNodeByParamsUseXpathContains(htmlNode, htmlTag.ToString(), htmlAttribute.ToString().Replace("_", ""), attributeValue);
        }


        /// <summary>
        /// GetNodesByParamsByAttrValueContains
        /// </summary>
        /// <param name="htmlNode">Agility node</param>
        /// <param name="tagName">HTML tag name by string</param>
        /// <param name="attributeName">HTML attribute name by string</param>
        /// <param name="attributeValue">attribute value</param>
        /// <returns></returns>
        public static HtmlNodeCollection GetNodesByParamsUseXpathContains(HtmlNode htmlNode, string tagName, string attributeName, string attributeValue)
        {
            return htmlNode.SelectNodes($".//{tagName}[contains(@{attributeName},'{attributeValue}')]");
        }

        /// <summary>
        /// GetNodesByParamsByAttrValueContains
        /// </summary>
        /// <param name="htmlNode">Agility node</param>
        /// <param name="htmlTag">HTML tag name by Tag enum</param>
        /// <param name="attributeName">HTML attribute name by string</param>
        /// <param name="attributeValue">attribute value</param>
        /// <returns></returns>
        public static HtmlNodeCollection GetNodesByParamsUseXpathContains(HtmlNode htmlNode, HtmlTag htmlTag, string attributeName, string attributeValue)
        {
            return GetNodesByParamsUseXpathContains(htmlNode, htmlTag.ToString(), attributeName, attributeValue);
        }

        /// <summary>
        /// GetNodesByParamsByAttrValueContains
        /// </summary>
        /// <param name="htmlNode">Agility node</param>
        /// <param name="htmlTag">HTML tag name by Tag enum</param>
        /// <param name="htmlAttribute">HTML attribute name by Attribute enum</param>
        /// <param name="attributeValue">attribute value</param>
        /// <returns></returns>
        public static HtmlNodeCollection GetNodesByParamsUseXpathContains(HtmlNode htmlNode, HtmlTag htmlTag, HtmlAttribute htmlAttribute, string attributeValue)
        {
            return GetNodesByParamsUseXpathContains(htmlNode, htmlTag.ToString(), htmlAttribute.ToString().Replace("_", ""), attributeValue);
        }

        #endregion

        #region ByXpathStartsWith
        /// <summary>
        /// GetNodeByParamsUseXpathStartsWith
        /// </summary>
        /// <param name="htmlNode"></param>
        /// <param name="tagName"></param>
        /// <param name="attributeName"></param>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        public static HtmlNode GetNodeByParamsUseXpathStartsWith(HtmlNode htmlNode, string tagName, string attributeName, string attributeValue)
        {
            return htmlNode.SelectSingleNode($".//{tagName}[starts-with(@{attributeName},'{attributeValue}')]");
        }

        /// <summary>
        /// GetNodeByParamsUseXpathStartsWith
        /// </summary>
        /// <param name="htmlNode"></param>
        /// <param name="htmlTag"></param>
        /// <param name="attributeName"></param>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        public static HtmlNode GetNodeByParamsUseXpathStartsWith(HtmlNode htmlNode, HtmlTag htmlTag, string attributeName, string attributeValue)
        {
            return GetNodeByParamsUseXpathStartsWith(htmlNode, htmlTag.ToString(), attributeName, attributeValue);
        }

        /// <summary>
        /// GetNodeByParamsUseXpathStartsWith
        /// </summary>
        /// <param name="htmlNode"></param>
        /// <param name="htmlTag"></param>
        /// <param name="htmlAttribute"></param>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        public static HtmlNode GetNodeByParamsUseXpathStartsWith(HtmlNode htmlNode, HtmlTag htmlTag, HtmlAttribute htmlAttribute, string attributeValue)
        {
            return GetNodeByParamsUseXpathStartsWith(htmlNode, htmlTag.ToString(), htmlAttribute.ToString().Replace("_", ""), attributeValue);
        }

        /// <summary>
        /// GetNodesByParamsUseXpathStartsWith
        /// </summary>
        /// <param name="htmlNode"></param>
        /// <param name="tagName"></param>
        /// <param name="attributeName"></param>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        public static HtmlNodeCollection GetNodesByParamsUseXpathStartsWith(HtmlNode htmlNode, string tagName, string attributeName, string attributeValue)
        {
            return htmlNode.SelectNodes($".//{tagName}[starts-with(@{attributeName},'{attributeValue}')]");
        }

        /// <summary>
        /// GetNodesByParamsUseXpathStartsWith
        /// </summary>
        /// <param name="htmlNode"></param>
        /// <param name="htmlTag"></param>
        /// <param name="attributeName"></param>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        public static HtmlNodeCollection GetNodesByParamsUseXpathStartsWith(HtmlNode htmlNode, HtmlTag htmlTag, string attributeName, string attributeValue)
        {
            return GetNodesByParamsUseXpathStartsWith(htmlNode, htmlTag.ToString(), attributeName, attributeValue);
        }

        /// <summary>
        /// GetNodesByParamsUseXpathStartsWith
        /// </summary>
        /// <param name="htmlNode"></param>
        /// <param name="htmlTag"></param>
        /// <param name="htmlAttribute"></param>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        public static HtmlNodeCollection GetNodesByParamsUseXpathStartsWith(HtmlNode htmlNode, HtmlTag htmlTag, HtmlAttribute htmlAttribute, string attributeValue)
        {
            return GetNodesByParamsUseXpathStartsWith(htmlNode, htmlTag.ToString(), htmlAttribute.ToString().Replace("_", ""), attributeValue);
        }

        #endregion

        #region ByXpathEndsWith
        /// <summary>
        /// GetNodeByParamsUseXpathEndsWith
        /// </summary>
        /// <param name="htmlNode"></param>
        /// <param name="tagName"></param>
        /// <param name="attributeName"></param>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        public static HtmlNode GetNodeByParamsUseXpathEndsWith(HtmlNode htmlNode, string tagName, string attributeName, string attributeValue)
        {
            return htmlNode.SelectSingleNode($".//{tagName}[ends-with(@{attributeName},'{attributeValue}')]");
        }

        /// <summary>
        /// GetNodeByParamsUseXpathEndsWith
        /// </summary>
        /// <param name="htmlNode"></param>
        /// <param name="htmlTag"></param>
        /// <param name="attributeName"></param>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        public static HtmlNode GetNodeByParamsUseXpathEndsWith(HtmlNode htmlNode, HtmlTag htmlTag, string attributeName, string attributeValue)
        {
            return GetNodeByParamsUseXpathEndsWith(htmlNode, htmlTag.ToString(), attributeName, attributeValue);
        }


        /// <summary>
        /// GetNodeByParamsUseXpathEndsWith
        /// </summary>
        /// <param name="htmlNode"></param>
        /// <param name="htmlTag"></param>
        /// <param name="htmlAttribute"></param>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        public static HtmlNode GetNodeByParamsUseXpathEndsWith(HtmlNode htmlNode, HtmlTag htmlTag, HtmlAttribute htmlAttribute, string attributeValue)
        {
            return GetNodeByParamsUseXpathEndsWith(htmlNode, htmlTag.ToString(), htmlAttribute.ToString().Replace("_", ""), attributeValue);
        }

        /// <summary>
        /// GetNodesByParamsUseXpathEndsWith
        /// </summary>
        /// <param name="htmlNode"></param>
        /// <param name="tagName"></param>
        /// <param name="attributeName"></param>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        public static HtmlNodeCollection GetNodesByParamsUseXpathEndsWith(HtmlNode htmlNode, string tagName, string attributeName, string attributeValue)
        {
            return htmlNode.SelectNodes($".//{tagName}[ends-with(@{attributeName},'{attributeValue}')]");
        }


        /// <summary>
        /// GetNodesByParamsUseXpathEndsWith
        /// </summary>
        /// <param name="htmlNode"></param>
        /// <param name="htmlTag"></param>
        /// <param name="attributeName"></param>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        public static HtmlNodeCollection GetNodesByParamsUseXpathEndsWith(HtmlNode htmlNode, HtmlTag htmlTag, string attributeName, string attributeValue)
        {
            return GetNodesByParamsUseXpathEndsWith(htmlNode, htmlTag.ToString(), attributeName, attributeValue);
        }


        /// <summary>
        /// GetNodesByParamsUseXpathEndsWith
        /// </summary>
        /// <param name="htmlNode"></param>
        /// <param name="htmlTag"></param>
        /// <param name="htmlAttribute"></param>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        public static HtmlNodeCollection GetNodesByParamsUseXpathEndsWith(HtmlNode htmlNode, HtmlTag htmlTag, HtmlAttribute htmlAttribute, string attributeValue)
        {
            return GetNodesByParamsUseXpathStartsWith(htmlNode, htmlTag.ToString(), htmlAttribute.ToString().Replace("_", ""), attributeValue);
        } 
        #endregion
    }
}
