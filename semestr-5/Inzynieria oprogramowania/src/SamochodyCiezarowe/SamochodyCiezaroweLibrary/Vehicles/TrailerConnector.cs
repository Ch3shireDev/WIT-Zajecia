using System;
using System.Collections.Generic;
using System.Linq;

namespace SamochodyCiezaroweLibrary.Vehicles
{
    public class TrailerConnector
    {
        public TrailerConnector(IEnumerable<VehicleProxy> vehicles)
        {
            Vehicles = vehicles;
        }

        public IEnumerable<VehicleProxy> Vehicles { get; set; }

        bool Exists(int id)
        {
            return GetVehicle(id) != null;
        }

        VehicleProxy GetVehicle(int id)
        {
            return Vehicles.FirstOrDefault(v => v.Vehicle.Id == id);
        }

        public void Hook(ITrailerable vehicle, Trailer trailer)
        {
            if (Exists(vehicle.TrailerId)) throw new Exception($"Nie można połączyć pojazdów - pojazd {vehicle} posiada już przyczepę.");
            if (Exists(trailer.ParentId)) throw new Exception($"Nie można połączyć pojazdów - przyczepa {trailer} jest już podłączona.");
            vehicle.TrailerId = trailer.Id;
            trailer.ParentId = vehicle.Id;
        }

        public void Hook(ISemiTrailerable vehicle, SemiTrailer semitrailer)
        {
            if (Exists(vehicle.SemiTrailerId)) throw new Exception($"Nie można połączyć pojazdów - pojazd {vehicle} posiada już przyczepę.");
            if (Exists(semitrailer.ParentId)) throw new Exception($"Nie można połączyć pojazdów - przyczepa {semitrailer} jest już podłączona.");
            vehicle.SemiTrailerId = semitrailer.Id;
            semitrailer.ParentId = vehicle.SemiTrailerId;
        }

        public void Unhook(ITrailerable trailerableVehicle)
        {
            if (GetVehicle(trailerableVehicle.TrailerId)?.Vehicle is SemiTrailer vehicle) vehicle.ParentId = 0;
            trailerableVehicle.TrailerId = 0;
        }
        public void Unhook(ISemiTrailerable trailerableVehicle)
        {
            if (GetVehicle(trailerableVehicle.SemiTrailerId)?.Vehicle is SemiTrailer vehicle) vehicle.ParentId = 0;
            trailerableVehicle.SemiTrailerId = 0;
        }
    }
}