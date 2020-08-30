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
                        new Sheet1(){ id = 1 , firstname = @"NA", lastname = @"AB" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 2 , firstname = @"NB", lastname = @"AC" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 3 , firstname = @"NC", lastname = @"AD" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 4 , firstname = @"Nd", lastname = @"AE" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 5 , firstname = @"NE", lastname = @"AF" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 6 , firstname = @"NF", lastname = @"AG" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 7 , firstname = @"NG", lastname = @"AH" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 8 , firstname = @"NH", lastname = @"AI" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 9 , firstname = @"NI", lastname = @"AJ" });
                    
            OnSeed(modelBuilder);


        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        partial void OnSeed(ModelBuilder modelBuilder);       
    }
}