using System;

namespace PhysicalInsight.AISDataService.Interfaces
{
    public class AISData
    {
        public int MMSI { get; set; }

        public DateTime TimeStamp { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public string NavigationalStatus { get; set; }

        public double RateOfTurn { get; set; }

        public double SpeedOverGround { get; set; }

        public double CourseOverGround { get; set; }

        public double Heading { get; set; }

        public string IMO { get; set; }

        public string Callsign { get; set; }

        public string Name { get; set; }

        public string ShipType { get; set; }

        public string TypeOfPositionFixingDevice { get; set; }

        public double Width { get; set; }

        public double Length { get; set; }

        public double Draught { get; set; }

        public string CargoType { get; set; }

        public string Destination { get; set; }

        public DateTime ETA { get; set; }
    }
}
