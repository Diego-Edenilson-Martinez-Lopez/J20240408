using Microsoft.EntityFrameworkCore;
using J20240408.EntidadesDeNegocio;


namespace J20240408.AccesoADatos
{
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
            public DbSet<PersonaJ> personasJ { get; set; }
        }
}
