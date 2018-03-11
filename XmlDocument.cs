using System;
using System.Collections.Generic;

namespace DEV4
{
    public class XmlDocument // Class for work with XML Document
    {
        public string content;
        List<XmlTag> tags;

        /// <summary>
        /// create instance and parse xml content string
        /// </summary>
        /// <param name="content">xml string</param>
        public XmlDocument(string content) 
        {
            this.content = content;
            this.tags = this.ParseXMLstring(content);
        }

        /// <summary>
        /// create empty xml document
        /// </summary>
        public XmlDocument()
        {
            this.content = "";
            this.tags = new List<XmlTag>();
        }

        /// <summary>
        /// for Set content from XML string
        /// </summary>
        /// <param name="xmlString">xml string</param>
        public void SetContent(string xmlString)
        {
            this.content = xmlString;
            this.tags = this.ParseXMLstring(xmlString);
        }

        /// <summary>
        /// for pasring XML string
        /// </summary>
        /// <param name="data">data</param>
        /// <returns></returns>
        public List<XmlTag> ParseXMLstring(string data) 
        {
            data = RemoveComments(data);
            var items = data.Split('>');
            string item;
            var res = new List<XmlTag>();

            XmlTag current_tag = null;
            for (int i = 0; i < items.Length; ++i)
            {
                item = items[i];

                if (IsOpenTag(item))
                {
                    var tag_name = GetTagName(item);
                    var attrs = GetTagAttributes(item);
                    var new_tag = new XmlTag(tag_name, attrs);

                    if (current_tag == null)
                    {
                        // add only root tags to result
                        res.Add(new_tag);
                    }
                    else
                    {
                        // add link between tags
                        current_tag.childs.Add(new_tag);
                        new_tag.parent = current_tag;
                    }

                    current_tag = new_tag;
                }

                if (IsCloseTag(item))
                {
                    current_tag.value = item.Split('<')[0];
                    current_tag = current_tag.parent;
                }
            }

            return res;
        }

        /// <summary>
        /// for collecting all tags in line collection
        /// </summary>
        /// <returns>xml tag</returns>
        public List<XmlTag> CollectAllTags()
        {
            var tags = new List<XmlTag>();

            foreach (var tag in this.tags)
            {
                tags.Add(tag);
                TraverseChilds(tag, child_tag => { tags.Add(child_tag); });
            }

            return tags;
        }

        /// <summary>
        /// for traverse each item in tags tree
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="callback"></param>
        void TraverseChilds(XmlTag tag, Action<XmlTag> callback)
        {
            foreach (XmlTag child in tag.childs)
            {
                callback(child);

                if (child.childs.Count > 0)
                {
                    TraverseChilds(child, callback);
                }
            }
        }

        /// <summary>
        /// for remove comments in XML document
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        string RemoveComments(string data)
        {
            int start_i = data.IndexOf("<!--");

            while (start_i != -1)
            {
                int end_i = data.IndexOf("-->");
                if (end_i == -1)
                {
                    throw new Exception("invalid XML string");
                }

                data = data.Remove(start_i, end_i - start_i);

                start_i = data.IndexOf("<!--");
            }

            return data;
        }

        bool IsOpenTag(string s)
        {
            if (s.Length == 0)
            {
                return false;
            }

            int ind = s.IndexOf('<');

            if (ind != -1 && s.Length >= ind + 1)
            {
                char next_c = s[ind + 1];
                return next_c != '/' && next_c != '?' && next_c != '!';
            }
            else
            {
                return false;
            }
        }

        bool IsCloseTag(string s)
        {
            return s.IndexOf("</") != -1;
        }

        /// <summary>
        /// for getting first tag definition
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        string GetFirstTagDefinition(string data)
        {
            int start_i = data.IndexOf('<'),
                end_i = data.IndexOf('>');

            return data.Substring(start_i, end_i + 1 - start_i);
        }
        
        /// <summary>
        /// Return first tag name from xml string
        /// </summary>
        /// <param name="data">xml string. ex: article info = "referg" lol = "hello" </param>
        /// <returns>first tag name</returns>
        string GetTagName(string data)
        {
            int open_bracket = data.IndexOf('<');
            int space = data.IndexOf(' ', open_bracket);

            if (space == -1)
            {
                return data.Substring(open_bracket + 1);
            }
            else
            {
                return data.Substring(open_bracket + 1, space - 1 - open_bracket);
            }
        }
               
        /// <summary>
        /// get tag attributes
        /// </summary>
        /// <param name="data">data = <article info = ""referg"" lol = ""hello""</param>
        /// <returns></returns>
        List<XmlTagAttribute> GetTagAttributes(string data)
        {
            int open_bracket = data.IndexOf('<');
            int space_after_bracket = data.IndexOf(' ', open_bracket);

            if (space_after_bracket == -1)
            {
                return new List<XmlTagAttribute>();
            }
            else
            {
                string attrs_string = data.Substring(space_after_bracket);
                return ParseAttributes(attrs_string);
            }
        }

        // info = ""referg"" lol = ""hello""
        /// <summary>
        /// for parsing tag attributes
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        List<XmlTagAttribute> ParseAttributes(string data)
        {
            var res = new List<XmlTagAttribute>();
            string[] parts = data.Split('"');
            string name, value;
            XmlTagAttribute attr;

            if (parts.Length % 2 == 0)
            {
                throw new Exception("invalid XML");
            }

            for (int i = 0; i < parts.Length - 1; i += 2)
            {
                name = parts[i].Replace("=", "").Replace(" ", "");
                value = parts[i + 1];

                attr = new XmlTagAttribute(name, value);
                res.Add(attr);
            }

            return res;
        }
        
        /// <summary>
        /// for getting content between <>
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        string GetContentBetweenQuotes(string data)
        {
            int first_i = data.IndexOf('"') + 1;
            int last_i = data.LastIndexOf('"') - 1;
            int length = last_i - first_i + 1;

            return data.Substring(first_i, length);
        }
    }
}
