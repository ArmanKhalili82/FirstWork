using FirstWork.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstWork.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer(@"Server=.;Database=FirstTable;Encrypt=False;Integrated Security=True");

        public DbSet<Table> Tables { get; set; }
    }
}
