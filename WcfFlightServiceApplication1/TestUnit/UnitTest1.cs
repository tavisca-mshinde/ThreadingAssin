using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfFlightServiceApplication1;
using WcfFlightServiceApplication1.Sabre;
using WcfFlightServiceApplication1.worldspan;

namespace TestUnit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            OTA_AirLowFareSearchRSReader a = new OTA_AirLowFareSearchRSReader();
            a.get();
        }
        public void TestMethod2()
        {

            EnvolopeReader en = new EnvolopeReader();

            en.GetXml();

        }
        public void TestMethod3()
        {

            PSW5Reader p = new PSW5Reader();
            p.GetXml();
        }
    }
}
