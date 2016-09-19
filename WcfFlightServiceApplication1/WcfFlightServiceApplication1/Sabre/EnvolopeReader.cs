using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace WcfFlightServiceApplication1.Sabre
{
    public class EnvolopeReader
    {
        public void GetXml()
        {
            string s = @"D:\threadingAssignment\WcfFlightServiceApplication1\WcfFlightServiceApplication1\Sabre\sabre.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(Envelope));

            FileStream fs = new FileStream(s, FileMode.Open);
            XmlReader xr = XmlReader.Create(fs);

            var b = (Envelope)serializer.Deserialize(xr);
            string AirlineName = b.Body.OTA_AirLowFareSearchRS.PricedItineraries[0].AirItinerary.OriginDestinationOptions.OriginDestinationOption.FlightSegment[0].OperatingAirline.Code;
            int FlightId = b.Body.OTA_AirLowFareSearchRS.PricedItineraries[0].AirItinerary.OriginDestinationOptions.OriginDestinationOption.FlightSegment[0].OperatingAirline.FlightNumber;
            string source = b.Body.OTA_AirLowFareSearchRS.PricedItineraries[0].AirItinerary.OriginDestinationOptions.OriginDestinationOption.FlightSegment[0].DepartureAirport.LocationCode;
            string destination = b.Body.OTA_AirLowFareSearchRS.PricedItineraries[0].AirItinerary.OriginDestinationOptions.OriginDestinationOption.FlightSegment[0].ArrivalAirport.LocationCode;
            string DepartureTime = b.Body.OTA_AirLowFareSearchRS.PricedItineraries[0].AirItinerary.OriginDestinationOptions.OriginDestinationOption.FlightSegment[0].DepartureDateTime.ToString();
            string ArrivalTime = b.Body.OTA_AirLowFareSearchRS.PricedItineraries[0].AirItinerary.OriginDestinationOptions.OriginDestinationOption.FlightSegment[0].ArrivalDateTime.ToString();
            string price = b.Body.OTA_AirLowFareSearchRS.PricedItineraries[0].AirItineraryPricingInfo.ItinTotalFare.TotalFare.Amount.ToString();
            fs.Close();
            
        }

    }
}