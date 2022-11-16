using Microsoft.EntityFrameworkCore;
using PruebaAxa.Models;

namespace PruebaAxa.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<PolizaVehiculos> PolizaVehiculos { get; set; }
        public DbSet<VehiculosPersona> VehiculosPersonas { get; set; }
        public DbSet<DatosCliente> DatosClientes { get; set; }
    }
}
