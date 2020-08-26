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

            public virtual DbSet<PropertySheet20032020> PropertySheet20032020{ get; set; }
                    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<PropertySheet20032020>()
                .HasKey(it=>it.id);
         
            OnModelCreatingPartial(modelBuilder);
            Seed(modelBuilder);
        }
        void Seed(ModelBuilder modelBuilder){


                    modelBuilder.Entity<PropertySheet20032020>().HasData(
                        new PropertySheet20032020(){ id = 1 , address = @"71 INVERMORE", column1 = @"", date = @"", worktobeundertaken = @"ON HOLD", column2 = @"", column3 = @"", column4 = @"" });
                    
                    modelBuilder.Entity<PropertySheet20032020>().HasData(
                        new PropertySheet20032020(){ id = 2 , address = @"44 THE OAKS", column1 = @"", date = @"", worktobeundertaken = @"COMPLETED", column2 = @"", column3 = @"", column4 = @"" });
                    
                    modelBuilder.Entity<PropertySheet20032020>().HasData(
                        new PropertySheet20032020(){ id = 3 , address = @"60 THE OAKS", column1 = @"", date = @"", worktobeundertaken = @"COMPLETED", column2 = @"", column3 = @"", column4 = @"" });
                    
                    modelBuilder.Entity<PropertySheet20032020>().HasData(
                        new PropertySheet20032020(){ id = 4 , address = @"34 DAWSON", column1 = @"", date = @"", worktobeundertaken = @"COMPLETED", column2 = @"", column3 = @"", column4 = @"" });
                    
                    modelBuilder.Entity<PropertySheet20032020>().HasData(
                        new PropertySheet20032020(){ id = 5 , address = @"82 HUDSON", column1 = @"", date = @"43910", worktobeundertaken = @"SECOND FIX PM", column2 = @"", column3 = @"", column4 = @"" });
                    
                    modelBuilder.Entity<PropertySheet20032020>().HasData(
                        new PropertySheet20032020(){ id = 6 , address = @"75 THE OAKS", column1 = @"", date = @"43910", worktobeundertaken = @"SECOND FIX AM", column2 = @"", column3 = @"", column4 = @"" });
                    
                    modelBuilder.Entity<PropertySheet20032020>().HasData(
                        new PropertySheet20032020(){ id = 7 , address = @"40 THE OAKS", column1 = @"", date = @"", worktobeundertaken = @"COMPLETED", column2 = @"", column3 = @"", column4 = @"" });
                    
                    modelBuilder.Entity<PropertySheet20032020>().HasData(
                        new PropertySheet20032020(){ id = 8 , address = @"8 SANDBACK", column1 = @"", date = @"43910", worktobeundertaken = @"DECS", column2 = @"", column3 = @"", column4 = @"" });
                    
                    modelBuilder.Entity<PropertySheet20032020>().HasData(
                        new PropertySheet20032020(){ id = 9 , address = @"26 SANDBACK", column1 = @"", date = @"43910", worktobeundertaken = @"NO WORK TODAY", column2 = @"", column3 = @"", column4 = @"" });
                    
                    modelBuilder.Entity<PropertySheet20032020>().HasData(
                        new PropertySheet20032020(){ id = 10 , address = @"32 BERYL HOUSE", column1 = @"", date = @"43910", worktobeundertaken = @"DECS", column2 = @"", column3 = @"", column4 = @"" });
                    
                    modelBuilder.Entity<PropertySheet20032020>().HasData(
                        new PropertySheet20032020(){ id = 11 , address = @"10 GALENA", column1 = @"", date = @"43910", worktobeundertaken = @"DECS", column2 = @"", column3 = @"", column4 = @"" });
                    
                    modelBuilder.Entity<PropertySheet20032020>().HasData(
                        new PropertySheet20032020(){ id = 12 , address = @"49 BURRAGE", column1 = @"", date = @"43910", worktobeundertaken = @"NO WORK TODAY", column2 = @"", column3 = @"", column4 = @"" });
                    
                    modelBuilder.Entity<PropertySheet20032020>().HasData(
                        new PropertySheet20032020(){ id = 13 , address = @"13 PATTISON", column1 = @"", date = @"43910", worktobeundertaken = @"NO WORK TODAY", column2 = @"", column3 = @"", column4 = @"" });
                    
                    modelBuilder.Entity<PropertySheet20032020>().HasData(
                        new PropertySheet20032020(){ id = 14 , address = @"6 CRYSTAL", column1 = @"", date = @"43910", worktobeundertaken = @"NO WORK TODAY", column2 = @"", column3 = @"", column4 = @"" });
                    
                    modelBuilder.Entity<PropertySheet20032020>().HasData(
                        new PropertySheet20032020(){ id = 15 , address = @"45 THE OAKS", column1 = @"", date = @"43910", worktobeundertaken = @"PLUMBING RENEW BATH", column2 = @"", column3 = @"", column4 = @"" });
                    
                    modelBuilder.Entity<PropertySheet20032020>().HasData(
                        new PropertySheet20032020(){ id = 16 , address = @"26 CLAYMILL", column1 = @"", date = @"43910", worktobeundertaken = @"PLUMBING RENEW BATH", column2 = @"", column3 = @"", column4 = @"" });
                    
            OnSeed(modelBuilder);


        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        partial void OnSeed(ModelBuilder modelBuilder);       
    }
}