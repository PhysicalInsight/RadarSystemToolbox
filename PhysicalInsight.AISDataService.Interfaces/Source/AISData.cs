using System;

namespace PhysicalInsight.AISDataService.Interfaces
{
    public record AISData
    {
        public int MMSI { get; init; }

        public DateTime TimeStamp { get; init; }

        public double Latitude { get; init; }

        public double Longitude { get; init; }

        public string NavigationalStatus { get; init; }

        public double RateOfTurn { get; init; }

        public double SpeedOverGround { get; init; }

        public double CourseOverGround { get; init; }

        public double Heading { get; init; }

        public string IMO { get; init; }

        public string Callsign { get; init; }

        public string Name { get; init; }

        public string ShipType { get; init; }

        public string TypeOfPositionFixingDevice { get; init; }

        public double Width { get; init; }

        public double Length { get; init; }

        public double Draught { get; init; }

        public string CargoType { get; init; }

        public string Destination { get; init; }

        public DateTime ETA { get; init; }
    }
}