using System.Collections.Generic;
using System.Linq;
using SamochodyCiezaroweLibrary;
using SamochodyCiezaroweLibrary.Storages;
using SamochodyCiezaroweLibrary.Vehicles;

namespace SamochodyCiezaroweAppWpf.Vehicles.Editor
{
    public class VehicleEditorModel
    {
        public VehicleEditorModel(VehicleProxy vehicleProxy)
        {
            Vehicle = new VehicleBuilder().Build(vehicleProxy.Vehicle);
            SelectedVehicleType = VehicleTypes.FirstOrDefault(x => x.GetType() == Vehicle.GetType());
            SelectedStorageType = StorageTypes.FirstOrDefault(s => s.GetType() == (Vehicle as ILoadable)?.Storage.GetType());
            SetEngine();
        }

        public string SelectedTrailerName => GetSelectedTrailerName();
        public Vehicle Vehicle { get; set; }
        public Engine Engine { get; set; }
        public Vehicle SelectedVehicleType { get; set; }

        public List<Vehicle> VehicleTypes { get; } = Helpers.GetAvailableVehicles();
        public List<Storage> StorageTypes { get; } = Helpers.GetAvailableStorages();

        public Storage SelectedStorageType { get; set; }

        private TrailerConnector TrailerConnector => new(VehiclesSingleton.Instance.Vehicles);
        public bool IsTrailerable => Vehicle is ITrailerable;
        public bool IsConnected => GetIsConnected();
        public bool IsSemiTrailerable => Vehicle is ISemiTrailerable;

        private bool GetIsConnected()
        {
            if (Vehicle is ITrailerable trailerable) return trailerable.TrailerId != 0;
            if (Vehicle is ISemiTrailerable semiTrailerable) return semiTrailerable.SemiTrailerId != 0;
            return false;
        }

        public string GetSelectedTrailerName()
        {
            if (Vehicle is ITrailerable trailerable) return VehiclesSingleton.Instance.GetNameById(trailerable.TrailerId);
            if (Vehicle is ISemiTrailerable semiTrailerable) return VehiclesSingleton.Instance.GetNameById(semiTrailerable.SemiTrailerId);
            return "-";
        }

        public void SetVehicleType()
        {
            Vehicle = new VehicleBuilder().BuildFromType(SelectedVehicleType, Vehicle);
            SetEngine();
        }

        public void SetEngine()
        {
            if (Vehicle is MotorizedVehicle motorizedVehicle) Engine = motorizedVehicle.Engine;
            else Engine = new Engine();
        }

        public List<VehicleProxy> GetTrailersList()
        {
            return VehiclesSingleton.Instance.GetTrailersList();
        }

        public void Connect(Trailer selectedTrailer)
        {
            if (Vehicle is ITrailerable trailerable) TrailerConnector.Hook(trailerable, selectedTrailer);
        }

        public void Connect(SemiTrailer selectedSemiTrailer)
        {
            if (Vehicle is ISemiTrailerable semiTrailerable) TrailerConnector.Hook(semiTrailerable, selectedSemiTrailer);
        }

        public void Disconnect()
        {
            switch (Vehicle)
            {
                case ITrailerable trailerable:
                    TrailerConnector.Unhook(trailerable);
                    break;
                case ISemiTrailerable semitrailerable:
                    TrailerConnector.Unhook(semitrailerable);
                    break;
            }
        }

        public void SetStorage()
        {
            if (Vehicle is not ILoadable loadable) return;
            if (loadable.Storage.GetType() == SelectedStorageType.GetType()) return;
            loadable.Storage = new StorageBuilder().Build(SelectedStorageType);
        }
    }
}