using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace mertkXmlSerializer
{
     class mkXmlSerializer
    {
        public Type type;
        public Type types;
        public mkXmlSerializer(Type nType, Type eTypes)
        {
            this.type = nType;
            this.types = eTypes;
        }
        public void Serialize(Object obj)
        {

            List<PropertyInfo> props = types.GetProperties().ToList();
            List<object> list = ((IEnumerable)obj).Cast<object>().ToList();                   
            string xmlString = "";
            foreach (object item in list)
            {
                xmlString += "<" + types.Name + ">\n";
                foreach(PropertyInfo x in props)
                {
                    string property = x.Name;
                    string val = item.GetType().GetProperty(x.Name).GetValue(item,null).ToString();
                    xmlString += "<" + property + ">" + val + "</" + property + ">\n";                    
                }
                xmlString += "</" + types.Name + ">\n";
            }
            TextWriter writer = new StreamWriter(@"C:\Users\Casper\Desktop\C# Eğitim\mertkXmlSerializer\xmlDoc\\tedarik.xml");
            writer.Write(xmlString);
            writer.Close();
            
        }
        
    }
}
