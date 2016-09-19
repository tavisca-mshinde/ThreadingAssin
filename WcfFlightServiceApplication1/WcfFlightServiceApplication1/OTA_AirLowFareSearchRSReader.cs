using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Xml;
using System.Xml.Serialization;
using WcfFlightServiceApplication1;

namespace WcfFlightServiceApplication1
{
    public class OTA_AirLowFareSearchRSReader
    {
        public void get()
        {
            
            string p = @"D:\threadingAssignment\WcfFlightServiceApplication1\WcfFlightServiceApplication1\mystifly.xml";

            
            XmlSerializer serializer = new
            XmlSerializer(typeof(OTA_AirLowFareSearchRS));

          
            FileStream fs = new FileStream(p, FileMode.Open);
            XmlReader reader = XmlReader.Create(fs);

            var b = (OTA_AirLowFareSearchRS)serializer.Deserialize(reader);
            foreach (var i in b.PricedItineraries)
            {
                string AirlineName = i.AirItineraryInfo.OriginDestinationOptions[0].FlightSegment.OperatingAirline.Code;
                int FlightId = i.AirItineraryInfo.OriginDestinationOptions[0].FlightSegment.OperatingAirline.FlightNumber;
                string source = i.AirItineraryInfo.OriginDestinationOptions[0].FlightSegment.DepartureAirport.LocationCode;
                string destination = i.AirItineraryInfo.OriginDestinationOptions[0].FlightSegment.ArrivalAirport.LocationCode;
                string DepartureTime = i.AirItineraryInfo.OriginDestinationOptions[0].FlightSegment.DepartureDateTime.ToString();
                string ArrivalTime = i.AirItineraryInfo.OriginDestinationOptions[0].FlightSegment.ArrivalDateTime.ToString();
                string price = i.AirItineraryPricingInfo.ItinTotalFare.TotalFare.Amount.ToString();
            }

            fs.Close();

            ///////////////////////////////////////////////////////////////////
            
        }
    }
}