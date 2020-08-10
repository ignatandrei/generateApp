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

            public virtual DbSet<Ani8_10> Ani8_10 { get; set; }
            
            public virtual DbSet<Ani10_12> Ani10_12 { get; set; }
            
            public virtual DbSet<Ani12_14> Ani12_14 { get; set; }
            
            public virtual DbSet<Ani14> Ani14 { get; set; }
                    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Ani8_10>(entity =>
            {
                //entity.Property(e => e.Name).IsUnicode(false);
            });
         
            modelBuilder.Entity<Ani10_12>(entity =>
            {
                //entity.Property(e => e.Name).IsUnicode(false);
            });
         
            modelBuilder.Entity<Ani12_14>(entity =>
            {
                //entity.Property(e => e.Name).IsUnicode(false);
            });
         
            modelBuilder.Entity<Ani14>(entity =>
            {
                //entity.Property(e => e.Name).IsUnicode(false);
            });
         
            OnModelCreatingPartial(modelBuilder);
            Seed(modelBuilder);
        }
        void Seed(ModelBuilder modelBuilder){


                    modelBuilder.Entity<Ani8_10>().HasData(
                        new Ani8_10(){ ID = 1 , Nume = @"23. O poveste cu un hobbit – J.R.R. Tolkien" });
                    
                    modelBuilder.Entity<Ani8_10>().HasData(
                        new Ani8_10(){ ID = 2 , Nume = @"24. Vântul prin sălcii – Kenneth Grahame" });
                    
                    modelBuilder.Entity<Ani8_10>().HasData(
                        new Ani8_10(){ ID = 3 , Nume = @"25. Alice în Țara Minunilor – Lewis Carroll" });
                    
                    modelBuilder.Entity<Ani8_10>().HasData(
                        new Ani8_10(){ ID = 4 , Nume = @"26. Cartea Junglei – Rudyard Kipling" });
                    
                    modelBuilder.Entity<Ani8_10>().HasData(
                        new Ani8_10(){ ID = 5 , Nume = @"27. Uluitorul Maurice și rozătoarele lui educate – Terry Pratchett" });
                    
                    modelBuilder.Entity<Ani8_10>().HasData(
                        new Ani8_10(){ ID = 6 , Nume = @"28. Poveste fără sfârșit – Michael Ende" });
                    
                    modelBuilder.Entity<Ani8_10>().HasData(
                        new Ani8_10(){ ID = 7 , Nume = @"29. Aventurile lui Tom Sawyer – Mark Twain" });
                    
                    modelBuilder.Entity<Ani8_10>().HasData(
                        new Ani8_10(){ ID = 8 , Nume = @"30. Aventurile baronului Von Münchhausen – Gottfried August Bürger" });
                    
                    modelBuilder.Entity<Ani8_10>().HasData(
                        new Ani8_10(){ ID = 9 , Nume = @"31. Fetița de pe Terra – Kiril Buliciov" });
                    
                    modelBuilder.Entity<Ani8_10>().HasData(
                        new Ani8_10(){ ID = 10 , Nume = @"32. Povestea lui Despereaux – Kate DiCamillo" });
                    
                    modelBuilder.Entity<Ani8_10>().HasData(
                        new Ani8_10(){ ID = 11 , Nume = @"33. Mary Poppins* – P.L. Travers" });
                    
                    modelBuilder.Entity<Ani8_10>().HasData(
                        new Ani8_10(){ ID = 12 , Nume = @"34. Pippi Sosetica* – Astrid Lindgren" });
                    
                    modelBuilder.Entity<Ani8_10>().HasData(
                        new Ani8_10(){ ID = 13 , Nume = @"35. Roverandom – J.R.R. Tolkien" });
                    
                    modelBuilder.Entity<Ani8_10>().HasData(
                        new Ani8_10(){ ID = 14 , Nume = @"36. Gnomii* – Rien Poortvliet" });
                    
                    modelBuilder.Entity<Ani8_10>().HasData(
                        new Ani8_10(){ ID = 15 , Nume = @"37. Cronicile Spiderwick – Tony Diterlizzi" });
                    
                    modelBuilder.Entity<Ani8_10>().HasData(
                        new Ani8_10(){ ID = 16 , Nume = @"38. Cum să-ți dresezi dragonul – Cressida Cowell" });
                    
                    modelBuilder.Entity<Ani8_10>().HasData(
                        new Ani8_10(){ ID = 17 , Nume = @"39. Emil și detectivii – Erich Kastner" });
                    
                    modelBuilder.Entity<Ani8_10>().HasData(
                        new Ani8_10(){ ID = 18 , Nume = @"40. Charlie și Fabrica de Ciocolată – Roald Dahl" });
                    
                    modelBuilder.Entity<Ani8_10>().HasData(
                        new Ani8_10(){ ID = 19 , Nume = @"41. Aventurile lui Huckleberry Finn – Mark Twain" });
                    
                    modelBuilder.Entity<Ani8_10>().HasData(
                        new Ani8_10(){ ID = 20 , Nume = @"" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 1 , Nume = @"42. Scoțidușii liberi – Terry Pratchett" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 2 , Nume = @"43. Comoara din insulă – Robert Louis Stevenson" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 3 , Nume = @"44. Winnetou – Karl May" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 4 , Nume = @"45. Tintin* – Hergé" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 5 , Nume = @"46. Till Eulenspiegel – Erich Kastner" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 6 , Nume = @"47. Tarzan, omul junglei* – Edgar Rice Burroughs" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 7 , Nume = @"48. Asterix* – Rene Gosciny" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 8 , Nume = @"49. Aventurile lui Hendrik de Mol* – K.J. Mecklenfeld" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 9 , Nume = @"50. O călătorie spre centrul Pământului – Jules Verne" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 10 , Nume = @"51. Miraculoasa călătorie a lui Edward Tulane – Kate DiCamillo" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 11 , Nume = @"52. Micul Prinț – Antoine de Saint-Exupery" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 12 , Nume = @"53. Amintiri din copilărie – Ion Creangă" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 13 , Nume = @"54. Basmele romanilor – Petre Ispirescu" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 14 , Nume = @"55. Insula misterioasă – Jules Verne" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 15 , Nume = @"56. Trilogia Nomilor* – Terry Pratchett" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 16 , Nume = @"57. Coliba unchiului Tom – Harriet Beecher Stowe" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 17 , Nume = @"58. Copiii căpitanului Grant – Jules Verne" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 18 , Nume = @"59. Tartarin din Tarascon – Alphonse Daudet" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 19 , Nume = @"60. Tabăra – Louis Sachar" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 20 , Nume = @"61. 20000 de leghe sub mări – Jules Verne" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 21 , Nume = @"62. Călătoriile lui Gulliver – Jonathan Swift" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 22 , Nume = @"63. Poveste de Crăciun – Charles Dickens" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 23 , Nume = @"" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 24 , Nume = @"" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 25 , Nume = @"" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 26 , Nume = @"" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 27 , Nume = @"" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 28 , Nume = @"" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 29 , Nume = @"" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 30 , Nume = @"" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 31 , Nume = @"" });
                    
                    modelBuilder.Entity<Ani10_12>().HasData(
                        new Ani10_12(){ ID = 32 , Nume = @"" });
                    
                    modelBuilder.Entity<Ani12_14>().HasData(
                        new Ani12_14(){ ID = 1 , Nume = @"64. Cireșarii* – Constantin Chiriță" });
                    
                    modelBuilder.Entity<Ani12_14>().HasData(
                        new Ani12_14(){ ID = 2 , Nume = @"65. Harry Potter* – J.K. Rowling" });
                    
                    modelBuilder.Entity<Ani12_14>().HasData(
                        new Ani12_14(){ ID = 3 , Nume = @"66. Cei trei mușchetari – Alexandre Dumas" });
                    
                    modelBuilder.Entity<Ani12_14>().HasData(
                        new Ani12_14(){ ID = 4 , Nume = @"67. Cavalerii Pardaillan – Michel Zévaco" });
                    
                    modelBuilder.Entity<Ani12_14>().HasData(
                        new Ani12_14(){ ID = 5 , Nume = @"68. Călătoria navei Space Beagle – A.E. Van Vogt" });
                    
                    modelBuilder.Entity<Ani12_14>().HasData(
                        new Ani12_14(){ ID = 6 , Nume = @"69. Peripeţiile bravului soldat Švejk – Jaroslav Hašek" });
                    
                    modelBuilder.Entity<Ani12_14>().HasData(
                        new Ani12_14(){ ID = 7 , Nume = @"70. Extravagantul Conan Doi* – Vlad Musatescu" });
                    
                    modelBuilder.Entity<Ani12_14>().HasData(
                        new Ani12_14(){ ID = 8 , Nume = @"71. Materiile Întunecate* – Philip Pullman" });
                    
                    modelBuilder.Entity<Ani12_14>().HasData(
                        new Ani12_14(){ ID = 9 , Nume = @"72. La Medeleni – Ionel Teodoreanu" });
                    
                    modelBuilder.Entity<Ani12_14>().HasData(
                        new Ani12_14(){ ID = 10 , Nume = @"73. Cavalerii Ordinului Basarab – Ioan Dan" });
                    
                    modelBuilder.Entity<Ani12_14>().HasData(
                        new Ani12_14(){ ID = 11 , Nume = @"74. Colț alb – Jack London" });
                    
                    modelBuilder.Entity<Ani12_14>().HasData(
                        new Ani12_14(){ ID = 12 , Nume = @"75. Mașina timpului – H.G. Wells" });
                    
                    modelBuilder.Entity<Ani12_14>().HasData(
                        new Ani12_14(){ ID = 13 , Nume = @"76. Un yankeu la curtea regelui Arthur – Mark Twain" });
                    
                    modelBuilder.Entity<Ani12_14>().HasData(
                        new Ani12_14(){ ID = 14 , Nume = @"77. Old Surehand – Karl May" });
                    
                    modelBuilder.Entity<Ani12_14>().HasData(
                        new Ani12_14(){ ID = 15 , Nume = @"78. O pălărie plina de cer* – Terry Pratchett" });
                    
                    modelBuilder.Entity<Ani12_14>().HasData(
                        new Ani12_14(){ ID = 16 , Nume = @"79. Toate pânzele sus – Radu Tudoran" });
                    
                    modelBuilder.Entity<Ani12_14>().HasData(
                        new Ani12_14(){ ID = 17 , Nume = @"80. The Apprentice Witch – James Nicol" });
                    
                    modelBuilder.Entity<Ani12_14>().HasData(
                        new Ani12_14(){ ID = 18 , Nume = @"81. Robinson Crusoe – Daniel Defoe" });
                    
                    modelBuilder.Entity<Ani12_14>().HasData(
                        new Ani12_14(){ ID = 19 , Nume = @"82. De Zevensprong – Tonke Dragt" });
                    
                    modelBuilder.Entity<Ani12_14>().HasData(
                        new Ani12_14(){ ID = 20 , Nume = @"83. Minoes – Annie M.G. Schmidt" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 1 , Nume = @"84. Castelul mișcător al lui Howl – Diana Wynne Jones" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 2 , Nume = @"85. Jocul lui Ender – Orson Scott Card" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 3 , Nume = @"86. Pe drumuri de munte – Calistrat Hogas" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 4 , Nume = @"87. Cronicile Ținuturilor din Apus* – Ursula K. Le Guin" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 5 , Nume = @"88. De brief voor de koning – Tonke Dragt" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 6 , Nume = @"89. Lumea lui Rocannon – Ursula K. Le Guin" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 7 , Nume = @"90. Eu, robotul – Isaac Asimov" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 8 , Nume = @"91. Contele de Monte Cristo – Alexandre Dumas" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 9 , Nume = @"92. Trei într-o barcă – Jerome K. Jerome" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 10 , Nume = @"93. Marile Speranțe – Charles Dickens" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 11 , Nume = @"94. Povestiri – Edgar Alan Poe" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 12 , Nume = @"95. Mireasa prințesă – William Goldman" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 13 , Nume = @"96. Frații Jderi – Mihail Sadoveanu" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 14 , Nume = @"97. Mizerabilii – Victor Hugo" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 15 , Nume = @"98. Darul lui Jonas – Lois Lowry" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 16 , Nume = @"99. Omul invizibil – H.G. Wells" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 17 , Nume = @"100. Legendele Olimpului – Alexandru Mitru" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 18 , Nume = @"" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 19 , Nume = @"" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 20 , Nume = @"" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 21 , Nume = @"" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 22 , Nume = @"" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 23 , Nume = @"" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 24 , Nume = @"" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 25 , Nume = @"" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 26 , Nume = @"" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 27 , Nume = @"" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 28 , Nume = @"" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 29 , Nume = @"" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 30 , Nume = @"" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 31 , Nume = @"" });
                    
                    modelBuilder.Entity<Ani14>().HasData(
                        new Ani14(){ ID = 32 , Nume = @"" });
                    
            OnSeed(modelBuilder);


        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        partial void OnSeed(ModelBuilder modelBuilder);       
    }
}