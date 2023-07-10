using VehicleHub.Core.Entities;

namespace VehicleHub.Entities.Concrete;

public class Car : Vehicle, IEntity
{
    public int Wheels { get; set; }
    public bool Headlights { get; set; }
}