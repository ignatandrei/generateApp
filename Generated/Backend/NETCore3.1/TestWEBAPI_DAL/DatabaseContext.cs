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
                        new Sheet1(){ id = 1 , customercommercial_customeridout = 1M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 2 , customercommercial_customeridout = 2M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 3 , customercommercial_customeridout = 3M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 4 , customercommercial_customeridout = 4M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 5 , customercommercial_customeridout = 5M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 6 , customercommercial_customeridout = 6M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 7 , customercommercial_customeridout = 7M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 8 , customercommercial_customeridout = 8M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 9 , customercommercial_customeridout = 9M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 10 , customercommercial_customeridout = 10M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 11 , customercommercial_customeridout = 11M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 12 , customercommercial_customeridout = 12M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 13 , customercommercial_customeridout = 13M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 14 , customercommercial_customeridout = 14M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 15 , customercommercial_customeridout = 15M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 16 , customercommercial_customeridout = 16M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 17 , customercommercial_customeridout = 17M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 18 , customercommercial_customeridout = 18M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 19 , customercommercial_customeridout = 19M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 20 , customercommercial_customeridout = 20M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 21 , customercommercial_customeridout = 21M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 22 , customercommercial_customeridout = 22M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 23 , customercommercial_customeridout = 23M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 24 , customercommercial_customeridout = 24M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 25 , customercommercial_customeridout = 25M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 26 , customercommercial_customeridout = 26M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 27 , customercommercial_customeridout = 27M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 28 , customercommercial_customeridout = 28M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 29 , customercommercial_customeridout = 29M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 30 , customercommercial_customeridout = 30M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 31 , customercommercial_customeridout = 31M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 32 , customercommercial_customeridout = 32M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 33 , customercommercial_customeridout = 33M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 34 , customercommercial_customeridout = 34M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 35 , customercommercial_customeridout = 35M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 36 , customercommercial_customeridout = 36M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 37 , customercommercial_customeridout = 37M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 38 , customercommercial_customeridout = 38M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 39 , customercommercial_customeridout = 39M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 40 , customercommercial_customeridout = 40M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 41 , customercommercial_customeridout = 41M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 42 , customercommercial_customeridout = 42M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 43 , customercommercial_customeridout = 43M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 44 , customercommercial_customeridout = 44M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 45 , customercommercial_customeridout = 45M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 46 , customercommercial_customeridout = 46M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 47 , customercommercial_customeridout = 47M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 48 , customercommercial_customeridout = 48M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 49 , customercommercial_customeridout = 49M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 50 , customercommercial_customeridout = 50M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 51 , customercommercial_customeridout = 51M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 52 , customercommercial_customeridout = 52M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 53 , customercommercial_customeridout = 53M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 54 , customercommercial_customeridout = 54M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 55 , customercommercial_customeridout = 55M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 56 , customercommercial_customeridout = 56M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 57 , customercommercial_customeridout = 57M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 58 , customercommercial_customeridout = 58M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 59 , customercommercial_customeridout = 59M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 60 , customercommercial_customeridout = 60M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 61 , customercommercial_customeridout = 61M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 62 , customercommercial_customeridout = 62M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 63 , customercommercial_customeridout = 63M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 64 , customercommercial_customeridout = 64M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 65 , customercommercial_customeridout = 65M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 66 , customercommercial_customeridout = 66M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 67 , customercommercial_customeridout = 67M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 68 , customercommercial_customeridout = 68M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 69 , customercommercial_customeridout = 69M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 70 , customercommercial_customeridout = 70M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 71 , customercommercial_customeridout = 71M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 72 , customercommercial_customeridout = 72M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 73 , customercommercial_customeridout = 73M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 74 , customercommercial_customeridout = 74M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 75 , customercommercial_customeridout = 75M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 76 , customercommercial_customeridout = 76M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 77 , customercommercial_customeridout = 77M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 78 , customercommercial_customeridout = 78M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 79 , customercommercial_customeridout = 79M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 80 , customercommercial_customeridout = 80M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 81 , customercommercial_customeridout = 81M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 82 , customercommercial_customeridout = 82M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 83 , customercommercial_customeridout = 83M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 84 , customercommercial_customeridout = 84M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 85 , customercommercial_customeridout = 85M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 86 , customercommercial_customeridout = 86M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 87 , customercommercial_customeridout = 87M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 88 , customercommercial_customeridout = 88M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 89 , customercommercial_customeridout = 89M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 90 , customercommercial_customeridout = 90M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 91 , customercommercial_customeridout = 91M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 92 , customercommercial_customeridout = 92M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 93 , customercommercial_customeridout = 93M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 94 , customercommercial_customeridout = 94M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 95 , customercommercial_customeridout = 95M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 96 , customercommercial_customeridout = 96M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 97 , customercommercial_customeridout = 97M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 98 , customercommercial_customeridout = 98M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 99 , customercommercial_customeridout = 99M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 100 , customercommercial_customeridout = 100M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 101 , customercommercial_customeridout = 101M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 102 , customercommercial_customeridout = 102M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 103 , customercommercial_customeridout = 103M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 104 , customercommercial_customeridout = 104M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 105 , customercommercial_customeridout = 105M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 106 , customercommercial_customeridout = 106M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 107 , customercommercial_customeridout = 107M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 108 , customercommercial_customeridout = 108M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 109 , customercommercial_customeridout = 109M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 110 , customercommercial_customeridout = 110M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 111 , customercommercial_customeridout = 111M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 112 , customercommercial_customeridout = 112M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 113 , customercommercial_customeridout = 113M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 114 , customercommercial_customeridout = 114M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 115 , customercommercial_customeridout = 115M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 116 , customercommercial_customeridout = 116M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 117 , customercommercial_customeridout = 117M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 118 , customercommercial_customeridout = 118M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 119 , customercommercial_customeridout = 119M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 120 , customercommercial_customeridout = 120M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 121 , customercommercial_customeridout = 121M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 122 , customercommercial_customeridout = 122M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 123 , customercommercial_customeridout = 123M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 124 , customercommercial_customeridout = 124M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 125 , customercommercial_customeridout = 125M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 126 , customercommercial_customeridout = 126M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 127 , customercommercial_customeridout = 127M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 128 , customercommercial_customeridout = 128M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 129 , customercommercial_customeridout = 129M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 130 , customercommercial_customeridout = 130M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 131 , customercommercial_customeridout = 131M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 132 , customercommercial_customeridout = 132M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 133 , customercommercial_customeridout = 133M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 134 , customercommercial_customeridout = 134M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 135 , customercommercial_customeridout = 135M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 136 , customercommercial_customeridout = 136M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 137 , customercommercial_customeridout = 137M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 138 , customercommercial_customeridout = 138M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 139 , customercommercial_customeridout = 139M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 140 , customercommercial_customeridout = 140M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 141 , customercommercial_customeridout = 141M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 142 , customercommercial_customeridout = 142M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 143 , customercommercial_customeridout = 143M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 144 , customercommercial_customeridout = 144M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 145 , customercommercial_customeridout = 145M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 146 , customercommercial_customeridout = 146M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 147 , customercommercial_customeridout = 147M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 148 , customercommercial_customeridout = 148M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 149 , customercommercial_customeridout = 149M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 150 , customercommercial_customeridout = 150M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 151 , customercommercial_customeridout = 151M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 152 , customercommercial_customeridout = 152M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 153 , customercommercial_customeridout = 153M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 154 , customercommercial_customeridout = 154M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 155 , customercommercial_customeridout = 155M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 156 , customercommercial_customeridout = 156M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 157 , customercommercial_customeridout = 157M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 158 , customercommercial_customeridout = 158M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 159 , customercommercial_customeridout = 159M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 160 , customercommercial_customeridout = 160M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 161 , customercommercial_customeridout = 161M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 162 , customercommercial_customeridout = 162M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 163 , customercommercial_customeridout = 163M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 164 , customercommercial_customeridout = 164M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 165 , customercommercial_customeridout = 165M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 166 , customercommercial_customeridout = 166M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 167 , customercommercial_customeridout = 167M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 168 , customercommercial_customeridout = 168M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 169 , customercommercial_customeridout = 169M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 170 , customercommercial_customeridout = 170M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 171 , customercommercial_customeridout = 171M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 172 , customercommercial_customeridout = 172M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 173 , customercommercial_customeridout = 173M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 174 , customercommercial_customeridout = 174M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 175 , customercommercial_customeridout = 175M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 176 , customercommercial_customeridout = 176M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 177 , customercommercial_customeridout = 177M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 178 , customercommercial_customeridout = 178M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 179 , customercommercial_customeridout = 179M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 180 , customercommercial_customeridout = 180M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 181 , customercommercial_customeridout = 181M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 182 , customercommercial_customeridout = 182M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 183 , customercommercial_customeridout = 183M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 184 , customercommercial_customeridout = 184M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 185 , customercommercial_customeridout = 185M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 186 , customercommercial_customeridout = 186M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 187 , customercommercial_customeridout = 187M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 188 , customercommercial_customeridout = 188M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 189 , customercommercial_customeridout = 189M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 190 , customercommercial_customeridout = 190M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 191 , customercommercial_customeridout = 191M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 192 , customercommercial_customeridout = 192M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 193 , customercommercial_customeridout = 193M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 194 , customercommercial_customeridout = 194M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 195 , customercommercial_customeridout = 195M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 196 , customercommercial_customeridout = 196M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 197 , customercommercial_customeridout = 197M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 198 , customercommercial_customeridout = 198M, customercommercial_pricelistidout = @"CT.9" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 199 , customercommercial_customeridout = 199M, customercommercial_pricelistidout = @"Baza" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id = 200 , customercommercial_customeridout = 200M, customercommercial_pricelistidout = @"Baza" });
                    
            OnSeed(modelBuilder);


        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        partial void OnSeed(ModelBuilder modelBuilder);       
    }
}