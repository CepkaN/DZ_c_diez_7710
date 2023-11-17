using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DZ_c_diez_7710
{
    [XmlInclude(typeof(Flower))]

    public interface IFlower
    {

        public void MostraInfo();
    }
}
