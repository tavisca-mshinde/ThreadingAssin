using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightIISServices.XmlDataReader
{
    public interface IXmlFileReader
    {
        List<Entity.Flight> GetData(string source, string destination);
    }
}
