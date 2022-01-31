using System;

namespace SamochodyCiezaroweLibrary.Vehicles
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
        public string StorageDescription => GetStorageDescription();

        public int Id
        {
            get => Vehicle.Id;
            set => Vehicle.Id = value;
        }

        public int ParentId
        {
            get
            {
                if (Vehicle is Trailer trailer) return trailer.ParentId;
                if (Vehicle is SemiTrailer semiTrailer) return semiTrailer.ParentId;
                return 0;
            }
            set
            {
                if (Vehicle is Trailer trailer) trailer.ParentId = value;
                if (Vehicle is SemiTrailer semiTrailer) semiTrailer.ParentId = value;
            }
        }

        public int ChildId
        {
            get
            {
                if (Vehicle is ITrailerable trailerable) return trailerable.TrailerId;
                if (Vehicle is ISemiTrailerable semiTrailerable) return semiTrailerable.SemiTrailerId;
                return 0;
            }
            set
            {
                if (Vehicle is ITrailerable trailerable) trailerable.TrailerId = value;
                if (Vehicle is ISemiTrailerable semiTrailerable) semiTrailerable.SemiTrailerId = value;
            }
        }

        private string GetStorageDescription()
        {
            if (Vehicle is ILoadable loadable) return loadable.Storage.StorageDescription;
            if (Vehicle is ITrailerable trailerable) return trailerable.TrailerId > 0 ? "Przyczepa" : "Brak";
            if (Vehicle is ISemiTrailerable semiTrailerable) return semiTrailerable.SemiTrailerId > 0 ? "Naczepa" : "Brak";
            return "-";
        }
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

        private string GetTrailerDescription()
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