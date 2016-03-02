using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using cis237assignment3;

namespace cis237assignment3UnitTest
{
    [TestClass]
    public class DroidTest
    {
        [TestMethod]
        public void AstromechCostTest()
        {
            DroidCollection droidCollection = new DroidCollection(100);
            Astromech astromech = new Astromech("astromech", "wood", "red", true, true, true, true, 4);
            astromech.CalculateTotalCost();
            Assert.AreEqual(18m, astromech.TotalCost);
        }

        [TestMethod]
        public void JanitorCostTest()
        {
            DroidCollection droidCollection = new DroidCollection(100);
            Janitor janitor = new Janitor("janitor", "wood", "red", true, true, true, true, true);
            janitor.CalculateTotalCost();
            Assert.AreEqual(15m, janitor.TotalCost);
        }

        [TestMethod]
        public void UtilityCostTest()
        {
            DroidCollection droidCollection = new DroidCollection(100);
            Utility utility = new Utility("utility", "wood", "red", true, true, true);
            utility.CalculateTotalCost();
            Assert.AreEqual(10m, utility.TotalCost);
        }

        [TestMethod]
        public void ProtocolCostTest()
        {
            DroidCollection droidCollection = new DroidCollection(100);
            Protocol protocol = new Protocol("protocol", "wood", "red", 4);
            protocol.CalculateTotalCost();
            Assert.AreEqual(23m, protocol.TotalCost);
            
        }
    }
}
