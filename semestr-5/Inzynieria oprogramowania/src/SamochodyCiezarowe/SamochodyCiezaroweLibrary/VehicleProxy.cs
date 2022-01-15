using System;
using SamochodyCiezaroweLibrary.Vehicles;

namespace SamochodyCiezaroweLibrary
{
    public class VehicleProxy
    {
        public VehicleProxy(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }

        public Vehicle Vehicle { get; set; }
        public bool IsTrailer => Vehicle is Trailer;
        public bool IsSemiTrailer => Vehicle is SemiTrailer;

        public string TrailerDescription => GetTrailerDescription();
        public bool IsConnected => TrailerStatus == TrailerStatus.Connected;
        public TrailerStatus TrailerStatus => GetTrailerStatus();

        private TrailerStatus GetTrailerStatus()
        {
            if (Vehicle is ITrailerable trailerableVehicle)
                return trailerableVehicle.TrailerId > 0 ? TrailerStatus.Connected : TrailerStatus.Disconnected;

            if (Vehicle is ISemiTrailerable semiTrailerableVehicle)
                return semiTrailerableVehicle.SemiTrailerId > 0 ? TrailerStatus.Connected : TrailerStatus.Disconnected;

            if (Vehicle is Trailer trailer) return trailer.ParentId > 0 ? TrailerStatus.Connected : TrailerStatus.Disconnected;

            if (Vehicle is SemiTrailer semiTrailer) return semiTrailer.ParentId > 0 ? TrailerStatus.Connected : TrailerStatus.Disconnected;

            return TrailerStatus.Undefined;
        }

        string GetTrailerDescription()
        {
            switch (TrailerStatus)
            {
                case TrailerStatus.Undefined:
                    return "-";
                case TrailerStatus.Connected:
                    return "Połączony";
                case TrailerStatus.Disconnected:
                    return "Rozłączony";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    public enum TrailerStatus
    {
        Undefined,
        Connected,
        Disconnected
    }
}