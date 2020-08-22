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
                        new Sheet1(){ ID = 1 , nume = @"BAGDI ARON", luna = 201807M, generated_1 = @"0", generated_2 = @"CO", generated_3 = @"CO", generated_4 = @"CO", generated_5 = @"CO", generated_6 = @"CO", generated_7 = @"0", generated_8 = @"0", generated_9 = @"CO", generated_10 = @"CO", generated_11 = @"CO", generated_12 = @"CO", generated_13 = @"CO", generated_14 = 0M, generated_15 = 0M, generated_16 = @"CO", generated_17 = @"8", generated_18 = @"8", generated_19 = @"8", generated_20 = @"8", generated_21 = @"0", generated_22 = 0M, generated_23 = 8M, generated_24 = @"8", generated_25 = 8M, generated_26 = 8M, generated_27 = @"8", generated_28 = @"0", generated_29 = 0M, generated_30 = @"8", generated_31 = @"8" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ ID = 2 , nume = @"BAGDI ARON", luna = 201812M, generated_1 = @"0", generated_2 = @"0", generated_3 = @"8", generated_4 = @"8", generated_5 = @"8", generated_6 = @"8", generated_7 = @"8", generated_8 = @"0", generated_9 = @"0", generated_10 = @"8", generated_11 = @"8", generated_12 = @"8", generated_13 = @"8", generated_14 = 8M, generated_15 = 0M, generated_16 = @"0", generated_17 = @"CO", generated_18 = @"CO", generated_19 = @"CO", generated_20 = @"CO", generated_21 = @"CO", generated_22 = 0M, generated_23 = 0M, generated_24 = @"CO", generated_25 = 0M, generated_26 = 0M, generated_27 = @"CO", generated_28 = @"CO", generated_29 = 0M, generated_30 = @"0", generated_31 = @"CO" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ ID = 3 , nume = @"BAGDI ARON", luna = 201906M, generated_1 = @"0", generated_2 = @"0", generated_3 = @"8", generated_4 = @"8", generated_5 = @"8", generated_6 = @"8", generated_7 = @"8", generated_8 = @"0", generated_9 = @"0", generated_10 = @"8", generated_11 = @"8", generated_12 = @"8", generated_13 = @"8", generated_14 = 8M, generated_15 = 0M, generated_16 = @"0", generated_17 = @"0", generated_18 = @"8", generated_19 = @"8", generated_20 = @"8", generated_21 = @"8", generated_22 = 0M, generated_23 = 0M, generated_24 = @"8", generated_25 = 8M, generated_26 = 8M, generated_27 = @"CO", generated_28 = @"CO", generated_29 = 0M, generated_30 = @"0", generated_31 = @"0" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ ID = 4 , nume = @"BAGDI ARON", luna = 201907M, generated_1 = @"CO", generated_2 = @"CO", generated_3 = @"CO", generated_4 = @"CO", generated_5 = @"CO", generated_6 = @"0", generated_7 = @"0", generated_8 = @"CO", generated_9 = @"CO", generated_10 = @"CO", generated_11 = @"CO", generated_12 = @"CO", generated_13 = @"0", generated_14 = 0M, generated_15 = 8M, generated_16 = @"8", generated_17 = @"8", generated_18 = @"8", generated_19 = @"8", generated_20 = @"0", generated_21 = @"0", generated_22 = 8M, generated_23 = 8M, generated_24 = @"8", generated_25 = 8M, generated_26 = 8M, generated_27 = @"0", generated_28 = @"0", generated_29 = 8M, generated_30 = @"8", generated_31 = @"8" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ ID = 5 , nume = @"BAGDI ARON", luna = 201911M, generated_1 = @"CO", generated_2 = @"0", generated_3 = @"0", generated_4 = @"CO", generated_5 = @"CO", generated_6 = @"CO", generated_7 = @"CO", generated_8 = @"CO", generated_9 = @"0", generated_10 = @"0", generated_11 = @"CO", generated_12 = @"CO", generated_13 = @"CO", generated_14 = 8M, generated_15 = 8M, generated_16 = @"0", generated_17 = @"0", generated_18 = @"8", generated_19 = @"8", generated_20 = @"8", generated_21 = @"8", generated_22 = 8M, generated_23 = 0M, generated_24 = @"0", generated_25 = 8M, generated_26 = 8M, generated_27 = @"8", generated_28 = @"8", generated_29 = 8M, generated_30 = @"0", generated_31 = @"0" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ ID = 6 , nume = @"BAGDI ARON", luna = 201912M, generated_1 = @"0", generated_2 = @"8", generated_3 = @"8", generated_4 = @"8", generated_5 = @"8", generated_6 = @"8", generated_7 = @"0", generated_8 = @"0", generated_9 = @"8", generated_10 = @"8", generated_11 = @"8", generated_12 = @"8", generated_13 = @"8", generated_14 = 0M, generated_15 = 0M, generated_16 = @"8", generated_17 = @"8", generated_18 = @"8", generated_19 = @"8", generated_20 = @"8", generated_21 = @"0", generated_22 = 0M, generated_23 = 8M, generated_24 = @"CO", generated_25 = 0M, generated_26 = 0M, generated_27 = @"CO", generated_28 = @"0", generated_29 = 0M, generated_30 = @"CO", generated_31 = @"CO" });
                    
            OnSeed(modelBuilder);


        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        partial void OnSeed(ModelBuilder modelBuilder);       
    }
}