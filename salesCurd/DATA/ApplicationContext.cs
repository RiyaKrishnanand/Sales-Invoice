using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace salesCurd.DATA
{
    public class ApplicationContext : DbContext
    {
        public DbSet<MODELS.Invoice> Invoices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=master;Integrated Security=True");
        }
    }
}
