using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace WcfFlightServiceApplication1.worldspan
{
    public class PSW5Reader
    {
        public void GetXml()
        {
            string s = @"D:\threadingAssignment\WcfFlightServiceApplication1\WcfFlightServiceApplication1\worldspan\worldspan.xml";
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(PSW5));

            FileStream fs = new FileStream(s, FileMode.Open);

            XmlReader xmlReader = XmlReader.Create(fs);

            var b = (PSW5)xmlSerializer.Deserialize(xmlReader);

            string AirlineName = b.ALT_INF[0].FLI_INF[0].ARL_COD;
            int FlightId = b.ALT_INF[0].FLI_INF[0].FLI_NUM;
            string source = b.ALT_INF[0].FLI_INF[0].DEP_ARP;
            string destination = b.ALT_INF[0].FLI_INF[0].ARR_ARP;
            string DepartureTime = b.ALT_INF[0].FLI_INF[0].DEP_TIM.ToString();
            string ArrivalTime = b.ALT_INF[0].FLI_INF[0].ARR_TIM.ToString();
            string price = b.ALT_INF[0].TTL_FAR.ToString();

        }
    }
}