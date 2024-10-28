using ApiMedico.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiMedico.Contexts
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Especialidades> Especialidades { get; set; }
        public DbSet<ListadoMedico> ListadoMedicos { get; set; }
    }
}
