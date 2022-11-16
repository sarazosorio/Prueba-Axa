using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaAxa.Migrations
{
    /// <inheritdoc />
    public partial class DatosClienteVehiculosPersonaRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VehiculosPersonas",
                columns: table => new
                {
                    idVehiculo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    placaVehiculo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    marcaVehiculo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    modeloVehiculo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    tipoServicio = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    colorVehiculo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    serialMotor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    fechaGrabacion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    DatosClienteIdCliente = table.Column<int>(type: "int", nullable: true)
                    //IdCliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiculosPersonas", x => x.idVehiculo);
                    table.ForeignKey(
                        name: "FK_VehiculosPersonas_DatosClientes_DatosClienteIdCliente",
                        column: x => x.DatosClienteIdCliente,
                        principalTable: "DatosClientes",
                        principalColumn: "idCliente");
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehiculosPersonas_DatosClienteIdCliente",
                table: "VehiculosPersonas",
                column: "DatosClienteIdCliente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehiculosPersonas");
        }
    }
}
