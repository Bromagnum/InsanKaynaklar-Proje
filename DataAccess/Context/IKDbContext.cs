using DAL.Entities.Concretes;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class IKDbContext : IdentityDbContext
    {
        public IKDbContext() { }

        public IKDbContext(DbContextOptions<IKDbContext> options) : base(options) { }

        public DbSet<Personel> Personels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=IKProject;User Id=Bromagnum\\GÖKTUĞ;TrustServerCertificate=True;Trusted_Connection=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Personel>().ToTable("Personels");
            modelBuilder.Entity<Personel>().Property(p => p.Ad).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Personel>().Property(p => p.SoyAd).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Personel>().Property(p => p.Email).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Personel>().Property(p => p.TCNo).HasMaxLength(11);
            modelBuilder.Entity<Personel>().Property(p => p.TelefonNo).HasMaxLength(15);
        }
    }
}
