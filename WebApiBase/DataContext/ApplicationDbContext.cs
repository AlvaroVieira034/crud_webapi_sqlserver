using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using WebApiBase.Models;

namespace WebApiBase.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }

    }
}
