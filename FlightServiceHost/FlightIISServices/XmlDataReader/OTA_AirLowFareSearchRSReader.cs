using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace FlightIISServices.XmlDataReader
{
    public class OTA_AirLowFareSearchRSReader
    {
        public List<Entity.Flight> GetOTA_AirLowFareSearchRSData(string source, string destination)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Entity.ThreadMystifly.OTA_AirLowFareSearchRS));

            string path = @"D:\threadingAssignment\FlightServiceHost\FlightIISServices\Data\mystifly.xml";

            // FileStream fileStream = new FileStream(path, FileMode.Open);

            //XmlReader reader = XmlReader.Create(fileStream);
            StreamReader reader = new StreamReader(path);
            var objOTA_AirLowFareSearchRSReader = (Entity.ThreadMystifly.OTA_AirLowFareSearchRS)serializer.Deserialize(reader);

            List<Entity.Flight> flightList = new List<Entity.Flight>();

            Entity.Flight flight = new Entity.Flight();
            foreach (var i in objOTA_AirLowFareSearchRSReader.PricedItineraries)
            {
                if (source == i.AirItineraryInfo.OriginDestinationOptions[0].FlightSegment.DepartureAirport.LocationCode &&
                    destination == i.AirItineraryInfo.OriginDestinationOptions[0].FlightSegment.ArrivalAirport.LocationCode)
                {
                    flight.AirlineName = i.AirItineraryInfo.OriginDestinationOptions[0].FlightSegment.OperatingAirline.Code;
                    flight.FlightId = i.AirItineraryInfo.OriginDestinationOptions[0].FlightSegment.OperatingAirline.FlightNumber.ToString();
                    flight.Source = i.AirItineraryInfo.OriginDestinationOptions[0].FlightSegment.DepartureAirport.LocationCode;
                    flight.Destination = i.AirItineraryInfo.OriginDestinationOptions[0].FlightSegment.ArrivalAirport.LocationCode;
                    flight.DepartureTime = i.AirItineraryInfo.OriginDestinationOptions[0].FlightSegment.DepartureDateTime.ToString();
                    flight.ArrivalTime = i.AirItineraryInfo.OriginDestinationOptions[0].FlightSegment.ArrivalDateTime.ToString();
                    flight.Price = (int)i.AirItineraryPricingInfo.ItinTotalFare.TotalFare.Amount;
                    //if (!flightList.Contains(flight))
                        flightList.Add(flight);


                }
            }
            return flightList;

        }
    }
}