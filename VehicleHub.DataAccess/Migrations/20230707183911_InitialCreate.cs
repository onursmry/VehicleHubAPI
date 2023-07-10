using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehicleHub.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Color = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Buses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Color = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Wheels = table.Column<int>(type: "INTEGER", nullable: false),
                    Headlights = table.Column<bool>(type: "INTEGER", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Color = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Boats",
                columns: new[] { "Id", "Brand", "Color", "CreatedAt", "Model", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("241e961a-dd02-4309-8b43-1b1c10cb3b32"), "Boston Whaler", "Red", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2516), "420 Outrage", null },
                    { new Guid("2ae4dd05-d57a-4929-9a9a-a3fe6cb5e61a"), "Boston Whaler", "Blue", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2517), "405 Conquest", null },
                    { new Guid("2b38f90c-6ec0-47f3-bbf4-d038d3d2ba06"), "Silent", "Brown", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2527), "80", null },
                    { new Guid("2faec214-5c98-4266-9fb8-ef58da81d633"), "Horizon", "Cyan", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2523), "EP150", null },
                    { new Guid("3c49c549-c975-4f63-a43a-336ab6b0be48"), "Beneteau", "Violet", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2521), "Cyclades", null },
                    { new Guid("452757d2-f263-4af1-b072-d6d0edeb6717"), "Horizon", "Olive Green", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2525), "RP110", null },
                    { new Guid("a6603d9a-eee5-4a6c-882b-9c4c9064f904"), "Yamaha Boats", "Teal", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2520), "252 FSH", null },
                    { new Guid("b211896b-7a66-4d61-85c7-c266cff480c4"), "Beneteau", "Ivory", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2522), "Antares", null },
                    { new Guid("c4538238-0e7b-420a-b326-31d54c845560"), "Yamaha Boats", "Green", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2519), "SX195", null },
                    { new Guid("dedae488-ec42-47d7-b40c-f8f8026b35fb"), "Silent", "Black", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2529), "S64", null }
                });

            migrationBuilder.InsertData(
                table: "Buses",
                columns: new[] { "Id", "Brand", "Color", "CreatedAt", "Model", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1f73b9f7-1ccf-4ad8-9fd4-65d8249e4676"), "Daimler", "Yellow", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2488), "Tourismo", null },
                    { new Guid("316b2f9b-23b4-47d8-8d9e-5d80db34c39d"), "MAN", "Blue", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2483), "City 10", null },
                    { new Guid("390ed370-ebf7-4563-81a3-04bec241dd88"), "Volvo", "Red", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2481), "9700", null },
                    { new Guid("46b65631-dac1-4d61-8b1b-6a7d002a3d7e"), "Scania", "Gray", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2497), "K230UB", null },
                    { new Guid("57a6a385-452b-40dc-9c1a-c5586eba5de5"), "Yutong", "Purple", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2493), "TC12", null },
                    { new Guid("8dae8515-f9d2-4a0a-99d6-802e5dc32b24"), "Daimler", "Green", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2486), "eCitaro", null },
                    { new Guid("a4c64e69-05a5-4867-aafa-42bd910d266c"), "MAN", "Orange", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2490), "City 12", null },
                    { new Guid("d948da10-a6c1-4525-b188-c32932659631"), "Volvo", "Black", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2496), "9900", null },
                    { new Guid("e2440af9-109e-4b8f-a2dc-a9eb461e0c77"), "Scania", "Burgundy", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2500), "Interlink", null },
                    { new Guid("ed6ba202-49c7-4d57-9689-6da91066afab"), "Yutong", "White", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2502), "GT12", null }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "Color", "CreatedAt", "Headlights", "Model", "UpdatedAt", "Wheels" },
                values: new object[,]
                {
                    { new Guid("0ed353d7-a4f2-4285-b571-de43bd22413d"), "BMW", "Black", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2337), true, "X5", null, 4 },
                    { new Guid("18149c8e-a5f1-418b-893c-743b378a60f6"), "Nissan", "Blue", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2357), false, "Altima", null, 4 },
                    { new Guid("21233118-143c-46f5-ba23-24f837ad153a"), "Ford", "Blue", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2334), false, "Mustang", null, 4 },
                    { new Guid("29af5dd2-4a1d-4414-9526-ed8f1551efa6"), "Audi", "Silver", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2350), true, "A4", null, 4 },
                    { new Guid("56f6649f-da11-4d3a-818d-b9f78ee08e56"), "Volkswagen", "Black", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2353), false, "Golf", null, 4 },
                    { new Guid("59b9c480-59f1-4949-8e4f-9391f0feba37"), "Mercedes-Benz", "White", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2348), true, "E-Class", null, 4 },
                    { new Guid("9351859b-8491-497c-9c07-72485a8bd949"), "Toyota", "Red", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2324), true, "Corolla", null, 4 },
                    { new Guid("9482a17b-1a0e-4403-baa0-78751233e921"), "Hyundai", "Red", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2358), true, "Elantra", null, 4 },
                    { new Guid("a5c5bb9d-e0c9-4494-b681-c97f3ac5affb"), "Honda", "Silver", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2339), false, "Civic", null, 4 },
                    { new Guid("bf9a64ca-bdb2-4cfc-a29d-035e98d18b07"), "Chevrolet", "Yellow", new DateTime(2023, 7, 7, 21, 39, 10, 994, DateTimeKind.Local).AddTicks(2355), true, "Camaro", null, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boats");

            migrationBuilder.DropTable(
                name: "Buses");

            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
