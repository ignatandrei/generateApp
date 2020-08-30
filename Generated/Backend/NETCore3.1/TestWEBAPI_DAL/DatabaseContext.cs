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

            public virtual DbSet<Employees> Employees{ get; set; }
                    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Employees>()
                .HasKey(it=>it.id);
         
            OnModelCreatingPartial(modelBuilder);
            Seed(modelBuilder);
        }
        void Seed(ModelBuilder modelBuilder){


                    modelBuilder.Entity<Employees>().HasData(
                        new Employees(){ id = 1 , firstname = @"NA", lastname = @"AB" });
                    
                    modelBuilder.Entity<Employees>().HasData(
                        new Employees(){ id = 2 , firstname = @"NB", lastname = @"AC" });
                    
                    modelBuilder.Entity<Employees>().HasData(
                        new Employees(){ id = 3 , firstname = @"NC", lastname = @"AD" });
                    
                    modelBuilder.Entity<Employees>().HasData(
                        new Employees(){ id = 4 , firstname = @"Nd", lastname = @"AE" });
                    
                    modelBuilder.Entity<Employees>().HasData(
                        new Employees(){ id = 5 , firstname = @"NE", lastname = @"AF" });
                    
                    modelBuilder.Entity<Employees>().HasData(
                        new Employees(){ id = 6 , firstname = @"NF", lastname = @"AG" });
                    
                    modelBuilder.Entity<Employees>().HasData(
                        new Employees(){ id = 7 , firstname = @"NG", lastname = @"AH" });
                    
                    modelBuilder.Entity<Employees>().HasData(
                        new Employees(){ id = 8 , firstname = @"NH", lastname = @"AI" });
                    
                    modelBuilder.Entity<Employees>().HasData(
                        new Employees(){ id = 9 , firstname = @"NI", lastname = @"AJ" });
                    
            OnSeed(modelBuilder);


        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        partial void OnSeed(ModelBuilder modelBuilder);       
    }
}