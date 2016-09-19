using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace WcfFlightServiceApplication1
{
    [ServiceContract]
    interface IFlightService1
    {
        [OperationContract]
        List<Flight> Get(string Source, string Destination);

    }
}
