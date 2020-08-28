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

            public virtual DbSet<Sheet1> Sheet1{ get; set; }
                    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Sheet1>()
                .HasKey(it=>it.id);
         
            OnModelCreatingPartial(modelBuilder);
            Seed(modelBuilder);
        }
        void Seed(ModelBuilder modelBuilder){


                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 1 , coloana1 = @"Rand 1 1", coloana2 = @"Rand 1 2", coloana3 = @"Rand 1 3", coloana4 = @"Rand 1 4", coloana5 = @"Rand 1 5", coloana6 = @"Rand 1 6", coloana7 = @"Rand 1 7", coloana8 = @"Rand 1 8", coloana9 = @"Rand 1 9", coloana10 = @"Rand 1 10" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 2 , coloana1 = @"Rand 2 1", coloana2 = @"Rand 2 2", coloana3 = @"Rand 2 3", coloana4 = @"Rand 2 4", coloana5 = @"Rand 2 5", coloana6 = @"Rand 2 6", coloana7 = @"Rand 2 7", coloana8 = @"Rand 2 8", coloana9 = @"Rand 2 9", coloana10 = @"Rand 2 10" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 3 , coloana1 = @"Rand 3 1", coloana2 = @"Rand 3 2", coloana3 = @"Rand 3 3", coloana4 = @"Rand 3 4", coloana5 = @"Rand 3 5", coloana6 = @"Rand 3 6", coloana7 = @"Rand 3 7", coloana8 = @"Rand 3 8", coloana9 = @"Rand 3 9", coloana10 = @"Rand 3 10" });
                    
            OnSeed(modelBuilder);


        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        partial void OnSeed(ModelBuilder modelBuilder);       
    }
}