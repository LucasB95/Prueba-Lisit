using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prueba_Lisit.Models;

namespace Prueba_Lisit.Data
{
    public class Prueba_LisitContext : DbContext
    {

        public DbSet<Prueba_Lisit.Models.Usuario> Usuario { get; set; }
        public Prueba_LisitContext (DbContextOptions<Prueba_LisitContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Properties.Resources.ConnectionStrings);
        }
        public Prueba_LisitContext()
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //nombre de la tabla
            modelBuilder.Entity<Usuario>()
                .ToTable("Usuario")
                .HasKey(u => u.ID);
            //propiedades de los datos
            modelBuilder.Entity<Usuario>(
                usr =>
                {
                    usr.Property(u => u.Nombre).HasColumnType("varchar(50)");
                    usr.Property(u => u.Apellido).HasColumnType("varchar(50)");
                    usr.Property(u => u.Mail).HasColumnType("varchar(50)");
                    usr.Property(u => u.Edad).HasColumnType("int");
                    usr.Property(u => u.DNI).HasColumnType("int");
                });
        }
    }
}
