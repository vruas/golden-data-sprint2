using GoldenData.Models;
using Microsoft.EntityFrameworkCore;


namespace GoldenData.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<CadastroConsumidor> CadastroConsumidor { get; set; }
        public DbSet<CadastroEmpresa> CadastroEmpresa { get; set; }
        public DbSet<InfoConsumidor> InfoConsumidor { get; set; }
    }
}

