using Microsoft.EntityFrameworkCore;
using VehicleHub.Entities.Concrete;

namespace VehicleHub.DataAccess.Concrete.EntityFramework
{
    public class VehicleHubContext : DbContext
    {
        public VehicleHubContext(DbContextOptions<VehicleHubContext> options) : base(options)
        {
        }

        public VehicleHubContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=vehiclehub.db");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Boat> Boats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car { Id = Guid.NewGuid(), Brand = "Toyota", Model = "Corolla", Color = "Red", Wheels = 4, Headlights = true,CreatedAt = DateTime.Now},
                new Car { Id = Guid.NewGuid(), Brand = "Ford", Model = "Mustang", Color = "Blue", Wheels = 4, Headlights = false, CreatedAt = DateTime.Now },
                new Car { Id = Guid.NewGuid(), Brand = "BMW", Model = "X5", Color = "Black", Wheels = 4, Headlights = true,CreatedAt = DateTime.Now },
                new Car { Id = Guid.NewGuid(), Brand = "Honda", Model = "Civic", Color = "Silver", Wheels = 4, Headlights = false,CreatedAt = DateTime.Now },
                new Car { Id = Guid.NewGuid(), Brand = "Mercedes-Benz", Model = "E-Class", Color = "White", Wheels = 4, Headlights = true,CreatedAt = DateTime.Now },
                new Car { Id = Guid.NewGuid(), Brand = "Audi", Model = "A4", Color = "Silver", Wheels = 4, Headlights = true,CreatedAt = DateTime.Now },
                new Car { Id = Guid.NewGuid(), Brand = "Volkswagen", Model = "Golf", Color = "Black", Wheels = 4, Headlights = false,CreatedAt = DateTime.Now },
                new Car { Id = Guid.NewGuid(), Brand = "Chevrolet", Model = "Camaro", Color = "Yellow", Wheels = 4, Headlights = true,CreatedAt = DateTime.Now },
                new Car { Id = Guid.NewGuid(), Brand = "Nissan", Model = "Altima", Color = "Blue", Wheels = 4, Headlights = false,CreatedAt = DateTime.Now },
                new Car { Id = Guid.NewGuid(), Brand = "Hyundai", Model = "Elantra", Color = "Red", Wheels = 4, Headlights = true,CreatedAt = DateTime.Now }
            );

            modelBuilder.Entity<Bus>().HasData(
                new Bus { Id = Guid.NewGuid(),Brand="Volvo", Model="9700", Color = "Red", CreatedAt = DateTime.Now },
                new Bus { Id = Guid.NewGuid(),Brand="MAN", Model="City 10", Color = "Blue",CreatedAt = DateTime.Now },
                new Bus { Id = Guid.NewGuid(),Brand="Daimler", Model= "eCitaro", Color = "Green",CreatedAt = DateTime.Now },
                new Bus { Id = Guid.NewGuid(),Brand="Daimler", Model= "Tourismo", Color = "Yellow" ,CreatedAt = DateTime.Now},
                new Bus { Id = Guid.NewGuid(),Brand="MAN", Model="City 12", Color = "Orange",CreatedAt = DateTime.Now },
                new Bus { Id = Guid.NewGuid(),Brand="Yutong", Model= "TC12", Color = "Purple" ,CreatedAt = DateTime.Now},
                new Bus { Id = Guid.NewGuid(),Brand="Volvo", Model="9900", Color = "Black",CreatedAt = DateTime.Now },
                new Bus { Id = Guid.NewGuid(),Brand="Scania", Model="K230UB", Color = "Gray",CreatedAt = DateTime.Now },
                new Bus { Id = Guid.NewGuid(),Brand="Scania", Model="Interlink", Color = "Burgundy" ,CreatedAt = DateTime.Now},
                new Bus { Id = Guid.NewGuid(),Brand = "Yutong", Model = "GT12", Color = "White",CreatedAt = DateTime.Now }
            );

            modelBuilder.Entity<Boat>().HasData(
                new Boat { Id = Guid.NewGuid(),Brand="Boston Whaler",Model="420 Outrage", Color = "Red", CreatedAt = DateTime.Now },
                new Boat { Id = Guid.NewGuid(),Brand="Boston Whaler",Model="405 Conquest", Color = "Blue",CreatedAt = DateTime.Now },
                new Boat { Id = Guid.NewGuid(),Brand="Yamaha Boats",Model="SX195", Color = "Green",CreatedAt = DateTime.Now },
                new Boat { Id = Guid.NewGuid(),Brand="Yamaha Boats",Model="252 FSH", Color = "Teal",CreatedAt = DateTime.Now },
                new Boat { Id = Guid.NewGuid(),Brand="Beneteau", Model="Cyclades", Color = "Violet",CreatedAt = DateTime.Now },
                new Boat { Id = Guid.NewGuid(),Brand="Beneteau", Model="Antares", Color = "Ivory",CreatedAt = DateTime.Now },
                new Boat { Id = Guid.NewGuid(),Brand="Horizon",Model="EP150", Color = "Cyan",CreatedAt = DateTime.Now },
                new Boat { Id = Guid.NewGuid(),Brand="Horizon",Model="RP110", Color = "Olive Green",CreatedAt = DateTime.Now },
                new Boat { Id = Guid.NewGuid(),Brand="Silent",Model="80", Color = "Brown" ,CreatedAt = DateTime.Now},
                new Boat { Id = Guid.NewGuid(),Brand="Silent",Model="S64", Color = "Black" ,CreatedAt = DateTime.Now}
            );

            base.OnModelCreating(modelBuilder);
        }

    }
}