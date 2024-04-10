using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using OdemePlanı_7.Entities;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemePlanı_7.DataAccess.Context
{
    public class DenemeDbContext : DbContext
    {
        public DenemeDbContext()
        {
        }

        public DenemeDbContext(DbContextOptions<DenemeDbContext> options) : base(options)
        {

        }
        public DbSet<musteriteklifleriozet_odemesekli> musteriteklifleriozet_odemesekli { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                        .EnableSensitiveDataLogging()
                        .UseSqlServer(@"*****");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
