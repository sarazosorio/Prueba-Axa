using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaAxa.Migrations
{
    /// <inheritdoc />
    public partial class CiudadPolizaVehiculosRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CiudadidCiudad",
                table: "PolizaVehiculos",
                type: "int",
                nullable: true);

            //migrationBuilder.AddColumn<int>(
            //    name: "idCiudad",
            //    table: "PolizaVehiculos",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PolizaVehiculos_CiudadidCiudad",
                table: "PolizaVehiculos",
                column: "CiudadidCiudad");

            migrationBuilder.AddForeignKey(
                name: "FK_PolizaVehiculos_Ciudades_CiudadidCiudad",
                table: "PolizaVehiculos",
                column: "CiudadidCiudad",
                principalTable: "Ciudades",
                principalColumn: "idCiudad");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PolizaVehiculos_Ciudades_CiudadidCiudad",
                table: "PolizaVehiculos");

            migrationBuilder.DropIndex(
                name: "IX_PolizaVehiculos_CiudadidCiudad",
                table: "PolizaVehiculos");

            migrationBuilder.DropColumn(
                name: "CiudadidCiudad",
                table: "PolizaVehiculos");

            //migrationBuilder.DropColumn(
            //    name: "idCiudad",
            //    table: "PolizaVehiculos");
        }
    }
}
