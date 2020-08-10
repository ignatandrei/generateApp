using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TestWebAPI_BL;

namespace TestWEBAPI_DAL
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {

        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
        {
        }

            public virtual DbSet<Sheet1> Sheet1 { get; set; }
                    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Sheet1>(entity =>
            {
                //entity.Property(e => e.Name).IsUnicode(false);
            });
         
            OnModelCreatingPartial(modelBuilder);
            Seed(modelBuilder);
        }
        void Seed(ModelBuilder modelBuilder){


                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ ID = 1 , Brand = @"Redmi 8", Beneficiar = @"Luminita Daghie", Departament = @"", SerieSim = @"", NumarTelefon = @"", Firma = @"Farmavet" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ ID = 2 , Brand = @"Redmi 9", Beneficiar = @"Daniela Dalea", Departament = @"Aprovizionare", SerieSim = @"", NumarTelefon = @"", Firma = @"Pasteur" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ ID = 3 , Brand = @"Redmi 9", Beneficiar = @"Rodica Pietris", Departament = @"Aprovizionare", SerieSim = @"1906032528080", NumarTelefon = @"", Firma = @"Pasteur" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ ID = 4 , Brand = @"Redmi 9", Beneficiar = @"Carmen Dobrota", Departament = @"Aprovizionare", SerieSim = @"1911271550118", NumarTelefon = @"", Firma = @"Pasteur" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ ID = 5 , Brand = @"Redmi 9", Beneficiar = @"Georgiana Mitran", Departament = @"Aprovizionare", SerieSim = @"1911271550183", NumarTelefon = @"", Firma = @"Pasteur" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ ID = 6 , Brand = @"Redmi 9", Beneficiar = @"Despina Nita", Departament = @"Cercetare Dezvoltare", SerieSim = @"1911271550191", NumarTelefon = @"", Firma = @"Pasteur" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ ID = 7 , Brand = @"Redmi 9", Beneficiar = @"Costinela Samoila", Departament = @"Banca de Tulpini Vaccinale", SerieSim = @"1911271550068", NumarTelefon = @"", Firma = @"Pasteur" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ ID = 8 , Brand = @"Redmi 9", Beneficiar = @"Mirela Popa", Departament = @"Banca de Tulpini Vaccinale", SerieSim = @"", NumarTelefon = @"", Firma = @"Pasteur" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ ID = 9 , Brand = @"Redmi 9", Beneficiar = @"Raluca Bitca", Departament = @"Telesales", SerieSim = @"", NumarTelefon = @"", Firma = @"Farmavet" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ ID = 10 , Brand = @"Redmi 9", Beneficiar = @"Corina Jurca", Departament = @"Telesales", SerieSim = @"", NumarTelefon = @"", Firma = @"Farmavet" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ ID = 11 , Brand = @"Redmi 9", Beneficiar = @" Gabriela Dumitru", Departament = @"Telesales", SerieSim = @"", NumarTelefon = @"", Firma = @"Farmavet" });
                    
            OnSeed(modelBuilder);


        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        partial void OnSeed(ModelBuilder modelBuilder);       
    }
}