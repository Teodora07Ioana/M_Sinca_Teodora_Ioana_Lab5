using Microsoft.EntityFrameworkCore;

namespace M_Sinca_Teodora_Ioana_Lab5.Models
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options) : base(options)
        {

        }
        public DbSet<Expenses> Expenses { get; set; }

        public DbSet<ExpenseDTO> ExpenseDTO { get; set; }
    }
}
