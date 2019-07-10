using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TruckRacingGame;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Truck truck = new Truck();
            Assert.AreEqual(23,truck.TruckBeginingPosition);
        }
    }
}
