using FirstTask.Configurations;
using FirstTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstTask
{
    public class AppDbContext : DbContext
    {
        public DbSet<Tip> Tips { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TipsConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
