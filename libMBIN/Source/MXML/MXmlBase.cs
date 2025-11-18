using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace libMBIN
{
    [XmlInclude(typeof(MXmlData))]
    [XmlInclude(typeof(MXmlProperty))]
    [XmlInclude(typeof(MXmlMeta))]
    public abstract class MXmlBase
    {
        protected MXmlBase()
        {
            Elements = new List<MXmlBase>();
        }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlElement(typeof(MXmlData), ElementName = "Data")]
        [XmlElement(typeof(MXmlProperty), ElementName = "Property")]
        [XmlElement(typeof(MXmlMeta), ElementName = "Meta")]
        public List<MXmlBase> Elements { get; set; }
    }
}