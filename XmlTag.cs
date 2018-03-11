using System;
using System.Collections.Generic;

namespace DEV4
{
    /// <summary>
    /// Class to work with tags
    /// </summary>
    public class XmlTag:IComparable 
    {
        public string name;
        public List<XmlTagAttribute> attributes;
        public string value;
        public XmlTag parent;
        public List<XmlTag> childs;

        /// <summary>
        /// create instance and empty XML tag
        /// </summary>
        /// <param name="name"></param>
        /// <param name="attrs"></param>
        public XmlTag(string name, List<XmlTagAttribute> attrs)
        {
            this.name = name;
            this.attributes = attrs;
            this.value = "";
            this.parent = null;
            this.childs = new List<XmlTag>();
        }

        /// <summary>
        /// Override default method to string
        /// </summary>
        /// <returns></returns>
        override public string ToString()
        {
            return String.Format("{0} {1}'{2}'", GetParentsTree(), AttrsToString(), this.value);
        }

        /// <summary>
        /// to output tag in tasks format
        /// </summary>
        /// <returns></returns>
        public string ToTaskFormatString()
        {
            var list_res = new List<string>();
            list_res.Add(TaskFormatItem(this.name, this.value));

            this.attributes.Sort();

            foreach (var attr in this.attributes)
            {
                list_res.Add(TaskFormatItem(attr.name, attr.value));
            }

            return String.Join("\n", list_res); ;
        }

        /// <summary>
        /// to output Item in Task Format
        /// </summary>
        /// <param name="item"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        string TaskFormatItem(string item, string val)
        {
            return String.Format("{0}-{1}-{2}", GetParentsTree(), item, val);
        }

        /// <summary>
        /// convert collection of arguments to string
        /// </summary>
        /// <returns></returns>
        public string AttrsToString()
        {
            if (this.attributes.Count > 0)
            {
                return String.Format("[{0}] ", String.Join(", ", this.attributes));
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// Get Parents Tree
        /// </summary>
        /// <returns></returns>
        public string GetParentsTree()
        {
            XmlTag tag = this;
            string res = this.name;

            while (tag.parent != null)
            {
                tag = tag.parent;
                res = res.Insert(0, tag.name + "->");
            }

            return res;
        }

        /// <summary>
        /// to compare Xml Tags
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            XmlTag tag = obj as XmlTag;
            return String.Compare(this.GetParentsTree(), tag.GetParentsTree());
        }
    }
}
