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
                .ToTable("Sheet1")
                .HasKey(it=>it.id20200909002008);
         
            OnModelCreatingPartial(modelBuilder);
            Seed(modelBuilder);
        }
        void Seed(ModelBuilder modelBuilder){


                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 1 , noticeno = @"DA22631224", contractobject = @"Licenta OEM Microsoft Windows 10", contractingauthority = @"Comuna Gaiseni", supplier = @"Prosoft++ S.R.L.", contractvalue = @"630.00", currency = @"RON", cpvcode = @"48620000-0", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"GR", communityreference = @"No", publicationdate = @"Mar 19, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 2 , noticeno = @"DA22265173", contractobject = @"Licenta OEM Microsoft Windows 10 Pro 64 bit English", contractingauthority = @"SPITALUL DE PSIHIATRIE ""SF. PANTELIMON"" BRAILA", supplier = @"INFOCENTER", contractvalue = @"610.92", currency = @"RON", cpvcode = @"48624000-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"BR", communityreference = @"No", publicationdate = @"Jan 22, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 3 , noticeno = @"DA22405965", contractobject = @"Licenta OEM Microsoft Windows 10 Pro 64 bit Romanian", contractingauthority = @"S.C. APA-CANAL ILFOV S.A.", supplier = @"INFOCENTER", contractvalue = @"628.57", currency = @"RON", cpvcode = @"48214000-1", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"B", communityreference = @"No", publicationdate = @"Feb 14, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 4 , noticeno = @"DA22627444", contractobject = @"Licenta Microsoft Windows 10 Pro 64 bit English OEM, cu DVD inclus", contractingauthority = @"Municipiul Carei", supplier = @"IASI IT", contractvalue = @"596.00", currency = @"RON", cpvcode = @"48620000-0", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"SM", communityreference = @"No", publicationdate = @"Mar 19, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 5 , noticeno = @"DA22647227", contractobject = @"Microsoft Office Home and Business 2019, Engleza, 1 utilizator, pentru Windows/Mac", contractingauthority = @"I.N.C.D. pentru Microtehnologie - I.M.T Bucuresti", supplier = @"DANTE INTERNATIONAL S.A.", contractvalue = @"1,554.60", currency = @"RON", cpvcode = @"48900000-7", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"IF", communityreference = @"No", publicationdate = @"Mar 21, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 6 , noticeno = @"DA22245496", contractobject = @"Licenta OEM Microsoft Windows 10 Pro 64 bit English  FQC-08929", contractingauthority = @"COMUNA PREJMER", supplier = @"BIROTIC SRL", contractvalue = @"574.91", currency = @"RON", cpvcode = @"48624000-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"BV", communityreference = @"No", publicationdate = @"Jan 18, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 7 , noticeno = @"DA22272357", contractobject = @"MICROSOFT Windows 10 PRO OEM 64 bit engleza DVD", contractingauthority = @"Municipiul Carei", supplier = @"COMPUTECH", contractvalue = @"563.03", currency = @"RON", cpvcode = @"48620000-0", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"SM", communityreference = @"No", publicationdate = @"Jan 23, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 8 , noticeno = @"DA22274219", contractobject = @"Microsoft Windows 10 , 64 bit, OEM, DVD", contractingauthority = @"COMUNA VIDRA", supplier = @"SECRET SERVICES S.R.L.", contractvalue = @"420.16", currency = @"RON", cpvcode = @"48624000-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"VN", communityreference = @"No", publicationdate = @"Jan 23, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 9 , noticeno = @"DA22311808", contractobject = @"Microsoft Windows 10 Pro, 64 bit, Engleza, OEM, DVD", contractingauthority = @"COMPANIA MUNICIPALA PAZA SI SECURITATE BUCURESTI S.A.", supplier = @"DANTE INTERNATIONAL S.A.", contractvalue = @"546.21", currency = @"RON", cpvcode = @"48218000-9", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"B", communityreference = @"No", publicationdate = @"Jan 30, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 10 , noticeno = @"DA22328816", contractobject = @"MICROSOFT Windows 10 PRO / PROfessional / PROfesional OEM 64 bit engleza DVD - Licente / Licenta", contractingauthority = @"Municipiul Carei", supplier = @"COMPUTECH", contractvalue = @"1,689.09", currency = @"RON", cpvcode = @"48620000-0", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"SM", communityreference = @"No", publicationdate = @"Feb 1, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 11 , noticeno = @"DA22354188", contractobject = @"Licenta Microsoft Windows 10 Home OEM Romanian", contractingauthority = @"Clubul Sportiv Municipal Satu Mare", supplier = @"INFOCENTER S.R.L.", contractvalue = @"465.53", currency = @"RON", cpvcode = @"48920000-3", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"SM", communityreference = @"No", publicationdate = @"Feb 6, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 12 , noticeno = @"DA22387789", contractobject = @"Licenta OEM Microsoft Windows 10 Pro 64 bit English", contractingauthority = @"REGIA AUTONOMA AEROPORT TRANSILVANIA TARGU MURES", supplier = @"GLOBAL SYSTEMS COMMUNICATIONS S.R.L.", contractvalue = @"545.88", currency = @"RON", cpvcode = @"48000000-8", noticetype = @"Direct Acquisition", procedurestate = @"Refused conditions", awardstate = @"Other", county = @"MS", communityreference = @"No", publicationdate = @"Feb 12, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 13 , noticeno = @"DA22388234", contractobject = @"Licenta OEM Microsoft Windows 10 Home 64 bit English", contractingauthority = @"SPITALUL CLINIC JUDETEAN DE URGENTA CLUJ", supplier = @"BAD DOG OFFICE DISTRIBUTION S.R.L.", contractvalue = @"1,678.00", currency = @"RON", cpvcode = @"48620000-0", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"CJ", communityreference = @"No", publicationdate = @"Feb 12, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 14 , noticeno = @"DA22388492", contractobject = @"Licenta OEM Microsoft Windows 10 Pro 64 bit English", contractingauthority = @"COMUNA MICULA", supplier = @"CHIOREAN COMPANY S.R.L.", contractvalue = @"1,890.75", currency = @"RON", cpvcode = @"48623000-1", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"SM", communityreference = @"No", publicationdate = @"Feb 12, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 15 , noticeno = @"DA22407094", contractobject = @"Microsoft Windows 10 Pro Engleza 64Bit Licenta OEM DVD", contractingauthority = @"INSPECTORATUL TERITORIAL DE MUNCA SATU MARE", supplier = @"corsar online", contractvalue = @"503.36", currency = @"RON", cpvcode = @"48218000-9", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"SM", communityreference = @"No", publicationdate = @"Feb 14, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 16 , noticeno = @"DA22413595", contractobject = @"Microsoft Windows 10 Pro, 64 bit, Engleza, OEM, DVD", contractingauthority = @"INSTITUTUL DE STIINTE SPATIALE-FILIALA INFLPR", supplier = @"DANTE INTERNATIONAL S.A.", contractvalue = @"605.19", currency = @"RON", cpvcode = @"48218000-9", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"IF", communityreference = @"No", publicationdate = @"Feb 15, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 17 , noticeno = @"DA22426322", contractobject = @"Licenta OEM Microsoft Windows 10 Pro 32 bit English", contractingauthority = @"DRUMURI SI PODURI SA SIBIU", supplier = @"TOP NET S.R.L.", contractvalue = @"659.66", currency = @"RON", cpvcode = @"48620000-0", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"SB", communityreference = @"No", publicationdate = @"Feb 18, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 18 , noticeno = @"DA22428440", contractobject = @"Microsoft Windows 10 Pro, 64 bit, Engleza, OEM, DVD", contractingauthority = @"REGIA AUTONOMA AEROPORT TRANSILVANIA TARGU MURES", supplier = @"DANTE INTERNATIONAL S.A.", contractvalue = @"605.19", currency = @"RON", cpvcode = @"48218000-9", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"MS", communityreference = @"No", publicationdate = @"Feb 18, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 19 , noticeno = @"DA22430486", contractobject = @"LICENTA MICROSOFT WINDOWS 10 PROFESSIONAL OEM", contractingauthority = @"SCOALA GIMNAZIALA NR.17  ION MINULESCU", supplier = @"BASE TRADING S.R.L.", contractvalue = @"1,150.00", currency = @"RON", cpvcode = @"48620000-0", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"CT", communityreference = @"No", publicationdate = @"Feb 18, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 20 , noticeno = @"DA22430592", contractobject = @"LICENTA OEM MICROSOFT WINDOWS", contractingauthority = @"COMUNA PAULIS", supplier = @"SC A.M. CENTER CRIS SRL", contractvalue = @"546.00", currency = @"RON", cpvcode = @"48000000-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"AR", communityreference = @"No", publicationdate = @"Feb 18, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 21 , noticeno = @"DA22340901", contractobject = @"Microsoft Windows 10 Pro Engleza 64Bit Licenta OEM DVD fqc-08929", contractingauthority = @"SPITALUL CLINIC DE URGENTA SF. PANTELIMON", supplier = @"Mida Soft Business", contractvalue = @"528.00", currency = @"RON", cpvcode = @"48611000-4", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"B", communityreference = @"No", publicationdate = @"Feb 5, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 22 , noticeno = @"DA22358602", contractobject = @"Licenta OEM Microsoft Windows 10 Pro 64 bit English", contractingauthority = @"CNCIR - COMPANIA NATIONALA PENTRU CONTROLUL CAZANELOR, INSTALATIILOR DE RIDICAT SI RECIPIENTELOR SUB PRESIUNE S.A.", supplier = @"SC COMSHOP SOLUTION SRL", contractvalue = @"51,200.00", currency = @"RON", cpvcode = @"48517000-5", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"B", communityreference = @"No", publicationdate = @"Feb 7, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 23 , noticeno = @"DA22390704", contractobject = @"Licenta OEM Microsoft Windows 10 Pro 64 bit", contractingauthority = @"REGIA AUTONOMA AEROPORT TRANSILVANIA TARGU MURES", supplier = @"DIGICON NET SRL", contractvalue = @"550.00", currency = @"RON", cpvcode = @"48620000-0", noticetype = @"Direct Acquisition", procedurestate = @"Unaccepted conditions within term", awardstate = @"Other", county = @"MS", communityreference = @"No", publicationdate = @"Feb 12, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 24 , noticeno = @"DA22445683", contractobject = @"Licenta OEM Microsoft Windows 10 Pro 64 bit Romanian/English", contractingauthority = @"SPITALUL DE PSIHIATRIE ""SF. PANTELIMON"" BRAILA", supplier = @"Novotim Technologies SRL", contractvalue = @"550.00", currency = @"RON", cpvcode = @"48620000-0", noticetype = @"Direct Acquisition", procedurestate = @"Unaccepted conditions within term", awardstate = @"Other", county = @"BR", communityreference = @"No", publicationdate = @"Feb 20, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 25 , noticeno = @"DA22469696", contractobject = @"Licenta OEM Microsoft Windows 10 Pro 64 bit English", contractingauthority = @"SPITALUL DE PSIHIATRIE ""SF. PANTELIMON"" BRAILA", supplier = @"TOP NET S.R.L.", contractvalue = @"558.82", currency = @"RON", cpvcode = @"48960000-5", noticetype = @"Direct Acquisition", procedurestate = @"Refused conditions", awardstate = @"Other", county = @"BR", communityreference = @"No", publicationdate = @"Feb 25, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 26 , noticeno = @"DA22470232", contractobject = @"Licenta OEM Microsoft Windows 10 Pro 64 bit English", contractingauthority = @"SPITALUL DE PSIHIATRIE ""SF. PANTELIMON"" BRAILA", supplier = @"EXPERT COPY SERVICE S.R.L.", contractvalue = @"590.00", currency = @"RON", cpvcode = @"48620000-0", noticetype = @"Direct Acquisition", procedurestate = @"Refused offer", awardstate = @"Other", county = @"BR", communityreference = @"No", publicationdate = @"Feb 25, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 27 , noticeno = @"DA22471530", contractobject = @"Licenta OEM Microsoft Windows 10 Pro 64 bit English", contractingauthority = @"SPITALUL DE PSIHIATRIE ""SF. PANTELIMON"" BRAILA", supplier = @"Prime Solutions S.R.L.", contractvalue = @"577.63", currency = @"RON", cpvcode = @"48218000-9", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"BR", communityreference = @"No", publicationdate = @"Feb 25, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 28 , noticeno = @"DA22487000", contractobject = @"Achizitie Licenta OEM Microsoft Windows 10 Home 64", contractingauthority = @"Primaria comunei Balan,com.Balan, jud.Salaj.", supplier = @"MEDIA IT", contractvalue = @"494.50", currency = @"RON", cpvcode = @"48218000-9", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"SJ", communityreference = @"No", publicationdate = @"Feb 26, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 29 , noticeno = @"DA22487946", contractobject = @"Licenta OEM Microsoft Windows 10 Pro 64 bit English", contractingauthority = @"Consiliul Judetean Buzau", supplier = @"NETWAVE SRL", contractvalue = @"2,560.00", currency = @"RON", cpvcode = @"48624000-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"BZ", communityreference = @"No", publicationdate = @"Feb 26, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 30 , noticeno = @"DA22505636", contractobject = @"Licenta OEM Microsoft Windows 10 Home 64 bit English", contractingauthority = @"SPITALUL CLINIC JUDETEAN DE URGENTA CLUJ", supplier = @"BAD DOG OFFICE DISTRIBUTION S.R.L.", contractvalue = @"2,175.00", currency = @"RON", cpvcode = @"48620000-0", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"CJ", communityreference = @"No", publicationdate = @"Feb 28, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 31 , noticeno = @"DA22435579", contractobject = @"Microsoft Windows 10 Home, 64 bit, Romana, OEM, DVD [KW9-00131]", contractingauthority = @"SCOALA GIMNAZIALA BERGHIN", supplier = @"DANTE INTERNATIONAL S.A.", contractvalue = @"462.18", currency = @"RON", cpvcode = @"48218000-9", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"AB", communityreference = @"No", publicationdate = @"Feb 19, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 32 , noticeno = @"DA22528659", contractobject = @"LICENTA MICROSOFT WINDOWS 10 PROFESSIONAL OEM", contractingauthority = @"SCOALA CU CLASELE I - VIII NR.37 CONSTANTA", supplier = @"BASE TRADING S.R.L.", contractvalue = @"2,300.00", currency = @"RON", cpvcode = @"48620000-0", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"CT", communityreference = @"No", publicationdate = @"Mar 4, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 33 , noticeno = @"DA22577778", contractobject = @"Licenta OEM Microsoft Windows 10 Home 64 bit English", contractingauthority = @"SPITALUL CLINIC JUDETEAN DE URGENTA CLUJ", supplier = @"BAD DOG OFFICE DISTRIBUTION S.R.L.", contractvalue = @"435.00", currency = @"RON", cpvcode = @"48620000-0", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"CJ", communityreference = @"No", publicationdate = @"Mar 12, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 34 , noticeno = @"DA22582602", contractobject = @"Licenta OEM Microsoft Windows 10 HOME 64 bit English", contractingauthority = @"UNIVERSITATEA DIN PITESTI", supplier = @"INFOSTAR COMPROD S.R.L.", contractvalue = @"2,016.80", currency = @"RON", cpvcode = @"48624000-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"AG", communityreference = @"No", publicationdate = @"Mar 12, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 35 , noticeno = @"DA22624761", contractobject = @"Microsoft Windows 10 Pro Engleza 64Bit Licenta OEM DVD", contractingauthority = @"INSTITUTUL NATIONAL DE CERCETARE DEZVOLTARE IN INFORMATICA - ICI", supplier = @"corsar online", contractvalue = @"545.38", currency = @"RON", cpvcode = @"48900000-7", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"B", communityreference = @"No", publicationdate = @"Mar 18, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 36 , noticeno = @"DA22630677", contractobject = @"Licenta OEM Microsoft Windows 10 Pro 64 bit Romanian", contractingauthority = @"Administratia Nationala a Rezervelor de Stat - U nitatea T eritoriala 335", supplier = @"INTREPRINDERE INDIVIDUALA PALAMARIUC M. MIHAI", contractvalue = @"619.33", currency = @"RON", cpvcode = @"48490000-9", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"BC", communityreference = @"No", publicationdate = @"Mar 19, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 37 , noticeno = @"DA22636124", contractobject = @"Microsoft Windows 10 Home, 64 bit, Engleza, OEM, DVD", contractingauthority = @"SECOM S.A.", supplier = @"DANTE INTERNATIONAL S.A.", contractvalue = @"1,512.60", currency = @"RON", cpvcode = @"48000000-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"MH", communityreference = @"No", publicationdate = @"Mar 20, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 38 , noticeno = @"DA22696333", contractobject = @"Licenta OEM Microsoft Windows 10 Home 64 bit English", contractingauthority = @"SPITALUL CLINIC JUDETEAN DE URGENTA CLUJ", supplier = @"BAD DOG OFFICE DISTRIBUTION S.R.L.", contractvalue = @"435.00", currency = @"RON", cpvcode = @"48620000-0", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"CJ", communityreference = @"No", publicationdate = @"Mar 28, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 39 , noticeno = @"DA22527000", contractobject = @"Monitor 24″, Placa video Asus, Licenta Microsoft", contractingauthority = @"MUNICIPIUL ROMAN", supplier = @"NET CHIT COMPUTERS", contractvalue = @"1,860.00", currency = @"RON", cpvcode = @"33195100-4", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"NT", communityreference = @"No", publicationdate = @"Mar 4, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 40 , noticeno = @"DA22387349", contractobject = @"Sistem de operare Microsoft Windows 10 Pro OEM DSP OEI 64bit Engleza DVD", contractingauthority = @"Institutul National de Cercetare-Dezvoltare Turbomotoare Comoti", supplier = @"ITG Online SRL", contractvalue = @"578.99", currency = @"RON", cpvcode = @"48000000-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"B", communityreference = @"No", publicationdate = @"Feb 12, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 41 , noticeno = @"DA22486976", contractobject = @"Sistem de Operare: Microsoft Windows 10 Pro 64 Biti", contractingauthority = @"SC ""LOCATIV""SA", supplier = @"ATEX COMPUTER S.R.L.", contractvalue = @"3,555.85", currency = @"RON", cpvcode = @"48620000-0", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"MS", communityreference = @"No", publicationdate = @"Feb 26, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 42 , noticeno = @"DA22690137", contractobject = @"Microsoft Windows 10 Pro Romana 64Bit Licenta OEM DVD", contractingauthority = @"ADI - Managementul Deseurilor Teleorman", supplier = @"corsar online", contractvalue = @"486.55", currency = @"RON", cpvcode = @"48218000-9", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"TR", communityreference = @"No", publicationdate = @"Mar 27, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 43 , noticeno = @"DA22636241", contractobject = @"Sisteme de operare", contractingauthority = @"Institutul National de Cercetare Dezvoltare pentru Mecatronica si Tehnica Masurarii-INCDMTM", supplier = @"corsar online", contractvalue = @"3,198.32", currency = @"RON", cpvcode = @"48900000-7", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"B", communityreference = @"No", publicationdate = @"Mar 20, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 44 , noticeno = @"DA22308455", contractobject = @"Microsoft Windows 10 PRO OEM", contractingauthority = @"Spitalul Clinic de Urgenta pentru Copii Louis Turcanu", supplier = @"CENTUM NET S.R.L.", contractvalue = @"632.00", currency = @"RON", cpvcode = @"48624000-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"TM", communityreference = @"No", publicationdate = @"Jan 30, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 45 , noticeno = @"DA22269532", contractobject = @"Microsoft Windows 10 PRO OEM", contractingauthority = @"Spitalul Clinic de Urgenta pentru Copii Louis Turcanu", supplier = @"CENTUM NET S.R.L.", contractvalue = @"632.00", currency = @"RON", cpvcode = @"48624000-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"TM", communityreference = @"No", publicationdate = @"Jan 23, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 46 , noticeno = @"DA22510242", contractobject = @"Pachete software IT", contractingauthority = @"COMUNA MIRASLAU", supplier = @"XEROM SERVICE S.R.L.", contractvalue = @"480.00", currency = @"RON", cpvcode = @"48517000-5", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"AB", communityreference = @"No", publicationdate = @"Mar 1, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 47 , noticeno = @"DA22711528", contractobject = @"Microsoft Windows 10 PRO OEM", contractingauthority = @"Spitalul Clinic de Urgenta pentru Copii Louis Turcanu", supplier = @"CENTUM NET S.R.L.", contractvalue = @"632.00", currency = @"RON", cpvcode = @"48624000-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"TM", communityreference = @"No", publicationdate = @"Mar 29, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 48 , noticeno = @"DA22422504", contractobject = @"Pachet  calculator de birou", contractingauthority = @"Muzeul Judetean Satu Mare", supplier = @"Centrul de Securitate si Informatica SRL", contractvalue = @"3,574.00", currency = @"RON", cpvcode = @"30213000-5", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"SM", communityreference = @"No", publicationdate = @"Feb 18, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 49 , noticeno = @"DA22707436", contractobject = @"Licente", contractingauthority = @"SC COMPANIA REGIONALA DE APA BACAU SA", supplier = @"ELSACO SOLUTIONS SRL", contractvalue = @"3,264.00", currency = @"RON", cpvcode = @"48620000-0", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"BC", communityreference = @"No", publicationdate = @"Mar 29, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 50 , noticeno = @"DA22433505", contractobject = @"LICENTA", contractingauthority = @"S.C. AQUASERV S.A.", supplier = @"ALLTELCOM S.R.L.", contractvalue = @"647.06", currency = @"RON", cpvcode = @"48624000-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"TL", communityreference = @"No", publicationdate = @"Feb 19, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 51 , noticeno = @"DA22218203", contractobject = @"Pachet software birotica (office home and business 2016/ windows 10 pro)", contractingauthority = @"AUTORITATEA  ELECTORALA  PERMANENTA", supplier = @"DANTE INTERNATIONAL S.A.", contractvalue = @"12,100.08", currency = @"RON", cpvcode = @"48920000-3", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"B", communityreference = @"No", publicationdate = @"Jan 14, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 52 , noticeno = @"DA22230197", contractobject = @"LICENTE ELECTRONICE", contractingauthority = @"SCOALA GIMNAZIALA GARBAU", supplier = @"APL SOFTTRONIC SRL", contractvalue = @"1,164.20", currency = @"RON", cpvcode = @"48624000-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"CJ", communityreference = @"No", publicationdate = @"Jan 16, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 53 , noticeno = @"DA22297214", contractobject = @"Licenta software pentru laptop", contractingauthority = @"SCOALA GIMNAZIALA BUDACU DE SUS", supplier = @"LOYAL CENTER S.R.L.", contractvalue = @"9,333.12", currency = @"RON", cpvcode = @"48000000-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"BN", communityreference = @"No", publicationdate = @"Jan 29, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 54 , noticeno = @"DA22338377", contractobject = @"PRODUSE IT", contractingauthority = @"COMUNA LIVEZI (PRIMARIA COMUNEI LIVEZI)", supplier = @"SERV IT", contractvalue = @"2,850.00", currency = @"RON", cpvcode = @"48900000-7", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"VL", communityreference = @"No", publicationdate = @"Feb 4, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 55 , noticeno = @"DA22396995", contractobject = @"Licenta Windows 10", contractingauthority = @"Orasul Sannicolau Mare", supplier = @"EXPERT COMPUTER", contractvalue = @"462.18", currency = @"RON", cpvcode = @"48900000-7", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"TM", communityreference = @"No", publicationdate = @"Feb 13, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 56 , noticeno = @"DA22347819", contractobject = @"Microsoft Windows 10 Professional 32/64 biti Engl./Rom. OEM", contractingauthority = @"SPITALUL MUNICIPAL MANGALIA", supplier = @"CAMINO SYSTEMS", contractvalue = @"1,288.00", currency = @"RON", cpvcode = @"48624000-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"CT", communityreference = @"No", publicationdate = @"Feb 5, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 57 , noticeno = @"DA22478710", contractobject = @"Microsoft Windows 10 Professional 32/64 biti Engl./Rom. OEM", contractingauthority = @"SPITALUL MUNICIPAL MANGALIA", supplier = @"CAMINO SYSTEMS", contractvalue = @"644.00", currency = @"RON", cpvcode = @"48624000-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"CT", communityreference = @"No", publicationdate = @"Feb 25, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 58 , noticeno = @"DA22559848", contractobject = @"licenta Windows 10", contractingauthority = @"COMUNA DAIA", supplier = @"GPC NET SRL", contractvalue = @"229.00", currency = @"RON", cpvcode = @"48620000-0", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"GR", communityreference = @"No", publicationdate = @"Mar 7, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 59 , noticeno = @"DA22681486", contractobject = @"Microsoft Windows 10 Professional 32/64 biti Engl./Rom. OEM", contractingauthority = @"SPITALUL MUNICIPAL MANGALIA", supplier = @"CAMINO SYSTEMS", contractvalue = @"651.00", currency = @"RON", cpvcode = @"48624000-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"CT", communityreference = @"No", publicationdate = @"Mar 26, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 60 , noticeno = @"", contractobject = @"Toner Xerox 006R01449 Black pt DocuColor WC 7655", contractingauthority = @"OPERA NATIONALA IASI 2007", supplier = @"SMART CHOICE S.R.L.", contractvalue = @"599.00", currency = @"RON", cpvcode = @"30125110-5", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"IS", communityreference = @"No", publicationdate = @"Jan 15, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 61 , noticeno = @"DA22207494", contractobject = @"Sistem PC / Calculator Computer Intel Core i3 7100", contractingauthority = @"SPITALUL MUNICIPAL "" ANGHEL SALIGNY"" FETESTI", supplier = @"COMPUTECH", contractvalue = @"3,840.34", currency = @"RON", cpvcode = @"30213300-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"IL", communityreference = @"No", publicationdate = @"Jan 11, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 62 , noticeno = @"DA22639632", contractobject = @"Echipamente", contractingauthority = @"DIRECTIA JUDETEANA DE STATISTICA VASLUI", supplier = @"STREAM NETWORKS S.R.L.", contractvalue = @"117,030.00", currency = @"RON", cpvcode = @"30232110-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"VS", communityreference = @"No", publicationdate = @"Mar 20, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 63 , noticeno = @"DA22676692", contractobject = @"ECHIPAMENTE ALEGERI", contractingauthority = @"Directia Judeteana de Statistica Ilfov", supplier = @"STREAM NETWORKS S.R.L.", contractvalue = @"107,279.00", currency = @"RON", cpvcode = @"30213000-5", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"B", communityreference = @"No", publicationdate = @"Mar 26, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 64 , noticeno = @"DA22702202", contractobject = @"Imprimanta HP LaserJet Enterprise M609x", contractingauthority = @"Directia Judeteana de Statistica Bihor", supplier = @"STREAM NETWORKS S.R.L.", contractvalue = @"78,885.00", currency = @"RON", cpvcode = @"30232110-8", noticetype = @"Direct Acquisition", procedurestate = @"Refused conditions", awardstate = @"Other", county = @"BH", communityreference = @"No", publicationdate = @"Mar 28, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 65 , noticeno = @"DA22712983", contractobject = @"Statie de lucru HP mod.800G4 cu Monitor LED", contractingauthority = @"Directia Judeteana de Statistica Harghita", supplier = @"NEXTRA SERVICE", contractvalue = @"98,753.00", currency = @"RON", cpvcode = @"30213000-5", noticetype = @"Direct Acquisition", procedurestate = @"Refused conditions", awardstate = @"Other", county = @"HR", communityreference = @"No", publicationdate = @"Mar 29, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 66 , noticeno = @"DA22714683", contractobject = @"ECHIPAMENTE IT ALEGERI", contractingauthority = @"DIRECTIA JUDETEANA DE STATISTICA CARAS-SEVERIN", supplier = @"STREAM NETWORKS S.R.L.", contractvalue = @"117,030.00", currency = @"RON", cpvcode = @"30121400-7", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"CS", communityreference = @"No", publicationdate = @"Mar 29, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 67 , noticeno = @"DA22714644", contractobject = @"Statie de lucru HP mod.800G4 cu Monitor LED", contractingauthority = @"Directia Judeteana de Statistica Harghita", supplier = @"NEXTRA SERVICE", contractvalue = @"39,606.00", currency = @"RON", cpvcode = @"30213000-5", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"HR", communityreference = @"No", publicationdate = @"Mar 29, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 68 , noticeno = @"DA22713876", contractobject = @"Scanere A4 duplex  FUJITSU fi-7280", contractingauthority = @"Directia Judeteana de Statistica Harghita", supplier = @"NEXTRA SERVICE", contractvalue = @"103,208.00", currency = @"RON", cpvcode = @"30216110-0", noticetype = @"Direct Acquisition", procedurestate = @"Refused offer", awardstate = @"Other", county = @"HR", communityreference = @"No", publicationdate = @"Mar 29, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 69 , noticeno = @"DA22717522", contractobject = @"Statie de lucru HP ELITEDESK 800 G4 cu Monitor HP", contractingauthority = @"DIRECTIA JUDETEANA DE STATISTICA HUNEDOARA", supplier = @"STREAM NETWORKS S.R.L.", contractvalue = @"39,893.00", currency = @"RON", cpvcode = @"30213000-5", noticetype = @"Direct Acquisition", procedurestate = @"Offering", awardstate = @"Running", county = @"HD", communityreference = @"No", publicationdate = @"Apr 1, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 70 , noticeno = @"DA22176158", contractobject = @"Echipamente IT pentru Proiectul Simplificarea legislatiei: resurse minerale si societati cu capital", contractingauthority = @"MINISTERUL ECONOMIEI", supplier = @"Mida Soft Business", contractvalue = @"54,743.00", currency = @"RON", cpvcode = @"30213100-6", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"B", communityreference = @"No", publicationdate = @"Jan 3, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 71 , noticeno = @"DA22624306", contractobject = @"Pachet echipamente IT - PC, software, memorii, SSD", contractingauthority = @"COMUNA SALIGNY", supplier = @"GMB Computers", contractvalue = @"4,009.31", currency = @"RON", cpvcode = @"30141200-1", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"CT", communityreference = @"No", publicationdate = @"Mar 18, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 72 , noticeno = @"DA22392629", contractobject = @"Monitor LED ACER 19.5"" / 19.5 inch HD 1366x768 @60Hz 5ms black, Imprimanta Laser jet LaserJet SAMSUN", contractingauthority = @"SPITALUL JUDETEAN DE URGENTA PITESTI", supplier = @"COMPUTECH", contractvalue = @"1,462.23", currency = @"RON", cpvcode = @"33195100-4", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"AG", communityreference = @"No", publicationdate = @"Feb 12, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 73 , noticeno = @"DA22680884", contractobject = @"Imprimanta Multifunctionala Laser Lexmark MX317DN / MX 317 DN 317DN Print Scan Copy Fax Network ADF", contractingauthority = @"SPITALUL JUDETEAN DE URGENTA PITESTI", supplier = @"COMPUTECH", contractvalue = @"1,752.99", currency = @"RON", cpvcode = @"30232110-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"AG", communityreference = @"No", publicationdate = @"Mar 26, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 74 , noticeno = @"DA22257127", contractobject = @"Calculator Computer Intel Core i3 7100", contractingauthority = @"SPITALUL MUNICIPAL "" ANGHEL SALIGNY"" FETESTI", supplier = @"COMPUTECH", contractvalue = @"2,048.74", currency = @"RON", cpvcode = @"30213300-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"IL", communityreference = @"No", publicationdate = @"Jan 21, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 75 , noticeno = @"DA22310526", contractobject = @"Sistem PC LENOVO IdeaCentre 510S-08IKL, Intel Core i5-7400 processor pana la 3.5GHz, 8GB, HDD 1TB +", contractingauthority = @"SPITALUL CLINIC DE PNEUMOFTIZIOLOGIE CONSTANTA", supplier = @"ALTEX ROMANIA S.R.L.", contractvalue = @"2,499.15", currency = @"RON", cpvcode = @"30213000-5", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"CT", communityreference = @"No", publicationdate = @"Jan 30, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 76 , noticeno = @"DA22352348", contractobject = @"Desktop Lenovo Think Centre V530s SFF + MONITOR E21 + WIN10PRO", contractingauthority = @"S.C. SALUBRITATE CRAIOVA", supplier = @"AS COMPUTER CRAIOVA S.R.L.", contractvalue = @"2,845.00", currency = @"RON", cpvcode = @"30213300-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"DJ", communityreference = @"No", publicationdate = @"Feb 6, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 77 , noticeno = @"DA22374384", contractobject = @"Achizitie bunuri (dotari)", contractingauthority = @"COMUNA SCOBINTI", supplier = @"OFFICE MAX S.R.L.", contractvalue = @"25,853.00", currency = @"RON", cpvcode = @"39263000-3", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"IS", communityreference = @"No", publicationdate = @"Feb 11, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 78 , noticeno = @"DA22382791", contractobject = @"Calculator PC Calculator Desktop DELL Intel Core i3 8100 RAM 4GB HDD 1 TB Windows 10 PRO", contractingauthority = @"Directia de Sanatate Publica Arges", supplier = @"COMPUTECH", contractvalue = @"1,794.96", currency = @"RON", cpvcode = @"30213300-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"AG", communityreference = @"No", publicationdate = @"Feb 11, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 79 , noticeno = @"DA22391259", contractobject = @"LAPTOP ASUS X507UA INTEL I5-8250U 3.40GHZ, 8GB,256GB SSD", contractingauthority = @"Liceul Teoretic Cujmir", supplier = @"HIDAGO", contractvalue = @"3,299.17", currency = @"RON", cpvcode = @"30213100-6", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"MH", communityreference = @"No", publicationdate = @"Feb 12, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 80 , noticeno = @"DA22403477", contractobject = @"Unitate PC , i3-8100, Mem 8GB,", contractingauthority = @"SPITALUL MUNICIPAL CODLEA", supplier = @"BIROTIC SRL", contractvalue = @"2,089.00", currency = @"RON", cpvcode = @"30213000-5", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"BV", communityreference = @"No", publicationdate = @"Feb 14, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 81 , noticeno = @"DA22462990", contractobject = @"Sistem PC calculator desktop si monitor led", contractingauthority = @"Clubul Sportiv Dinamo Bucuresti", supplier = @"COMPUTECH", contractvalue = @"2,319.34", currency = @"RON", cpvcode = @"30213300-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"B", communityreference = @"No", publicationdate = @"Feb 22, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 82 , noticeno = @"DA22466440", contractobject = @"Imprimanta Multifunctionala Laser", contractingauthority = @"Inspectoratul pentru Situatii de Urgenta General Magheru al Judetului Valcea", supplier = @"COMPUTECH", contractvalue = @"521.02", currency = @"RON", cpvcode = @"30232110-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"VL", communityreference = @"No", publicationdate = @"Feb 22, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 83 , noticeno = @"DA22233107", contractobject = @"Sistem PC Calculator Computer Desktop Intel Core i5 7400 RAM 8GB HDD 1TB Monitor 21.5 Windows 10 PRO", contractingauthority = @"SC APA SERV SA", supplier = @"COMPUTECH", contractvalue = @"2,437.82", currency = @"RON", cpvcode = @"30213300-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"TR", communityreference = @"No", publicationdate = @"Jan 16, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 84 , noticeno = @"DA22236042", contractobject = @"Sistem PC Tower - I5-4570", contractingauthority = @"ORASUL HOREZU - CONSILIUL LOCAL HOREZU", supplier = @"BIROCOPY S.R.L.", contractvalue = @"2,337.53", currency = @"RON", cpvcode = @"30141200-1", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"VL", communityreference = @"No", publicationdate = @"Jan 17, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 85 , noticeno = @"DA22436179", contractobject = @"SISTEM PC", contractingauthority = @"SPITAL DR. KARL DIEL JIMBOLIA", supplier = @"COMPUTECH", contractvalue = @"2,026.90", currency = @"RON", cpvcode = @"30213300-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"TM", communityreference = @"No", publicationdate = @"Feb 19, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 86 , noticeno = @"DA22480152", contractobject = @"Sistem PC LENOVO IdeaCentre 510S-08IKL, Intel Core i5-7400 processor pana la 3.5GHz, 8GB, HDD 1TB +", contractingauthority = @"SPITALUL CLINIC DE PNEUMOFTIZIOLOGIE CONSTANTA", supplier = @"ALTEX ROMANIA S.R.L.", contractvalue = @"2,230.00", currency = @"RON", cpvcode = @"30213000-5", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"CT", communityreference = @"No", publicationdate = @"Feb 26, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 87 , noticeno = @"DA22487964", contractobject = @"Licenta OEM Microsoft Windows 10 Pro 64 bit English", contractingauthority = @"Consiliul Judetean Buzau", supplier = @"NETWAVE SRL", contractvalue = @"5,100.00", currency = @"RON", cpvcode = @"30200000-1", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"BZ", communityreference = @"No", publicationdate = @"Feb 26, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 88 , noticeno = @"DA22491926", contractobject = @"Sistem PC Calculator Computer", contractingauthority = @"SPITALUL CLINIC DE URGENTE OFTALMOLOGICE", supplier = @"COMPUTECH", contractvalue = @"4,200.00", currency = @"RON", cpvcode = @"30213300-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"B", communityreference = @"No", publicationdate = @"Feb 27, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 89 , noticeno = @"DA22492008", contractobject = @"Sistem PC Calculator Computer", contractingauthority = @"SPITALUL CLINIC DE URGENTE OFTALMOLOGICE", supplier = @"COMPUTECH", contractvalue = @"4,152.96", currency = @"RON", cpvcode = @"30213300-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"B", communityreference = @"No", publicationdate = @"Feb 27, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 90 , noticeno = @"DA22492335", contractobject = @"Sistem PC Calculator Computer", contractingauthority = @"SPITALUL CLINIC DE URGENTE OFTALMOLOGICE", supplier = @"COMPUTECH", contractvalue = @"18,756.40", currency = @"RON", cpvcode = @"30213300-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"B", communityreference = @"No", publicationdate = @"Feb 27, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 91 , noticeno = @"DA22501830", contractobject = @"LAPTOP HP 250 G6 si Multifunctional HP LaserJet", contractingauthority = @"MINISTERUL APARARII NATIONALE - UNITATEA MILITARA 02648", supplier = @"STREAM NETWORKS S.R.L.", contractvalue = @"3,256.50", currency = @"RON", cpvcode = @"30213100-6", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"B", communityreference = @"No", publicationdate = @"Feb 28, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 92 , noticeno = @"DA22512891", contractobject = @"Sistem PC Calculator Computer Desktop Intel Core i3 7100 RAM 8GB / HDD 1TB Monitor 21.5"" Windows 10", contractingauthority = @"Spitalul de Pneumoftiziologie Calarasi", supplier = @"COMPUTECH", contractvalue = @"2,079.84", currency = @"RON", cpvcode = @"30213400-9", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"CL", communityreference = @"No", publicationdate = @"Mar 1, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 93 , noticeno = @"DA22552040", contractobject = @"Sistem PC / Calculator / Computer Desktop Intel Core i3 8100 / RAM 4GB / HDD 500GB / Windows 10 PRO", contractingauthority = @"Asociatia de Standardizare din Romania", supplier = @"COMPUTECH", contractvalue = @"3,532.78", currency = @"RON", cpvcode = @"30213300-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"B", communityreference = @"No", publicationdate = @"Mar 7, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 94 , noticeno = @"DA22597355", contractobject = @"Sistem PC Calculator Computer Desktop Intel i3 8100 RAM 4GB SSD 240GB Monitor 21.5"" Windows 10 PRO", contractingauthority = @"OFICIUL DE CADASTRU SI PUBLICITATE IMOBILIARA IALOMITA", supplier = @"COMPUTECH", contractvalue = @"20,714.30", currency = @"RON", cpvcode = @"30213300-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"IL", communityreference = @"No", publicationdate = @"Mar 13, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 95 , noticeno = @"DA22623499", contractobject = @"Sistem PC cu monitor 19 inch si licenta Windows 10 Pro", contractingauthority = @"INSTITUTIA PREFECTULUI - JUDETUL MURES", supplier = @"COMPUTECH", contractvalue = @"10,500.00", currency = @"RON", cpvcode = @"30213300-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"MS", communityreference = @"No", publicationdate = @"Mar 18, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 96 , noticeno = @"DA22634950", contractobject = @"Sistem PC WIN 10 PRO", contractingauthority = @"SPITALUL MUNICIPAL "" ANGHEL SALIGNY"" FETESTI", supplier = @"COMPUTECH", contractvalue = @"2,063.03", currency = @"RON", cpvcode = @"30213300-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"IL", communityreference = @"No", publicationdate = @"Mar 19, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 97 , noticeno = @"DA22661938", contractobject = @"Sistem PC Desktop Procesor Intel i3-8100 3.6GHz, 8GB DDR4, HDD+SSD, Monitor 21.5 inch si Windows 10", contractingauthority = @"Muzeul National de Istorie a Transilvaniei", supplier = @"Cubix IT Srl", contractvalue = @"2,099.90", currency = @"RON", cpvcode = @"30213000-5", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"CJ", communityreference = @"No", publicationdate = @"Mar 22, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 98 , noticeno = @"DA22680935", contractobject = @"Sistem PC / Calculator / Computer Desktop Intel Core i3 8100 / RAM 8GB / HDD 1TB / Windows 10 PRO", contractingauthority = @"Oficiul de Cadastru si Publicitate Imobiliara Mehedinti", supplier = @"COMPUTECH", contractvalue = @"1,888.24", currency = @"RON", cpvcode = @"30213300-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"MH", communityreference = @"No", publicationdate = @"Mar 26, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 99 , noticeno = @"DA22680978", contractobject = @"Imprimanta Multifunctionala Laser Lexmark MX317DN / MX 317 DN 317DN Print Scan Copy Fax Network ADF", contractingauthority = @"SPITALUL JUDETEAN DE URGENTA PITESTI", supplier = @"COMPUTECH", contractvalue = @"521.02", currency = @"RON", cpvcode = @"30232110-8", noticetype = @"Direct Acquisition", procedurestate = @"Refused conditions", awardstate = @"Other", county = @"AG", communityreference = @"No", publicationdate = @"Mar 26, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 100 , noticeno = @"DA22683460", contractobject = @"Unitate PC - Intel Core i5 7400 / RAM 8GB / HDD 1TB / Windows 10 PRO", contractingauthority = @"Oficiul de Cadastru si Publicitate Imobiliara Valcea", supplier = @"COMPUTECH", contractvalue = @"8,376.48", currency = @"RON", cpvcode = @"30213300-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"VL", communityreference = @"No", publicationdate = @"Mar 26, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 101 , noticeno = @"DA22685358", contractobject = @"statii de calcul", contractingauthority = @"Inspectoratul de Politie al Judetului Ilfov", supplier = @"Cubix IT Srl", contractvalue = @"5,396.40", currency = @"RON", cpvcode = @"30213000-5", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"B", communityreference = @"No", publicationdate = @"Mar 26, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 102 , noticeno = @"DA22689092", contractobject = @"Dotari multimedia pentru Scoala Giumnaziala nr 1 Copr B", contractingauthority = @"COMUNA  GIRCENI (PRIMARIA  GIRCENI)", supplier = @"TOTAL COMPUTERS S.R.L.", contractvalue = @"40,360.44", currency = @"RON", cpvcode = @"30141200-1", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"VS", communityreference = @"No", publicationdate = @"Mar 27, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 103 , noticeno = @"DA22689420", contractobject = @"Laptop ultraportabil Lenovo IdeaPad 530S-14IKB cu licenta Windows", contractingauthority = @"Centrul de Resurse Economice si Educatie pentru Dezvoltare", supplier = @"DANTE INTERNATIONAL S.A.", contractvalue = @"3,403.35", currency = @"RON", cpvcode = @"30213100-6", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"N/A", communityreference = @"No", publicationdate = @"Mar 27, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 104 , noticeno = @"DA22708551", contractobject = @"Sistem PC cu WIN 10 PRO", contractingauthority = @"SPITALUL MUNICIPAL "" ANGHEL SALIGNY"" FETESTI", supplier = @"COMPUTECH", contractvalue = @"2,071.43", currency = @"RON", cpvcode = @"30213300-8", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"IL", communityreference = @"No", publicationdate = @"Mar 29, 2019" });
                    
                    modelBuilder.Entity<Sheet1>().HasData(
                        new Sheet1(){ id20200909002008 = 105 , noticeno = @"DA22708435", contractobject = @"Laptop HP 15-BS022NQ 15.6 inch HD Intel Core i3-6006U 4GB DDR4 500GB HDD GMA HD 520", contractingauthority = @"Institutia Prefectului Jud Ilfov", supplier = @"Smart Network Team", contractvalue = @"1,980.00", currency = @"RON", cpvcode = @"30213100-6", noticetype = @"Direct Acquisition", procedurestate = @"Agreed", awardstate = @"Awarded", county = @"B", communityreference = @"No", publicationdate = @"Mar 29, 2019" });
                    
            OnSeed(modelBuilder);


        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        partial void OnSeed(ModelBuilder modelBuilder);       
    }
}