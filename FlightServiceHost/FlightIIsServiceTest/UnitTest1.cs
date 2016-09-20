using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlightIISServices;

namespace FlightIIsServiceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetData()
        {
            FlightIISServices.FlightServices.FlightService flightService = new FlightIISServices.FlightServices.FlightService();
            var a = flightService.GetFlightsBySourceDestinationTravellersAndClass("MAA", "DEL", "2", "Economy");

            //    var b = flightService.FilteringFlights(a, new FlightIISServices.Entity.Filter
            //    {
            //        //Rating = 3.5,
            //        AirlineName="Vistara",
            //        //StartRange = 2500,
            //        //EndRange=3500,

            //    });

            //flightService.AddNewBooking(b[0], new FlightIISServices.Entity.Customer { CustomerId = "1",FisrtName="Mayuresh",LastName="Bhanushali",Email="mb@tv.com",MobileNumber="9854659887" });

            //flightService.CancelBooking("1-1");

        }
        [TestMethod]
        public void TestGetFilterData()

        {
            FlightIISServices.FlightServices.FlightService flightService = new FlightIISServices.FlightServices.FlightService();
            var a = flightService.GetFlightsBySourceDestinationTravellersAndClass("MAA", "DEL", "2", "Economy");

            var b = flightService.FilteringFlights(a, new FlightIISServices.Entity.Filter
            {
                //Rating = 3.5,
                AirlineName = "AI",
                //StartRange = 2500,
                //EndRange=3500,

            });
            Assert.IsNotNull(b);
        }


        [TestMethod]
        public void TestCancellationOfBooking()
        {
            FlightIISServices.FlightServices.FlightService flightService = new FlightIISServices.FlightServices.FlightService();
            var a = flightService.GetFlightsBySourceDestinationTravellersAndClass("MAA", "DEL", "2", "Economy");

            var b = flightService.FilteringFlights(a, new FlightIISServices.Entity.Filter
            {
                //Rating = 3.5,
                AirlineName = "AI",
                //StartRange = 2500,
                //EndRange=3500,

            });

            var id= flightService.AddNewBooking(b.FlightList[0], new FlightIISServices.Entity.Customer { CustomerId = "1", FisrtName = "Mayuresh", LastName = "Bhanushali", Email = "mb@tv.com", MobileNumber = "9854659887" },1);

            flightService.CancelBooking("1-1");

        }
        public void TestGetForBooking()

        {
            FlightIISServices.FlightServices.FlightService flightService = new FlightIISServices.FlightServices.FlightService();
            var a = flightService.GetFlightsBySourceDestinationTravellersAndClass("MAA", "DEL", "2", "Economy");

            var b = flightService.FilteringFlights(a, new FlightIISServices.Entity.Filter
            {
                //Rating = 3.5,
                AirlineName = "AI",
                //StartRange = 2500,
                //EndRange=3500,

            });

            var bookingId= flightService.AddNewBooking(b.FlightList[0], new FlightIISServices.Entity.Customer { CustomerId = "1",FisrtName="Mayuresh",LastName="Bhanushali",Email="mb@tv.com",MobileNumber="9854659887" },0);
            Assert.IsNotNull(bookingId);
        }

        [TestMethod]
        public void TestMethod2()
        {

            //FlightIISServices.FlightServices.FlightService flightService = new FlightIISServices.FlightServices.FlightService();
            //var a = flightService.GetFlightsBySourceDestinationTravellersAndClass("Pune", "Mumbai", "2", "Economy");


            ////FlightIISServices.FlightServices.FlightService flightService = new FlightIISServices.FlightServices.FlightService();
            //var b =flightService.SaveCardDetails(a,new FlightIISServices.Entity.Card { CardNumber = "1234567891234567", validTillMonthAndYear = "10/16", CVV = 4200, CardHolderName = "Mayuresh Bhanushali" });

        }

        [TestMethod]
        public void TestXmlDataReaderEnvelopeReader()
        {
            FlightIISServices.XmlDataReader.IXmlFileReader en = new FlightIISServices.XmlDataReader.EnvelopeReader();
            var a = en.GetData("MAA", "DEL");
            Assert.IsNotNull(a);
        }

        [TestMethod]
        public void TestXmlDataReaderOTA_AirLowFareSearchRSReader()
        {
            FlightIISServices.XmlDataReader.IXmlFileReader en = new FlightIISServices.XmlDataReader.OTA_AirLowFareSearchRSReader();
            var a = en.GetData("KUL", "SIN");
            Assert.IsNotNull(a);
        }

        [TestMethod]
        public void TestXmlDataReaderPSW5Reader()
        {
            FlightIISServices.XmlDataReader.IXmlFileReader en = new FlightIISServices.XmlDataReader.PSW5Reader();
            var a = en.GetData("LAS", "LAX");
            Assert.IsNotNull(a);
        }
    }
}
