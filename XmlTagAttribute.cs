using System;

namespace DEV4
{
    /// <summary>
    /// class for work with xml tag attribute
    /// </summary>
    public class XmlTagAttribute:IComparable
    {
        public string name;
        public string value;

        /// <summary>
        /// create instance
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public XmlTagAttribute(string name, string value)
        {
            this.name = name;
            this.value = value;
        }

        /// <summary>
        /// override method  ToString
        /// </summary>
        /// <returns></returns>
        override public string ToString()
        {
            return String.Format("{0}=\"{1}\"", this.name, this.value);
        }

        /// <summary>
        /// to compare XmlTagAttributes
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            XmlTagAttribute attr = obj as XmlTagAttribute;
            return String.Compare(this.name, attr.name);
        }
    }
}
