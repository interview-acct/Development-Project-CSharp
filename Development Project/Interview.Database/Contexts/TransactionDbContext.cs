using Interview.Database.DAL_Objects;
using Microsoft.EntityFrameworkCore;

namespace Interview.Database.Contexts
{
    public class TransactionDbContext : DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options)
        {

        }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
