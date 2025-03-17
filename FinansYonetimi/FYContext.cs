using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FinansYonetimi
{
    public class FYContext : DbContext
    {
        public DbSet<Receivable> Receivables { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-KS9G7QU\\SQLEXPRESS;Initial Catalog=FyDatabase;Integrated Security=True;Pooling=False;Encrypt=False;Trust Server Certificate=True");
        }
    }
}
