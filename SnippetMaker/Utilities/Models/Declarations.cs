using System.Xml.Serialization;

namespace Utilities.Models
{
    public class Declarations
    {
        [XmlElement]
        public Object[] Object { get; set; }

        [XmlElement]
        public Literal[] Literal { get; set; }
    }
}