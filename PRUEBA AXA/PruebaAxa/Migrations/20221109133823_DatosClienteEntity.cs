using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaAxa.Migrations
{
    /// <inheritdoc />
    public partial class DatosClienteEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DatosClientes",
                columns: table => new
                {
                    idCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    primerNombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    segundoNombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    primerApellido = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    segundoApellido = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    tipoDocumento = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    identificacionCliente = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    numeroTelefono = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    fechaGrabacion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosClientes", x => x.idCliente);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DatosClientes");
        }
    }
}
