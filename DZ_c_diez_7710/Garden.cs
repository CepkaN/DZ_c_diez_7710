using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DZ_c_diez_7710
{
    internal class Garden
    {
        public List<Flower> Flowers { get; set; }
        public Garden() { Flowers= new List<Flower>(); }
        public void Mos()
        {
            foreach(var M in Flowers)
            {
                M.MostraInfo();
            }
        }
        public void Add(Flower f)
        {
            Flowers.Add(f);
        }
        public void FFF()
        {
            var d = Flowers.Where(s => s.Altezza >= 50).Select(s => s);
            var f=Flowers.OrderBy(s=>s.Salute).Select(s=>s);
            string strJ = "C:\\Users\\User\\Desktop\\C#\\DZ_c_diez_7710\\DZ_c_diez_7710\\aaa.json";
            string json1 = File.ReadAllText(strJ);
            Console.WriteLine(json1);
            string strXML = "C:\\Users\\User\\Desktop\\C#\\DZ_c_diez_7710\\DZ_c_diez_7710\\bbb.xml";
            string json = JsonConvert.SerializeObject(d);
            System.IO.File.WriteAllText(strJ, json);
            XmlSerializer xml1 = new XmlSerializer(typeof(Flower));
            using (var fileStream1 = new FileStream(strXML, FileMode.OpenOrCreate))
            {
                xml1.Serialize(fileStream1, f);

                Console.WriteLine("запись");
            }
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(strXML);
            XmlElement? xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {              
                foreach (XmlElement xnode in xRoot)
                {
                    XmlNode? attr = xnode.Attributes.GetNamedItem("Flower");
                    Console.WriteLine(attr?.Value);
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        Console.WriteLine(childnode.InnerText);
                    }


                }
            }
        }
    }
}
