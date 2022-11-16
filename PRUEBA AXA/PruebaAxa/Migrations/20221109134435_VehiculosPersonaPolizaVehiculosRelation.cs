using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaAxa.Migrations
{
    /// <inheritdoc />
    public partial class VehiculosPersonaPolizaVehiculosRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PolizaVehiculos",
                columns: table => new
                {
                    idPoliza = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaExpedicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaVencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaGrabacion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    VehiculosPersonaidVehiculo = table.Column<int>(type: "int", nullable: true)
                    //idVehiculo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolizaVehiculos", x => x.idPoliza);
                    table.ForeignKey(
                        name: "FK_PolizaVehiculos_VehiculosPersonas_VehiculosPersonaidVehiculo",
                        column: x => x.VehiculosPersonaidVehiculo,
                        principalTable: "VehiculosPersonas",
                        principalColumn: "idVehiculo");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PolizaVehiculos_VehiculosPersonaidVehiculo",
                table: "PolizaVehiculos",
                column: "VehiculosPersonaidVehiculo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PolizaVehiculos");
        }
    }
}
