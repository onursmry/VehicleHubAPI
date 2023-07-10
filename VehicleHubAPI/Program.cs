using Microsoft.EntityFrameworkCore;
using VehicleHub.Business.Abstract;
using VehicleHub.Business.Concrete;
using VehicleHub.DataAccess.Abstract;
using VehicleHub.DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add dependencies
builder.Services.AddScoped<ICarService, CarManager>();
builder.Services.AddScoped<IBusService, BusManager>();
builder.Services.AddScoped<IBoatService, BoatManager>();
builder.Services.AddScoped<ICarDal, EfCarDal>();
builder.Services.AddScoped<IBusDal, EfBusDal>();
builder.Services.AddScoped<IBoatDal, EfBoatDal>();

//Add DbContext with SQLite
builder.Services.AddDbContext<VehicleHubContext>(options =>
{
    options.UseSqlite("Data Source=vehicle.db");
});


//Enable CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", corsPolicyBuilder =>
    {
        corsPolicyBuilder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.UseCors("AllowAll");
app.MapControllers();

app.Run();
