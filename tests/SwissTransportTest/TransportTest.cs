namespace SwissTransport
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
 
    using SwissTransport.Core;
  using System;

    /// <summary>
    /// The Swiss Transport API tests.
    /// </summary>
    [TestClass]
    public class TransportTest
    {
        private ITransport testee;

        [TestMethod]
        public void Locations()
        {
            testee = new Transport();
            var stations = this.testee.GetStations("Sursee,");

            Assert.AreEqual(10, stations.StationList.Count);
        }

        [TestMethod]
        public void StationBoard()
        {
            testee = new Transport();
      DateTime time = DateTime.Now;
      var stationBoard = this.testee.GetStationBoard("Sursee", "0", time,1) ;

            Assert.IsNotNull(stationBoard);
        }

        [TestMethod]
        public void Connections()
        {
            testee = new Transport();
      DateTime date = DateTime.Now;
      DateTime time = DateTime.Now;

      var connections = this.testee.GetConnections("Sursee", "Luzern", 1, date, time);

      Assert.IsNotNull(connections);
        }
    }
}
