using Fotograf.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fotograf.DAL.Contexts
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {

        }
        public SqlDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Fotograf;Trusted_connection=true");
        }

        
        public DbSet<Fotograflar> Fotograflar { get; set; }
        public DbSet<FotograflarKategori> FotograflarKategori { get; set; }
        public DbSet<Menu> Menuler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        
        public DbSet<Tedarikci> Tedarikciler { get; set; }
        public DbSet<Uyeler> Uyeler { get; set; }
        public DbSet<Kargo> Kargolar { get; set; }
        

    }
}
