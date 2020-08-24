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

            public virtual DbSet<CollectionProgram_list1> CollectionProgram_list1{ get; set; }
                    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<CollectionProgram_list1>(entity =>
            {
                //entity.Property(e => e.Name).IsUnicode(false);
            });
         
            OnModelCreatingPartial(modelBuilder);
            Seed(modelBuilder);
        }
        void Seed(ModelBuilder modelBuilder){


                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 1 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 40M, volumtotal = 0M, greutatetotala = 649.5M, datastart = @"22/01/2020", timedatastart = 1016M, timedatafinal = 200M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 2 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 137M, volumtotal = 0M, greutatetotala = 2939M, datastart = @"44075", timedatastart = 759M, timedatafinal = 200M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 3 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 83M, volumtotal = 0M, greutatetotala = 1648.5M, datastart = @"44105", timedatastart = 817M, timedatafinal = 200M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 4 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 130M, volumtotal = 0M, greutatetotala = 3128.5M, datastart = @"13/01/2020", timedatastart = 802M, timedatafinal = 200M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 5 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 60M, volumtotal = 0M, greutatetotala = 1339.5M, datastart = @"15/01/2020", timedatastart = 728M, timedatafinal = 1700M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 6 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 149M, volumtotal = 0M, greutatetotala = 2817M, datastart = @"16/01/2020", timedatastart = 829M, timedatafinal = 1747M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 7 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 123M, volumtotal = 0M, greutatetotala = 2505M, datastart = @"20/01/2020", timedatastart = 808M, timedatafinal = 200M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 8 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 70M, volumtotal = 0M, greutatetotala = 1620.5M, datastart = @"21/01/2020", timedatastart = 759M, timedatafinal = 200M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 9 , rutadenumireruta = @"RT-REZ.4.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 99M, volumtotal = 0M, greutatetotala = 2193.5M, datastart = @"23/01/2020", timedatastart = 753M, timedatafinal = 200M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 10 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 1M, volumtotal = 60M, greutatetotala = 0M, datastart = @"22/01/2020", timedatastart = 1221M, timedatafinal = 200M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 11 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 49M, volumtotal = 0M, greutatetotala = 728M, datastart = @"23/01/2020", timedatastart = 753M, timedatafinal = 200M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 12 , rutadenumireruta = @"RT-REZ.5.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 27M, volumtotal = 0M, greutatetotala = 518M, datastart = @"24/01/2020", timedatastart = 753M, timedatafinal = 200M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 13 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 28M, volumtotal = 0M, greutatetotala = 496.5M, datastart = @"24/01/2020", timedatastart = 752M, timedatafinal = 200M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 14 , rutadenumireruta = @"", stare = @"Ended", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 0M, volumtotal = 0M, greutatetotala = 0M, datastart = @"27/01/2020", timedatastart = 755M, timedatafinal = 836M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 15 , rutadenumireruta = @"RT-REZ.1.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 113M, volumtotal = 0M, greutatetotala = 2470.5M, datastart = @"27/01/2020", timedatastart = 756M, timedatafinal = 1921M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 16 , rutadenumireruta = @"RT-REZ.2.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 64M, volumtotal = 0M, greutatetotala = 1176M, datastart = @"28/01/2020", timedatastart = 836M, timedatafinal = 1717M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 17 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 0M, volumtotal = 0M, greutatetotala = 0M, datastart = @"27/01/2020", timedatastart = 834M, timedatafinal = 200M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 18 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 0M, volumtotal = 0M, greutatetotala = 0M, datastart = @"28/01/2020", timedatastart = 836M, timedatafinal = 200M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 19 , rutadenumireruta = @"RT-REZ.3.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 61M, volumtotal = 0M, greutatetotala = 1482M, datastart = @"29/01/2020", timedatastart = 757M, timedatafinal = 1834M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 20 , rutadenumireruta = @"RT-REZ.4.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 108M, volumtotal = 0M, greutatetotala = 2194.5M, datastart = @"30/01/2020", timedatastart = 815M, timedatafinal = 1923M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 21 , rutadenumireruta = @"RT-REZ.5.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 78M, volumtotal = 0M, greutatetotala = 1367M, datastart = @"31/01/2020", timedatastart = 744M, timedatafinal = 1800M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 22 , rutadenumireruta = @"RT-REZ.2.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 55M, volumtotal = 0M, greutatetotala = 1053.5M, datastart = @"43923", timedatastart = 745M, timedatafinal = 1608M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 23 , rutadenumireruta = @"RT-REZ.1.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 145M, volumtotal = 0M, greutatetotala = 3073.5M, datastart = @"43892", timedatastart = 800M, timedatafinal = 1827M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 24 , rutadenumireruta = @"RT-REZ.3.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 73M, volumtotal = 0M, greutatetotala = 1438M, datastart = @"43953", timedatastart = 748M, timedatafinal = 1901M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 25 , rutadenumireruta = @"RT-REZ.4.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 108M, volumtotal = 0M, greutatetotala = 2067M, datastart = @"43984", timedatastart = 804M, timedatafinal = 1813M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 26 , rutadenumireruta = @"RT-REZ.5.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 96M, volumtotal = 0M, greutatetotala = 1673M, datastart = @"44014", timedatastart = 747M, timedatafinal = 1803M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 27 , rutadenumireruta = @"RT-REZ.1.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 117M, volumtotal = 0M, greutatetotala = 2582.5M, datastart = @"44106", timedatastart = 749M, timedatafinal = 1821M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 28 , rutadenumireruta = @"RT-REZ.2.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 64M, volumtotal = 0M, greutatetotala = 1642M, datastart = @"44137", timedatastart = 806M, timedatafinal = 1737M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 29 , rutadenumireruta = @"RT-REZ.3.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 80M, volumtotal = 0M, greutatetotala = 1574.5M, datastart = @"44167", timedatastart = 746M, timedatafinal = 1822M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 30 , rutadenumireruta = @"", stare = @"Started", camionnumarinmatriculare = @"DEV ARCTOS", recipientetotal = 0M, volumtotal = 0M, greutatetotala = 0M, datastart = @"44167", timedatastart = 1150M, timedatafinal = 200M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 31 , rutadenumireruta = @"TestRutaLicenta", stare = @"Ended", camionnumarinmatriculare = @"DEV ARCTOS", recipientetotal = 0M, volumtotal = 0M, greutatetotala = 0M, datastart = @"24/07/2020", timedatastart = 1207M, timedatafinal = 1208M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 32 , rutadenumireruta = @"RT-REZ.4.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 113M, volumtotal = 0M, greutatetotala = 2324.5M, datastart = @"13/02/2020", timedatastart = 754M, timedatafinal = 1749M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 33 , rutadenumireruta = @"", stare = @"Ended", camionnumarinmatriculare = @"DEV ARCTOS", recipientetotal = 10M, volumtotal = 600M, greutatetotala = 231M, datastart = @"43834", timedatastart = 1541M, timedatafinal = 1407M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 34 , rutadenumireruta = @"", stare = @"Ended", camionnumarinmatriculare = @"DEV ARCTOS", recipientetotal = 3M, volumtotal = 120M, greutatetotala = 115.5M, datastart = @"43865", timedatastart = 930M, timedatafinal = 952M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 35 , rutadenumireruta = @"", stare = @"Ended", camionnumarinmatriculare = @"DEV ARCTOS", recipientetotal = 3M, volumtotal = 0M, greutatetotala = 346.5M, datastart = @"43865", timedatastart = 952M, timedatafinal = 2045M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 36 , rutadenumireruta = @"", stare = @"Ended", camionnumarinmatriculare = @"DEV ARCTOS", recipientetotal = 1M, volumtotal = 0M, greutatetotala = 115.5M, datastart = @"43865", timedatastart = 2045M, timedatafinal = 2056M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 37 , rutadenumireruta = @"", stare = @"Ended", camionnumarinmatriculare = @"DEV ARCTOS", recipientetotal = 1M, volumtotal = 0M, greutatetotala = 115.5M, datastart = @"43865", timedatastart = 2056M, timedatafinal = 2101M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 38 , rutadenumireruta = @"", stare = @"Ended", camionnumarinmatriculare = @"DEV ARCTOS", recipientetotal = 1M, volumtotal = 0M, greutatetotala = 115.5M, datastart = @"43865", timedatastart = 2101M, timedatafinal = 2111M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 39 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"DEV ARCTOS", recipientetotal = 8M, volumtotal = 120M, greutatetotala = 693M, datastart = @"43865", timedatastart = 2111M, timedatafinal = 200M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 40 , rutadenumireruta = @"RT-REZ.5.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 85M, volumtotal = 0M, greutatetotala = 1600.5M, datastart = @"14/02/2020", timedatastart = 747M, timedatafinal = 1847M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 41 , rutadenumireruta = @"RT-REZ.1.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 124M, volumtotal = 0M, greutatetotala = 2615M, datastart = @"17/02/2020", timedatastart = 749M, timedatafinal = 1846M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 42 , rutadenumireruta = @"", stare = @"Started", camionnumarinmatriculare = @"DEV ARCTOS", recipientetotal = 0M, volumtotal = 0M, greutatetotala = 0M, datastart = @"17/02/2020", timedatastart = 1029M, timedatafinal = 200M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 43 , rutadenumireruta = @"RT-REZ.2.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 40M, volumtotal = 0M, greutatetotala = 983M, datastart = @"18/02/2020", timedatastart = 814M, timedatafinal = 200M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 44 , rutadenumireruta = @"RT-REZ.2.Z3DJ.01", stare = @"Ended", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 18M, volumtotal = 0M, greutatetotala = 491.5M, datastart = @"18/02/2020", timedatastart = 814M, timedatafinal = 1803M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 45 , rutadenumireruta = @"RT-REZ.3.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 73M, volumtotal = 0M, greutatetotala = 2211M, datastart = @"19/02/2020", timedatastart = 749M, timedatafinal = 1929M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 46 , rutadenumireruta = @"RT-REZ.4.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 104M, volumtotal = 0M, greutatetotala = 2095M, datastart = @"20/02/2020", timedatastart = 746M, timedatafinal = 1838M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 47 , rutadenumireruta = @"RT-REZ.5.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 84M, volumtotal = 0M, greutatetotala = 1989M, datastart = @"21/02/2020", timedatastart = 824M, timedatafinal = 1744M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 48 , rutadenumireruta = @"RT-REZ.1.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 125M, volumtotal = 0M, greutatetotala = 3283.5M, datastart = @"24/02/2020", timedatastart = 745M, timedatafinal = 1805M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 49 , rutadenumireruta = @"RT-REZ.2.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 59M, volumtotal = 0M, greutatetotala = 1517M, datastart = @"25/02/2020", timedatastart = 747M, timedatafinal = 1701M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 50 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 0M, volumtotal = 0M, greutatetotala = 0M, datastart = @"25/02/2020", timedatastart = 747M, timedatafinal = 1702M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 51 , rutadenumireruta = @"RT-REZ.3.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 69M, volumtotal = 0M, greutatetotala = 1768.5M, datastart = @"26/02/2020", timedatastart = 745M, timedatafinal = 1718M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 52 , rutadenumireruta = @"", stare = @"Ended", camionnumarinmatriculare = @"DEV ARCTOS", recipientetotal = 3M, volumtotal = 240M, greutatetotala = 0M, datastart = @"44048", timedatastart = 1543M, timedatafinal = 1611M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 53 , rutadenumireruta = @"", stare = @"Ended", camionnumarinmatriculare = @"DEV ARCTOS", recipientetotal = 15M, volumtotal = 1140M, greutatetotala = 0M, datastart = @"26/02/2020", timedatastart = 1630M, timedatafinal = 1634M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 54 , rutadenumireruta = @"", stare = @"Ended", camionnumarinmatriculare = @"DEV ARCTOS", recipientetotal = 6M, volumtotal = 420M, greutatetotala = 0M, datastart = @"26/02/2020", timedatastart = 1709M, timedatafinal = 1713M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 55 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 0M, volumtotal = 0M, greutatetotala = 0M, datastart = @"26/02/2020", timedatastart = 745M, timedatafinal = 200M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 56 , rutadenumireruta = @"RT-REZ.4.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 103M, volumtotal = 0M, greutatetotala = 2046M, datastart = @"27/02/2020", timedatastart = 759M, timedatafinal = 1730M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 57 , rutadenumireruta = @"RT-REZ.5.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 93M, volumtotal = 0M, greutatetotala = 1668.5M, datastart = @"28/02/2020", timedatastart = 753M, timedatafinal = 1636M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 58 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 0M, volumtotal = 0M, greutatetotala = 0M, datastart = @"28/02/2020", timedatastart = 752M, timedatafinal = 200M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 59 , rutadenumireruta = @"RT-REZ.1.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 135M, volumtotal = 0M, greutatetotala = 2995.5M, datastart = @"43864", timedatastart = 750M, timedatafinal = 1746M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 60 , rutadenumireruta = @"RT-REZ.2.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 63M, volumtotal = 0M, greutatetotala = 1419M, datastart = @"43893", timedatastart = 755M, timedatafinal = 1634M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 61 , rutadenumireruta = @"RT-REZ.3.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 80M, volumtotal = 0M, greutatetotala = 2167.5M, datastart = @"43924", timedatastart = 747M, timedatafinal = 1739M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 62 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 0M, volumtotal = 0M, greutatetotala = 0M, datastart = @"43924", timedatastart = 747M, timedatafinal = 1739M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 63 , rutadenumireruta = @"RT-REZ.4.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 106M, volumtotal = 0M, greutatetotala = 2159M, datastart = @"43954", timedatastart = 759M, timedatafinal = 1628M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 64 , rutadenumireruta = @"", stare = @"Ended", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 0M, volumtotal = 0M, greutatetotala = 0M, datastart = @"43954", timedatastart = 758M, timedatafinal = 1628M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 65 , rutadenumireruta = @"RT-REZ.5.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 87M, volumtotal = 0M, greutatetotala = 1789M, datastart = @"43985", timedatastart = 747M, timedatafinal = 1533M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 66 , rutadenumireruta = @"RT-REZ.1.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 145M, volumtotal = 0M, greutatetotala = 3583M, datastart = @"44077", timedatastart = 746M, timedatafinal = 1857M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 67 , rutadenumireruta = @"RT-REZ.2.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 63M, volumtotal = 0M, greutatetotala = 1654.5M, datastart = @"44107", timedatastart = 801M, timedatafinal = 1555M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 68 , rutadenumireruta = @"RT-REZ.3.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 74M, volumtotal = 0M, greutatetotala = 1589.5M, datastart = @"44138", timedatastart = 748M, timedatafinal = 1723M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 69 , rutadenumireruta = @"RT-REZ.4.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 97M, volumtotal = 0M, greutatetotala = 2204.5M, datastart = @"44168", timedatastart = 745M, timedatafinal = 1632M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 70 , rutadenumireruta = @"RT-REZ.5.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 99M, volumtotal = 0M, greutatetotala = 1818.5M, datastart = @"13/03/2020", timedatastart = 749M, timedatafinal = 1554M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 71 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 0M, volumtotal = 0M, greutatetotala = 0M, datastart = @"13/03/2020", timedatastart = 749M, timedatafinal = 1558M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 72 , rutadenumireruta = @"RT-REZ.1.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 141M, volumtotal = 0M, greutatetotala = 3095.5M, datastart = @"16/03/2020", timedatastart = 755M, timedatafinal = 1807M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 73 , rutadenumireruta = @"RT-REZ.2.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 60M, volumtotal = 0M, greutatetotala = 1413.5M, datastart = @"17/03/2020", timedatastart = 745M, timedatafinal = 1651M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 74 , rutadenumireruta = @"RT-REZ.3.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 60M, volumtotal = 0M, greutatetotala = 1304M, datastart = @"18/03/2020", timedatastart = 754M, timedatafinal = 1634M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 75 , rutadenumireruta = @"RT-REZ.4.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 102M, volumtotal = 0M, greutatetotala = 1813M, datastart = @"19/03/2020", timedatastart = 819M, timedatafinal = 1649M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 76 , rutadenumireruta = @"RT-REZ.5.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 70M, volumtotal = 0M, greutatetotala = 1317M, datastart = @"20/03/2020", timedatastart = 747M, timedatafinal = 1545M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 77 , rutadenumireruta = @"RT-REZ.1.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 108M, volumtotal = 0M, greutatetotala = 1806M, datastart = @"23/03/2020", timedatastart = 753M, timedatafinal = 1618M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 78 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 0M, volumtotal = 0M, greutatetotala = 0M, datastart = @"23/03/2020", timedatastart = 753M, timedatafinal = 1624M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 79 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 0M, volumtotal = 0M, greutatetotala = 0M, datastart = @"23/03/2020", timedatastart = 753M, timedatafinal = 1625M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 80 , rutadenumireruta = @"RT-REZ.3.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 51M, volumtotal = 0M, greutatetotala = 991M, datastart = @"25/03/2020", timedatastart = 750M, timedatafinal = 1535M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 81 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 0M, volumtotal = 0M, greutatetotala = 0M, datastart = @"25/03/2020", timedatastart = 750M, timedatafinal = 1546M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 82 , rutadenumireruta = @"RT-REZ.4.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 72M, volumtotal = 0M, greutatetotala = 1297M, datastart = @"26/03/2020", timedatastart = 741M, timedatafinal = 1535M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 83 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 0M, volumtotal = 0M, greutatetotala = 0M, datastart = @"26/03/2020", timedatastart = 741M, timedatafinal = 200M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 84 , rutadenumireruta = @"RT-REZ.5.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 67M, volumtotal = 0M, greutatetotala = 1516M, datastart = @"27/03/2020", timedatastart = 740M, timedatafinal = 1739M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 85 , rutadenumireruta = @"RT-REZ.1.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 111M, volumtotal = 0M, greutatetotala = 2571M, datastart = @"30/03/2020", timedatastart = 744M, timedatafinal = 1654M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 86 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 0M, volumtotal = 0M, greutatetotala = 0M, datastart = @"30/03/2020", timedatastart = 744M, timedatafinal = 200M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 87 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 0M, volumtotal = 0M, greutatetotala = 0M, datastart = @"30/03/2020", timedatastart = 744M, timedatafinal = 200M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 88 , rutadenumireruta = @"RT-REZ.2.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 68M, volumtotal = 0M, greutatetotala = 1589M, datastart = @"31/03/2020", timedatastart = 747M, timedatafinal = 1523M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 89 , rutadenumireruta = @"RT-REZ.3.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 47M, volumtotal = 0M, greutatetotala = 1187M, datastart = @"43834", timedatastart = 748M, timedatafinal = 1510M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 90 , rutadenumireruta = @"RT-REZ.3.Z2DJ.01", stare = @"Ended", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 47M, volumtotal = 0M, greutatetotala = 633M, datastart = @"43834", timedatastart = 802M, timedatafinal = 1435M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 91 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 70M, volumtotal = 0M, greutatetotala = 1297M, datastart = @"27/03/2020", timedatastart = 715M, timedatafinal = 1628M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 92 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 67M, volumtotal = 0M, greutatetotala = 1164.5M, datastart = @"30/03/2020", timedatastart = 726M, timedatafinal = 1424M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 93 , rutadenumireruta = @"RT-REZ.3.Z2DJ.01", stare = @"Ended", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 22M, volumtotal = 0M, greutatetotala = 228M, datastart = @"43834", timedatastart = 1436M, timedatafinal = 1851M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 94 , rutadenumireruta = @"RT-REZ.4.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 74M, volumtotal = 0M, greutatetotala = 1398M, datastart = @"43865", timedatastart = 744M, timedatafinal = 1422M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 95 , rutadenumireruta = @"RT-REZ.4.Z2DJ.01", stare = @"Ended", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 1M, volumtotal = 0M, greutatetotala = 8M, datastart = @"43865", timedatastart = 729M, timedatafinal = 835M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 96 , rutadenumireruta = @"RT-REZ.4.Z2DJ.01", stare = @"Ended", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 40M, volumtotal = 0M, greutatetotala = 488M, datastart = @"43865", timedatastart = 835M, timedatafinal = 1721M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 97 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 0M, volumtotal = 0M, greutatetotala = 0M, datastart = @"43865", timedatastart = 743M, timedatafinal = 200M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 98 , rutadenumireruta = @"RT-REZ.5.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 47M, volumtotal = 0M, greutatetotala = 871M, datastart = @"43894", timedatastart = 749M, timedatafinal = 1354M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 99 , rutadenumireruta = @"RT-REZ.5.Z2DJ.01", stare = @"Ended", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 25M, volumtotal = 0M, greutatetotala = 329M, datastart = @"43894", timedatastart = 728M, timedatafinal = 1057M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 100 , rutadenumireruta = @"RT-REZ.5.Z2DJ.01", stare = @"Ended", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 55M, volumtotal = 0M, greutatetotala = 1528.5M, datastart = @"43894", timedatastart = 1058M, timedatafinal = 1506M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 101 , rutadenumireruta = @"", stare = @"Ended", camionnumarinmatriculare = @"DEV ARCTOS", recipientetotal = 1M, volumtotal = 0M, greutatetotala = 115.5M, datastart = @"43894", timedatastart = 1240M, timedatafinal = 1242M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 102 , rutadenumireruta = @"", stare = @"Ended", camionnumarinmatriculare = @"DEV ARCTOS", recipientetotal = 6M, volumtotal = 0M, greutatetotala = 693M, datastart = @"43894", timedatastart = 1242M, timedatafinal = 1410M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 103 , rutadenumireruta = @"RT-REZ.5.Z2DJ.01", stare = @"Ended", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 1M, volumtotal = 0M, greutatetotala = 15M, datastart = @"43894", timedatastart = 1508M, timedatafinal = 1521M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 104 , rutadenumireruta = @"RT-REZ.5.Z2DJ.01", stare = @"Ended", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 0M, volumtotal = 0M, greutatetotala = 0M, datastart = @"43894", timedatastart = 1521M, timedatafinal = 1735M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 105 , rutadenumireruta = @"", stare = @"Ended", camionnumarinmatriculare = @"DEV ARCTOS", recipientetotal = 1M, volumtotal = 0M, greutatetotala = 115.5M, datastart = @"43894", timedatastart = 1521M, timedatafinal = 1527M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 106 , rutadenumireruta = @"", stare = @"Ended", camionnumarinmatriculare = @"DEV ARCTOS", recipientetotal = 17M, volumtotal = 1440M, greutatetotala = 0M, datastart = @"43925", timedatastart = 1620M, timedatafinal = 1734M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 107 , rutadenumireruta = @"", stare = @"Ended", camionnumarinmatriculare = @"DEV ARCTOS", recipientetotal = 9M, volumtotal = 720M, greutatetotala = 0M, datastart = @"43925", timedatastart = 1734M, timedatafinal = 1948M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 108 , rutadenumireruta = @"", stare = @"Ended", camionnumarinmatriculare = @"DEV ARCTOS", recipientetotal = 5M, volumtotal = 360M, greutatetotala = 0M, datastart = @"43925", timedatastart = 1948M, timedatafinal = 1957M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 109 , rutadenumireruta = @"", stare = @"Expired", camionnumarinmatriculare = @"DEV ARCTOS", recipientetotal = 0M, volumtotal = 0M, greutatetotala = 0M, datastart = @"43925", timedatastart = 1957M, timedatafinal = 200M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 110 , rutadenumireruta = @"RT-REZ.1.Z2DJ.01", stare = @"Ended", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 6M, volumtotal = 0M, greutatetotala = 201M, datastart = @"43986", timedatastart = 752M, timedatafinal = 817M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 111 , rutadenumireruta = @"RT-REZ.1.Z2DJ.01", stare = @"Ended", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 17M, volumtotal = 0M, greutatetotala = 261.5M, datastart = @"43986", timedatastart = 817M, timedatafinal = 1040M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 112 , rutadenumireruta = @"RT-REZ.1.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 110M, volumtotal = 0M, greutatetotala = 2498M, datastart = @"43986", timedatastart = 743M, timedatafinal = 1700M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 113 , rutadenumireruta = @"", stare = @"Ended", camionnumarinmatriculare = @"DEV ARCTOS", recipientetotal = 3M, volumtotal = 240M, greutatetotala = 0M, datastart = @"43986", timedatastart = 1004M, timedatafinal = 1007M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 114 , rutadenumireruta = @"", stare = @"Ended", camionnumarinmatriculare = @"DEV ARCTOS", recipientetotal = 4M, volumtotal = 300M, greutatetotala = 0M, datastart = @"43986", timedatastart = 1017M, timedatafinal = 1018M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 115 , rutadenumireruta = @"", stare = @"Ended", camionnumarinmatriculare = @"DEV ARCTOS", recipientetotal = 3M, volumtotal = 240M, greutatetotala = 0M, datastart = @"43986", timedatastart = 1039M, timedatafinal = 1040M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 116 , rutadenumireruta = @"RT-REZ.1.Z2DJ.01", stare = @"Ended", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 35M, volumtotal = 0M, greutatetotala = 493.5M, datastart = @"43986", timedatastart = 1041M, timedatafinal = 1541M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 117 , rutadenumireruta = @"RT-REZ.2.Z2DJ.01", stare = @"Ended", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 14M, volumtotal = 0M, greutatetotala = 79.5M, datastart = @"44016", timedatastart = 730M, timedatafinal = 923M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 118 , rutadenumireruta = @"RT-REZ.2.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 45M, volumtotal = 0M, greutatetotala = 1153M, datastart = @"44016", timedatastart = 735M, timedatafinal = 1410M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 119 , rutadenumireruta = @"RT-REZ.2.Z2DJ.01", stare = @"Ended", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 42M, volumtotal = 0M, greutatetotala = 938.5M, datastart = @"44016", timedatastart = 924M, timedatafinal = 1521M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 120 , rutadenumireruta = @"", stare = @"Ended", camionnumarinmatriculare = @"DEV ARCTOS", recipientetotal = 6M, volumtotal = 480M, greutatetotala = 0M, datastart = @"44016", timedatastart = 1529M, timedatafinal = 1532M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 121 , rutadenumireruta = @"RT-REZ.2.Z2DJ.01", stare = @"Ended", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 2M, volumtotal = 120M, greutatetotala = 0M, datastart = @"44016", timedatastart = 1527M, timedatafinal = 1535M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 122 , rutadenumireruta = @"RT-REZ.3.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 65M, volumtotal = 0M, greutatetotala = 2170M, datastart = @"44047", timedatastart = 736M, timedatafinal = 1630M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 123 , rutadenumireruta = @"RT-REZ.3.Z2DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 66M, volumtotal = 0M, greutatetotala = 663M, datastart = @"44047", timedatastart = 746M, timedatafinal = 1652M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 124 , rutadenumireruta = @"RT-REZ.3.Z5DJ.01", stare = @"Started", camionnumarinmatriculare = @"B 34 RDX", recipientetotal = 38M, volumtotal = 0M, greutatetotala = 581M, datastart = @"44047", timedatastart = 717M, timedatafinal = 905M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 125 , rutadenumireruta = @"RT-REZ.4.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 80M, volumtotal = 0M, greutatetotala = 1563.5M, datastart = @"44078", timedatastart = 734M, timedatafinal = 1636M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 126 , rutadenumireruta = @"RT-REZ.4.Z2DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 50M, volumtotal = 0M, greutatetotala = 550.5M, datastart = @"44078", timedatastart = 740M, timedatafinal = 1754M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 127 , rutadenumireruta = @"RT-REZ.4.Z5DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 34 RDX", recipientetotal = 71M, volumtotal = 0M, greutatetotala = 1008M, datastart = @"44078", timedatastart = 708M, timedatafinal = 1233M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 128 , rutadenumireruta = @"RT-REZ.4.Z5DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 34 RDX", recipientetotal = 0M, volumtotal = 0M, greutatetotala = 0M, datastart = @"44078", timedatastart = 1447M, timedatafinal = 1458M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 129 , rutadenumireruta = @"RT-REZ.5.Z2DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 94M, volumtotal = 0M, greutatetotala = 1330M, datastart = @"44108", timedatastart = 747M, timedatafinal = 1701M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 130 , rutadenumireruta = @"RT-REZ.5.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 58M, volumtotal = 0M, greutatetotala = 1024.5M, datastart = @"44108", timedatastart = 745M, timedatafinal = 1604M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 131 , rutadenumireruta = @"RT-REZ.5.Z5DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 34 RDX", recipientetotal = 36M, volumtotal = 0M, greutatetotala = 916.5M, datastart = @"44108", timedatastart = 651M, timedatafinal = 1217M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 132 , rutadenumireruta = @"RT-REZ.1.Z5DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 34 RDX", recipientetotal = 173M, volumtotal = 0M, greutatetotala = 2992M, datastart = @"13/04/2020", timedatastart = 651M, timedatafinal = 1538M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 133 , rutadenumireruta = @"RT-REZ.1.Z2DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 56M, volumtotal = 0M, greutatetotala = 859.5M, datastart = @"13/04/2020", timedatastart = 756M, timedatafinal = 1449M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 134 , rutadenumireruta = @"RT-REZ.1.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 95M, volumtotal = 0M, greutatetotala = 1801M, datastart = @"13/04/2020", timedatastart = 740M, timedatafinal = 1614M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 135 , rutadenumireruta = @"RT-REZ.2.Z5DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 34 RDX", recipientetotal = 48M, volumtotal = 0M, greutatetotala = 745M, datastart = @"14/04/2020", timedatastart = 711M, timedatafinal = 1149M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 136 , rutadenumireruta = @"RT-REZ.2.Z2DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 45M, volumtotal = 0M, greutatetotala = 831M, datastart = @"14/04/2020", timedatastart = 749M, timedatafinal = 1423M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 137 , rutadenumireruta = @"RT-REZ.2.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 54M, volumtotal = 0M, greutatetotala = 1107M, datastart = @"14/04/2020", timedatastart = 803M, timedatafinal = 1540M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 138 , rutadenumireruta = @"RT-REZ.2.Z6DJ.01", stare = @"Ended", camionnumarinmatriculare = @"B 66 RDX", recipientetotal = 11M, volumtotal = 0M, greutatetotala = 106.5M, datastart = @"14/04/2020", timedatastart = 741M, timedatafinal = 945M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 139 , rutadenumireruta = @"", stare = @"Ended", camionnumarinmatriculare = @"B 66 RDX", recipientetotal = 5M, volumtotal = 0M, greutatetotala = 47M, datastart = @"14/04/2020", timedatastart = 945M, timedatafinal = 1012M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 140 , rutadenumireruta = @"", stare = @"Ended", camionnumarinmatriculare = @"B 66 RDX", recipientetotal = 5M, volumtotal = 0M, greutatetotala = 40.5M, datastart = @"14/04/2020", timedatastart = 1012M, timedatafinal = 1045M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 141 , rutadenumireruta = @"", stare = @"Ended", camionnumarinmatriculare = @"B 66 RDX", recipientetotal = 4M, volumtotal = 0M, greutatetotala = 39.5M, datastart = @"14/04/2020", timedatastart = 1045M, timedatafinal = 1121M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 142 , rutadenumireruta = @"RT-REZ.2.Z6DJ.01", stare = @"Ended", camionnumarinmatriculare = @"B 66 RDX", recipientetotal = 7M, volumtotal = 0M, greutatetotala = 80.5M, datastart = @"14/04/2020", timedatastart = 1122M, timedatafinal = 1219M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 143 , rutadenumireruta = @"RT-REZ.2.Z6DJ.01", stare = @"Ended", camionnumarinmatriculare = @"B 66 RDX", recipientetotal = 7M, volumtotal = 0M, greutatetotala = 48M, datastart = @"14/04/2020", timedatastart = 1220M, timedatafinal = 1517M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 144 , rutadenumireruta = @"RT-REZ.3.Z5DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 34 RDX", recipientetotal = 65M, volumtotal = 0M, greutatetotala = 1352.5M, datastart = @"15/04/2020", timedatastart = 712M, timedatafinal = 1102M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 145 , rutadenumireruta = @"RT-REZ.3.Z2DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 75M, volumtotal = 0M, greutatetotala = 768.5M, datastart = @"15/04/2020", timedatastart = 734M, timedatafinal = 1542M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 146 , rutadenumireruta = @"RT-REZ.3.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 63M, volumtotal = 0M, greutatetotala = 1322M, datastart = @"15/04/2020", timedatastart = 749M, timedatafinal = 1621M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 147 , rutadenumireruta = @"RT-REZ.3.Z6DJ.01", stare = @"Ended", camionnumarinmatriculare = @"B 66 RDX", recipientetotal = 1M, volumtotal = 0M, greutatetotala = 10.5M, datastart = @"15/04/2020", timedatastart = 752M, timedatafinal = 928M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 148 , rutadenumireruta = @"RT-REZ.3.Z6DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 66 RDX", recipientetotal = 22M, volumtotal = 0M, greutatetotala = 232.5M, datastart = @"15/04/2020", timedatastart = 752M, timedatafinal = 200M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 149 , rutadenumireruta = @"RT-REZ.4.Z5DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 34 RDX", recipientetotal = 83M, volumtotal = 0M, greutatetotala = 1136M, datastart = @"16/04/2020", timedatastart = 702M, timedatafinal = 1246M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 150 , rutadenumireruta = @"RT-REZ.4.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 99M, volumtotal = 0M, greutatetotala = 2168M, datastart = @"16/04/2020", timedatastart = 728M, timedatafinal = 1543M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 151 , rutadenumireruta = @"RT-REZ.4.Z6DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 66 RDX", recipientetotal = 57M, volumtotal = 0M, greutatetotala = 663M, datastart = @"16/04/2020", timedatastart = 755M, timedatafinal = 1439M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 152 , rutadenumireruta = @"RT-REZ.4.Z2DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 53M, volumtotal = 0M, greutatetotala = 475M, datastart = @"16/04/2020", timedatastart = 740M, timedatafinal = 1529M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 153 , rutadenumireruta = @"RT-REZ.5.Z5DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 34 RDX", recipientetotal = 42M, volumtotal = 0M, greutatetotala = 1366M, datastart = @"17/04/2020", timedatastart = 658M, timedatafinal = 1327M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 154 , rutadenumireruta = @"RT-REZ.5.Z2DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 72M, volumtotal = 0M, greutatetotala = 1620.5M, datastart = @"17/04/2020", timedatastart = 743M, timedatafinal = 1534M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 155 , rutadenumireruta = @"RT-REZ.5.Z6DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 66 RDX", recipientetotal = 61M, volumtotal = 0M, greutatetotala = 731.5M, datastart = @"17/04/2020", timedatastart = 753M, timedatafinal = 1513M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 156 , rutadenumireruta = @"RT-REZ.5.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 43M, volumtotal = 0M, greutatetotala = 741M, datastart = @"17/04/2020", timedatastart = 823M, timedatafinal = 1407M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 157 , rutadenumireruta = @"RT-REZ.1.Z5DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 34 RDX", recipientetotal = 60M, volumtotal = 0M, greutatetotala = 959M, datastart = @"20/04/2020", timedatastart = 658M, timedatafinal = 1137M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 158 , rutadenumireruta = @"RT-REZ.1.Z2DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 28M, volumtotal = 0M, greutatetotala = 296.5M, datastart = @"20/04/2020", timedatastart = 741M, timedatafinal = 1114M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 159 , rutadenumireruta = @"RT-REZ.1.Z6DJ.01", stare = @"Ended", camionnumarinmatriculare = @"B 66 RDX", recipientetotal = 9M, volumtotal = 0M, greutatetotala = 134.5M, datastart = @"20/04/2020", timedatastart = 722M, timedatafinal = 1008M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 160 , rutadenumireruta = @"RT-REZ.1.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 66M, volumtotal = 0M, greutatetotala = 993M, datastart = @"20/04/2020", timedatastart = 741M, timedatafinal = 1324M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 161 , rutadenumireruta = @"RT-REZ.1.Z6DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 66 RDX", recipientetotal = 13M, volumtotal = 0M, greutatetotala = 206M, datastart = @"20/04/2020", timedatastart = 1009M, timedatafinal = 1245M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 162 , rutadenumireruta = @"RT-REZ.2.Z5DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 34 RDX", recipientetotal = 50M, volumtotal = 0M, greutatetotala = 840.5M, datastart = @"21/04/2020", timedatastart = 659M, timedatafinal = 1127M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 163 , rutadenumireruta = @"RT-REZ.2.Z2DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 43M, volumtotal = 0M, greutatetotala = 1047.5M, datastart = @"21/04/2020", timedatastart = 743M, timedatafinal = 1111M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 164 , rutadenumireruta = @"RT-REZ.2.Z6DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 66 RDX", recipientetotal = 33M, volumtotal = 0M, greutatetotala = 323M, datastart = @"21/04/2020", timedatastart = 721M, timedatafinal = 1330M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 165 , rutadenumireruta = @"RT-REZ.2.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 42M, volumtotal = 0M, greutatetotala = 904M, datastart = @"21/04/2020", timedatastart = 738M, timedatafinal = 1329M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 166 , rutadenumireruta = @"RT-REZ.3.Z5DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 34 RDX", recipientetotal = 54M, volumtotal = 0M, greutatetotala = 853M, datastart = @"22/04/2020", timedatastart = 701M, timedatafinal = 1132M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 167 , rutadenumireruta = @"RT-REZ.3.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 68M, volumtotal = 0M, greutatetotala = 1506M, datastart = @"22/04/2020", timedatastart = 738M, timedatafinal = 1612M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 168 , rutadenumireruta = @"RT-REZ.3.Z2DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 58M, volumtotal = 0M, greutatetotala = 679.5M, datastart = @"22/04/2020", timedatastart = 724M, timedatafinal = 1459M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 169 , rutadenumireruta = @"RT-REZ.3.Z6DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 66 RDX", recipientetotal = 20M, volumtotal = 0M, greutatetotala = 208.5M, datastart = @"22/04/2020", timedatastart = 717M, timedatafinal = 1226M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 170 , rutadenumireruta = @"RT-REZ.4.Z5DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 34 RDX", recipientetotal = 82M, volumtotal = 0M, greutatetotala = 1283.5M, datastart = @"23/04/2020", timedatastart = 704M, timedatafinal = 1121M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 171 , rutadenumireruta = @"RT-REZ.4.Z3DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 148 RDX", recipientetotal = 91M, volumtotal = 0M, greutatetotala = 1336.5M, datastart = @"23/04/2020", timedatastart = 738M, timedatafinal = 1605M });
                    
                    modelBuilder.Entity<CollectionProgram_list1>().HasData(
                        new CollectionProgram_list1(){ ID = 172 , rutadenumireruta = @"RT-REZ.4.Z2DJ.01", stare = @"Expired", camionnumarinmatriculare = @"B 153 RDX", recipientetotal = 47M, volumtotal = 0M, greutatetotala = 428M, datastart = @"23/04/2020", timedatastart = 728M, timedatafinal = 1457M });
                    
            OnSeed(modelBuilder);


        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        partial void OnSeed(ModelBuilder modelBuilder);       
    }
}