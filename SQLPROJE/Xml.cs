using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SQLPROJE
{
    public class Xml
    {
        public string connectionstringyol { get; set; }
        public string connectionstring { get; set; }

        public string XmlOku(int hanginode)
        {
            int sayac2 = 0;
            XmlDocument doc = new XmlDocument();
            doc.Load(connectionstringyol.ToString());
            XmlElement root = doc.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("//appSettings/add");
            foreach (XmlNode node in nodes)
            {
                sayac2++;
                if (hanginode == 1 && sayac2 == 1)
                {
                    sayac2 = 0;
                    return connectionstring = node.Attributes["value"].Value;

                }
                if (hanginode == 2 && sayac2 == 2)
                {
                    sayac2 = 0;
                    return connectionstring = node.Attributes["value"].Value;


                }
                if (hanginode == 3 && sayac2 == 3)
                {
                    sayac2 = 0;
                    return connectionstring = node.Attributes["value"].Value;


                }
            }
            return null;
        }


    }

}
