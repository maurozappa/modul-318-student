namespace SwissTransport.Core
{
    using System.Threading.Tasks;
  using System;
    using SwissTransport.Models;

    public interface ITransport
    {
        Stations GetStations(string query);

        StationBoardRoot GetStationBoard(string station, string id, DateTime time, int ende);

        Connections GetConnections(string fromStation, string toStation, int limit, DateTime date, DateTime time);
    }
}