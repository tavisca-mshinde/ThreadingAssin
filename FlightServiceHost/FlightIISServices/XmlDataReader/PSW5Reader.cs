﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace FlightIISServices.XmlDataReader
{
    public class PSW5Reader
    {
        public List<Entity.Flight> GetPSW5Data(string source, string destination)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Entity.Threadworldspan.PSW5));

            string path = @"D:\threadingAssignment\FlightServiceHost\FlightIISServices\Data\worldspan.xml";

            //FileStream fs = new FileStream(s, FileMode.Open);

            //XmlReader reader = XmlReader.Create(fs);
            StreamReader reader = new StreamReader(path);
            var obj = (Entity.Threadworldspan.PSW5)serializer.Deserialize(reader);

            List<Entity.Flight> flightList = new List<Entity.Flight>();

            
            foreach(var i in obj.ALT_INF)
            {
                if (source == i.FLI_INF[0].DEP_ARP && destination == i.FLI_INF[0].ARR_ARP)
                {
                    Entity.Flight flight = new Entity.Flight();
                    flight.AirlineName = i.FLI_INF[0].ARL_COD;
                    flight.FlightId = i.FLI_INF[0].FLI_NUM.ToString();
                    flight.Source = i.FLI_INF[0].DEP_ARP;
                    flight.Destination = i.FLI_INF[0].ARR_ARP;
                    flight.DepartureTime = i.FLI_INF[0].DEP_TIM.ToString();
                    flight.ArrivalTime = i.FLI_INF[0].ARR_TIM.ToString();
                    flight.Price = (int)i.TTL_FAR * 70;
                    if (!flightList.Contains(flight))
                        flightList.Add(flight);
                }
            }
            return flightList;
        }
    }
}