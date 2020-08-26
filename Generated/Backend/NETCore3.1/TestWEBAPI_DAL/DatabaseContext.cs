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

            public virtual DbSet<csv20200826135839> csv20200826135839{ get; set; }
                    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<csv20200826135839>(entity =>
            {
                //entity.Property(e => e.Name).IsUnicode(false);
            });
         
            OnModelCreatingPartial(modelBuilder);
            Seed(modelBuilder);
        }
        void Seed(ModelBuilder modelBuilder){


                    modelBuilder.Entity<csv20200826135839>().HasData(
                        new csv20200826135839(){ ID = 1 , firstname = @"Andrei", lastname = @"Ignat
" });
                    
                    modelBuilder.Entity<csv20200826135839>().HasData(
                        new csv20200826135839(){ ID = 2 , firstname = @"Another", lastname = @"Name
" });
                    
                    modelBuilder.Entity<csv20200826135839>().HasData(
                        new csv20200826135839(){ ID = 3 , firstname = @"
", lastname = @"" });
                    
                    modelBuilder.Entity<csv20200826135839>().HasData(
                        new csv20200826135839(){ ID = 4 , firstname = @"", lastname = @"" });
                    
            OnSeed(modelBuilder);


        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        partial void OnSeed(ModelBuilder modelBuilder);       
    }
}