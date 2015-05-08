using System.Xml.Serialization;

namespace Utilities.Models
{
    [XmlInclude(typeof(Object))]
    [XmlInclude(typeof(Literal))]
    public abstract class Declaration
    {
        public string ElementType { get; set; }
        public string ID { get; set; }
        public string Type { get; set; }
        public string Tooltip { get; set; }
        public string Default { get; set; }
        public string Function { get; set; }
    }
}