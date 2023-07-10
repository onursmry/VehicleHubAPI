using VehicleHub.Core.Entities;

namespace VehicleHub.Entities.Concrete;

public class Vehicle : IEntity
{
    public Guid Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}