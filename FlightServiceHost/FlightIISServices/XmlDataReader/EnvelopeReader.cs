using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace FlightIISServices.XmlDataReader
{
    public class EnvelopeReader
    {
        public List<Entity.Flight> GetEnvolopeData (string source,string destination)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Entity.ThreadSabre.Envelope));

            string path = @"D:\threadingAssignment\FlightServiceHost\FlightIISServices\Data\sabre.xml";

            //FileStream fileStream = new FileStream(path, FileMode.Open);

            //XmlReader reader = XmlReader.Create(fileStream);
            StreamReader reader = new StreamReader(path);
            var objEnvolope = (Entity.ThreadSabre.Envelope)xmlSerializer.Deserialize(reader);




            List<Entity.Flight> flightList = new List<Entity.Flight>();
            List<int> flightId = new List<int>(); 
            //Entity.Flight flight = new Entity.Flight();
            foreach (var i in objEnvolope.Body.OTA_AirLowFareSearchRS.PricedItineraries)
            {
                if (source == i.AirItinerary.OriginDestinationOptions.OriginDestinationOption.FlightSegment[0].DepartureAirport.LocationCode
                    && destination == i.AirItinerary.OriginDestinationOptions.OriginDestinationOption.FlightSegment[0].ArrivalAirport.LocationCode)
                {
                    Entity.Flight flight = new Entity.Flight();
                    flight.AirlineName = i.AirItinerary.OriginDestinationOptions.OriginDestinationOption.FlightSegment[0].OperatingAirline.Code;
                    flight.FlightId = i.AirItinerary.OriginDestinationOptions.OriginDestinationOption.FlightSegment[0].OperatingAirline.FlightNumber.ToString();
                    flight.Source = i.AirItinerary.OriginDestinationOptions.OriginDestinationOption.FlightSegment[0].DepartureAirport.LocationCode;
                    flight.Destination = i.AirItinerary.OriginDestinationOptions.OriginDestinationOption.FlightSegment[0].ArrivalAirport.LocationCode;
                    flight.DepartureTime = i.AirItinerary.OriginDestinationOptions.OriginDestinationOption.FlightSegment[0].DepartureDateTime.ToString();
                    flight.ArrivalTime = i.AirItinerary.OriginDestinationOptions.OriginDestinationOption.FlightSegment[0].ArrivalDateTime.ToString();
                    flight.Price = (int)i.AirItineraryPricingInfo.ItinTotalFare.TotalFare.Amount * 70;

                    

                    if (!flightId.Contains(Convert.ToInt32(flight.FlightId)))
                    {
                        flightId.Add(Convert.ToInt32(flight.FlightId));
                        flightList.Add(flight);
                    }
                        
                }
            }
            return flightList;
            
        }
    }
}