using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Api
{
    public class EmpContext : DbContext
    {
        public EmpContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Employees> Employees
        {
            get;
            set;
        }
    }
}
