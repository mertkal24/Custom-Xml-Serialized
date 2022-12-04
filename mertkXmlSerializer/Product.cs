using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace mertkXmlSerializer
{
    public class Product
    {
        [XmlAttribute]
        public int Id { get; set; }
        [XmlElement("Adı")]
        public string Name { get; set; }
        public string Tedarikci { get; set; }
        public double Fiyat { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
