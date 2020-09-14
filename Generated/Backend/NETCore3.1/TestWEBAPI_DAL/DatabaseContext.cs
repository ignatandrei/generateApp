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

            public virtual DbSet<OGChecklistv11> OGChecklistv11{ get; set; }
                    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<OGChecklistv11>()
                .ToTable("1","OG Checklist v1")
                .HasKey(it=>it.id20200914033604);
         
            OnModelCreatingPartial(modelBuilder);
            Seed(modelBuilder);
        }
        void Seed(ModelBuilder modelBuilder){


                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 1 , ref = @"Availability and performance (EBA Guidelines 2 and 3) ", checklistquestion = @"", fcanotes = @"", obienotes = @"", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 2 , ref = @"FCA Q1", checklistquestion = @"Has the ASPSP defined service level targets for out of hours support, monitoring, contingency plans and maintenance for its dedicated interface that are at least as stringent as those for the interface(s) used by its own payment service users (EBA Guideline 2.1)?", fcanotes = @"Yes/No", obienotes = @"Answer must be “Yes”", obie = @"Required", psd2 = @"Mandatory", cmaorder = @"n/a", generated_reg.references = @"RTS Art. 32(1)" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 3 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See FCA PSRs Approach 17.113", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 4 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"EBA GL 2.1" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 5 , ref = @"FCA Q2", checklistquestion = @"Has the ASPSP put in place measures to calculate and record performance and availability indicators, in line with EBA Guidelines 2.2 and 2.3?", fcanotes = @"Yes/No", obienotes = @"Answer must be ""Yes""", obie = @"Required", psd2 = @"Mandatory", cmaorder = @"n/a", generated_reg.references = @"RTS Art. 32(2)" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 6 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"Must be calculated in line with EBA GL 2.4 ", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 7 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See FCA PSRs Approach 17.113", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"EBA GL 2.2 and 2.3" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 8 , ref = @"2.1", checklistquestion = @"Do you calculate your availability and performance KPIs in accordance with the OBIE guidance?", fcanotes = @"n/a", obienotes = @"Answer must be ""Yes"" for CMA9 and should be “Yes” for other ASPSPs", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"Mandatory", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 9 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See Sections 2.1.1 and 2.1.2 of the OG", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 10 , ref = @"2.2", checklistquestion = @"Does your dedicated interface provide a quarterly uptime of at least 99.5%?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 11 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See section 2.1.1", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 12 , ref = @"2.3", checklistquestion = @"Does your dedicated interface undertake no more than a quarterly downtime of 0.5%.", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 13 , ref = @"", checklistquestion = @"(circa 22 hours per quarter to allow for planned releases, updates, and also any unplanned downtime).", fcanotes = @"", obienotes = @"2.1.1", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 14 , ref = @"2.4", checklistquestion = @"Does your dedicated interface respond to an average TTLB of 750 milliseconds per response, or per page of results for up to 100 records for larger payloads?
", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 15 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See section 2.1.2", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 16 , ref = @"2.5", checklistquestion = @"Does your dedicated interface respond to an average TTLB of 750 milliseconds per response, or per page of results for up to 100 records for larger payloads?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 17 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See section 2.1.2", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 18 , ref = @"2.6", checklistquestion = @"Does your dedicated interface for Confirmation of Funds (CoF) have a response time (CBPII and PISP) with an average TTLB of 300 and a max of 500 milliseconds per response.", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 19 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See section 2.1.2", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 20 , ref = @"2.7", checklistquestion = @"Do your daily error response rates have an average of 0.5% or less across all endpoints?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""", obie = @"Recommended", psd2 = @" Optional ", cmaorder = @" n/a", generated_reg.references = @" n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 21 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See section 2.1.2", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 22 , ref = @"FCA Q3", checklistquestion = @"Please set out the plan for the quarterly publication of daily statistics on the availability and performance of the dedicated interface and payment service user interface.", fcanotes = @"Free text response", obienotes = @"ASPSP must be able to confirm they have got a plan", obie = @"Required", psd2 = @"Mandatory", cmaorder = @"n/a", generated_reg.references = @"RTS Art. 32(4)" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 23 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See FCA PSRs Approach 17.114-117", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"EBA GL 3.1" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 24 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"OBIE guidance: The website address where ASPSPs intend to publish their statistics should be ""easily accessible"" and appear closely to webpages whether other service metrics are published. The FCA advise this is in ""close proximity"" to the service metrics UK ASPSPs are required to publish under BCOBS 7.", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 25 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"We would recommend this plan includes a link to where the statistics will be published, a wireframe of the presentation to ensure it is valuable to viewers, and a description of all statistics you plan to publish. We refer ASPSPs to the reporting template in Section 2.2.2 as a basis.", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 26 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"Publication each quarter will present daily statistics on a quarterly basis on availability and performance as set out in Guideline 2.2 and 2.3 of the EBA Guidelines for the dedicated interface and each payment service user interface together.", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 27 , ref = @"3.1", checklistquestion = @"Do you provide OBIE with your availability and performance statistics on a monthly basis?", fcanotes = @"n/a", obienotes = @"Answer should be “Yes” using the reporting template provided in Section 2.2.2 and includes both the dedicated interface and PSU interface", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 28 , ref = @"Availability and performance (EBA Guidelines 4, 5 and 6) ", checklistquestion = @"", fcanotes = @"", obienotes = @"", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 29 , ref = @"FCA Q4", checklistquestion = @"Please provide a summary of the results of stress tests undertaken", fcanotes = @"Free text response", obienotes = @"ASPSP must be able to confirm they have provided a summary of the results of stress tests undertaken", obie = @"Required", psd2 = @"Mandatory", cmaorder = @"n/a", generated_reg.references = @"RTS Art. 32(2)" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 30 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See FCA PSRs Approach 17.118-121", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 31 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"Stress testing should be undertaken in accordance with EBA Guideline 4.2 a-d and should include the assumptions used as a basis for stress testing for each point. Response should include weaknesses or issues identified and confirmation that these have been addressed. ASPSPs should state whether the views of AISPs, PISPs and CBPIIs, or representatives of these market participants were sought about likely peak usage periods or other stresses. ", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"EBA GL 4.1-3" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 32 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"The following topics (as a minimum) are recommended:", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 33 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"- Test scenario descriptions covering API call volumes (per end point)", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 34 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"- Numbers of TPPs represented", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 35 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"- Test purpose (e.g. stress/soak) and duration", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 36 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"- End point response times (per end point) and response time distributions", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 37 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"- Errors generated", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 38 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"- Weaknesses/issues identified and resolutions", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 39 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"- Views of TPPs about likely peak usage periods or other stresses", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 40 , ref = @"4.1", checklistquestion = @"Have you run stress tests on your production environment, or one with similar infrastructure?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 41 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See section 3.2", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 42 , ref = @"4.2", checklistquestion = @"Did your stress testing cover a range of realistic test cases and durations at realistic volumes (based on predicted volumes for 6 months’ time)?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 43 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See section 3.2", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 44 , ref = @"4.3", checklistquestion = @"Do you run stress tests every 6 months and in the event of any change which may require re-testing?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 45 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See section 3.2", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 46 , ref = @"FCA Q5", checklistquestion = @"Please describe the method(s) of carrying out the authentication procedure(s) of the payment service user that are supported by the dedicated interface.", fcanotes = @"Confirm that supporting evidence has been provided", obienotes = @"The ASPSP must be able to provide explanation and evidence to prove that they offer at least one method of carrying out the authentication procedure of the PSU in a way that does not create obstacles", obie = @"Required", psd2 = @"Mandatory", cmaorder = @"n/a", generated_reg.references = @"RTS Art. 32(3)" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 47 , ref = @"", checklistquestion = @"•Redirection ", fcanotes = @"Free text summary of each authentication procedure", obienotes = @"See FCA PSRs Approach 17.122-149", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 48 , ref = @"", checklistquestion = @"•Decoupled", fcanotes = @"Free text explanation of why the methods of carrying out the authentication procedure does not create obstacles", obienotes = @"This should include reference to EBA Guideline 5.2 a-d, channel coverage, the methods of authentication a PSU can use, and assurance as to how this has been developed with respect to various TPP propositions in the market for each method of access offered by the ASPSP.", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"EBA GL 5.1-2" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 49 , ref = @"", checklistquestion = @"•Embedded", fcanotes = @"Supporting file attachments such as screenshots, walkthroughs, videos and wireframes", obienotes = @"When ASPSPs assess whether their method of access constitutes an obstacle, we would expect consideration to be given in relation to four key categories, as outlined in RTS, Article 32(3) and EBA Guideline 5.2, and include the listed headings below", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 50 , ref = @"", checklistquestion = @"•Other authentication method", fcanotes = @"", obienotes = @"", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 51 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"(i) Does not prevent PISPs and AISPs from relying upon the security credentials issued by the ASPSP", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 52 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"(ii) PISPs, AISPs and CBPIIs do not have to comply with any different or additional requirements, other than those imposed by legislation, that are not equally imposed on all other types of PSPs", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 53 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"(iii) There are no additional checks on the consent given by the PSU to the PISP, AISP or CBPII to access the information of the payment account held in the ASPSP or initiate payments", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 54 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"(iv) The IT solution for the dedicated interface and its implementation do not give rise to unnecessary delay, friction or any other attributes that would mean that payment service users are directly or indirectly dissuaded from using the services of PISPs, AISPs and CBPIIs include.", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 55 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"We would expect that for points (ii), (iii) and (iv) in particular ASPSPs consider the CEGs and CEG Checklist, which have been specifically developed to assist ASPSPs in ensuring that their implementation of redirection does not constitute an obstacle. We would note that, while the EBA and FCA have made clear that offering only Redirection is not an obstacle per se, offering Decoupled in addition to Redirection is likely to enhance an exemption application as several TPPs have made clear their business models are either dependent on it or vastly more attractive if it is supported.

The way ASPSPs choose to demonstrate their journeys to NCAs is within their domain, but as a minimum we would expect annotated wireframes as exemplified in our CEG, clearly showing each step of the customer journey, with a detailed description of each.", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 56 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"An actual video demonstration of each of the journeys - covering all channels offered for authentication - would be beneficial, particularly if it called attention to how the CEG Checklist has been met and how the points referenced in EBA Guideline 5.2.(a) regarding ""relying on ASPSP issued security credentials"" and 5.2(c) regarding ""no additional checks on consent"" and 5.2(d) regarding ""unnecessary delay, friction"" have been handled.", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 57 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"The application should also include a comparison between customer journey when accessing the ASPSP's online channels directly with the Open Banking customer journey when using a TPP. This must clearly demonstrate that authentication process is not more burdensome in an Open Banking journey", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 58 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"Any quantitative data that can be provided to support your argument would be highly beneficial e.g conversion rates and the range of TPPs your own customers are using. Similarly, statements from the TPPs that have been engaged in the Design of your interface would be beneficial to include.", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 59 , ref = @"5.1", checklistquestion = @"Have you implemented all required elements of the Customer Experience Guidelines (CEG) and completed the CEG checklist?", fcanotes = @"n/a", obienotes = @"Answer must be ""Yes"" for CMA9 and should be “Yes” for other ASPSPs", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"Mandatory", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 60 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See Section 3.3 and 3.4", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 61 , ref = @"FCA Q6", checklistquestion = @"Please provide information on whether, and, if so, how the ASPSP has engaged with AISPs, PISPs and CBPIIs in the design and testing of the dedicated interface.", fcanotes = @"Free text explanation of how ASPSP engaged with TPPs", obienotes = @"ASPSP must be able to confirm they have engaged with a range of TPPs in the design and testing of their dedicated interface", obie = @"Required", psd2 = @"Mandatory", cmaorder = @"n/a", generated_reg.references = @"EBA GL 6.6" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 62 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See FCA PSRs Approach 17.150-155", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 63 , ref = @"FCA Q7", checklistquestion = @"Please provide the date (DD/MM/YYYY) from which the ASPSP has made available, at no charge, upon request, the documentation of the technical specification of the dedicated interface specifying a set of routines, protocols, and tools needed by AISPs, PISPs and CBPIIs to interoperate with the systems of the ASPSP.", fcanotes = @"DD/MM/YYYY from which made available", obienotes = @"This must be 6 months prior to the RTS coming into force (i.e. 14 March 2019 or 6 month prior to market launch.)", obie = @"Required", psd2 = @"Mandatory", cmaorder = @"n/a", generated_reg.references = @"RTS Art. 30(3)" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 64 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See FCA PSRs Approach 17.156 -17.163", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 65 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"EBA GL 6.4" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 66 , ref = @"7.1", checklistquestion = @"Do you publish a machine readable list of all methods of access, functionality and data fields for your dedicated interface?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""", obie = @"Recommended", psd2 = @"n/a", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 67 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"If this differs by channel (app vs. browser) and brand/product this should be made clear", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 68 , ref = @"FCA Q8", checklistquestion = @"Please provide the date (DD/MM/YYYY) on which the ASPSP published a summary of the technical specification of the dedicated interface on its website and a web link.", fcanotes = @"DD/MM/YYYY from which made available", obienotes = @"This must be 6 months prior to the RTS coming into force (i.e.14 March 2019 or 6 month prior market to launch. ", obie = @"Required", psd2 = @"Mandatory", cmaorder = @"n/a", generated_reg.references = @"RTS Art. 30(3)" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 69 , ref = @"", checklistquestion = @"", fcanotes = @"URL:", obienotes = @"See FCA PSRs Approach 17.156 -17.163", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"EBA GL 6.4" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 70 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"An ASPSP will need to provide a web link (URL) to the webpage where the technical specifications are provided. The website needs to be ""advertised"" to the ecosystem", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 71 , ref = @"FCA Q9", checklistquestion = @"Please provide the date (DD/MM/YYYY) on which the testing facility became available for use by AISP, PISPs, CBPIIs (and those that have applied for the relevant authorisation)", fcanotes = @"DD/MM/YYYY from which made available", obienotes = @"This must be 6 months prior to the RTS coming into force (i.e.14 March 2019 or 6 month prior to market launch. ", obie = @"Required", psd2 = @"Mandatory", cmaorder = @"n/a", generated_reg.references = @"RTS Art. 30(5)" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 72 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See FCA PSRs Approach 17.156 -17.163", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 73 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"Must allow TPPs to test the dedicated interface in relation to points a-g in EBA Guideline 6.5 - however, see OBIE view on point g in Section 3.1.3", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"EBA GL 6.5" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 74 , ref = @"9.1", checklistquestion = @"Does your testing facility include all functionality of the production interface?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 75 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See Section 3.1.3", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 76 , ref = @"9.2", checklistquestion = @"Does your testing facility use the same security profile/model and be configured in the same way as that which protects the production APIs?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 77 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See Section 3.1.3", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 78 , ref = @"9.3", checklistquestion = @"Does your testing facility replicate the on-boarding process of the ASPSPs production facility, including TPP on boarding and the exchange of certificates for identification and message signing?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 79 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See Section 3.1.3", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 80 , ref = @"9.4", checklistquestion = @"Does your testing facility allow TPPs to test the use of both certificates which have the same format/structure as eIDAS certificates (i.e. ""eIDAS-like"" certificates) and production eIDAS certificates issued by a QTSP?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 81 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See Section 3.1.3", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 82 , ref = @"9.5", checklistquestion = @"Does your testing facility contain the volume and variance of data sufficient to support all technical and functional testing including pagination, but without including any actual customer data?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 83 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See Section 3.1.3", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 84 , ref = @"9.6", checklistquestion = @"Does your testing facility provide TPPs with a number of test accounts that enable the functionality and access to non-PSU data that will replicate the experience in production?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 85 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See Section 3.1.3", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 86 , ref = @"9.7", checklistquestion = @"Does your testing facility have sufficient capacity, performance and other characteristics to enable effective and realistic TPP testing?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 87 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See Section 3.1.3", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 88 , ref = @"9.8", checklistquestion = @"Does your testing facility enable TPPs to start testing their technical solutions at least six months prior to the application date of the RTS?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 89 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See Section 3.1.3", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 90 , ref = @"9.9", checklistquestion = @"Will your testing facility remain as an ongoing facility and to support future development or changes to the dedicated interface?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 91 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See Section 3.1.3", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 92 , ref = @"FCA Q10", checklistquestion = @"Provide the number of different AISPs, PISPs and CBPIIs that have used the testing facility", fcanotes = @"Number by type", obienotes = @"Answer should be >0 for each type (AIS, PIS and CBPII)", obie = @"Required", psd2 = @"Mandatory", cmaorder = @"n/a", generated_reg.references = @"RTS Art. 30(5)" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 93 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See FCA Approach 17.159-163", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"EBA GL 6.6" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 94 , ref = @"FCA Q11", checklistquestion = @"Please provide a summary of the results of the testing as required.", fcanotes = @"Free text", obienotes = @"ASPSPs must have produced a summary of the results of their testing", obie = @"Required", psd2 = @"Mandatory", cmaorder = @"n/a", generated_reg.references = @"RTS Art. 30(5)" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 95 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See FCA PSRs Approach 17.156-163", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"EBA GL 6.6" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 96 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"•Identify which, if any, of EBA GL 6.5 a-g have presented problems when tested", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 97 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"with AISPs, PISPs and CBPIIs", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 98 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"•Briefly describe what these problems were and whether they were raised by the ASPSP, or by AISPs, PISPs or CBPIIs", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 99 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"•Briefly describe the steps taken to resolve the problems and whether the problems have been resolved", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 100 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"Test Summary Report should include: ", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 101 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"•Introduction & purpose of document", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 102 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"•In scope and out of scope test coverage", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 103 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"•Entry criteria and status", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 104 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"•Test Execution Coverage (details of test cases and success status)", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 105 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"•Summary of Issues/Defects", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 106 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"•List of outstanding issue/defect and impact", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 107 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"•Exit Criteria status", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 108 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"•Recommendations/Conclusions", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 109 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"•Appendix - evidence of results ", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 110 , ref = @"11.1", checklistquestion = @"Have you completed all other relevant testing of the dedicated interface as would normally occur according to your established processes and procedures i.e. security, penetration and other types of testing to ensure robustness and security etc.?", fcanotes = @"n/a", obienotes = @"Answer should be “Yes”", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 111 , ref = @"11.2", checklistquestion = @"Have you successfully run all OBIE conformance tests for the Account Information and Transaction API?", fcanotes = @"n/a", obienotes = @"Answer must be ""Yes"" for CMA9 and should be “Yes” for other ASPSPs", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"Mandatory", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 112 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See section 3.1.2", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 113 , ref = @"11.3", checklistquestion = @"Have you successfully run all OBIE conformance tests for the Payment Initiation API?", fcanotes = @"n/a", obienotes = @"Answer must be ""Yes"" for CMA9 and should be “Yes” for other ASPSPs", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"Mandatory", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 114 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See section 3.1.2", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 115 , ref = @"11.4", checklistquestion = @"Have you successfully run all OBIE conformance tests for the Confirmation of Funds API?", fcanotes = @"n/a", obienotes = @"Answer must be ""Yes"" for CMA9 and should be “Yes” for other ASPSPs", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"Mandatory", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 116 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See section 3.1.2", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 117 , ref = @"11.5", checklistquestion = @"Have you successfully run all OBIE conformance tests for the Event Notification API?", fcanotes = @"n/a", obienotes = @"Answer should be “Yes”", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 118 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See section 3.1.2", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 119 , ref = @"11.6", checklistquestion = @"Have you successfully run all FAPI conformance tests for the security profile for redirect flows (or alternatively the OBIE tests for conformance to the OB Security Profile)?", fcanotes = @"n/a", obienotes = @"Answer must be ""Yes"" for CMA9 and should be “Yes” for other ASPSPs", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"Mandatory", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 120 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See section 3.1.2", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 121 , ref = @"11.7", checklistquestion = @"Have you successfully run all CIBA conformance tests for the security profile for decoupled flows?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 122 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See section 3.1.2", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 123 , ref = @"11.8", checklistquestion = @"Have you successfully run all DCR conformance tests for Dynamic Client Registration?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 124 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See section 3.1.2", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 125 , ref = @"11.9", checklistquestion = @"Do you provide a facility for TPPs who have been involved with testing to confirm they are satisfied with the testing facility before moving to production?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""", obie = @"Recommended", psd2 = @"n/a", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 126 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"This is designed to support proving the requirements of ""wide usage"" and avoid the charge of presenting an obstacle to TPPs as part of an exemption application", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 127 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"e.g. research, testimonials, review systems ", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 128 , ref = @"FCA Q12", checklistquestion = @"Please provide a description of the usage of the dedicated interface in a three month (or longer) period prior to submission of the exemption request?", fcanotes = @"Free text", obienotes = @"ASPSPs must provide a description of the usage of the dedicated interface", obie = @"Required", psd2 = @"Mandatory", cmaorder = @"n/a", generated_reg.references = @"RTS Art. 33(6)(c)" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 129 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See FCA PSRs Approach 17.164-170", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 130 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"Three months may run concurrently with testing, could include information like number of successful calls, number of TPPs etc.", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"EBA GL 7.1(a)" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 131 , ref = @"12.1", checklistquestion = @"Do you provide a facility for TPPs who have used your dedicated interface for 3 months to confirm they are satisfied with the interface i.e. with no significant ongoing defects?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""", obie = @"Recommended", psd2 = @"n/a", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 132 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"This is designed to support proving the requirements of ""wide usage"" and avoid the charge of presenting an obstacle to TPPs as part of an exemption application", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 133 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"e.g. research, testimonials, review systems ", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 134 , ref = @"FCA Q13", checklistquestion = @"Describe the measures undertaken to ensure wide use of the dedicated interface by AISPs, PISPs, CBPIIs.", fcanotes = @"Free text", obienotes = @"ASPSPs must provide a description of how they have met the requirements of wide usage of the interface", obie = @"Required", psd2 = @"Mandatory", cmaorder = @"n/a", generated_reg.references = @"EBA GL 7.1(b)" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 135 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See FCA PSRs Approach 17.164-170", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 136 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"Describe the measures undertaken to ensure that the availability of the testing facilities for these aspects has been well publicised via appropriate channels, including where appropriate the website of the ASPSP, social media, industry trade bodies, conferences and direct engagement with known market actors. We expect the ASPSP to demonstrate that at least 3 months of communication of the testing facilities has taken place", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 137 , ref = @"Problem Resolution (EBA Guideline 8) ", checklistquestion = @"", fcanotes = @"", obienotes = @"", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 138 , ref = @"FCA Q14", checklistquestion = @"Please describe the systems or procedures in place for tracking, resolving and closing problems, particularly those reported by AISPs, PISPs, and CBPIIs", fcanotes = @"Free text", obienotes = @"ASPSPs must describe how they meet the requirements of EBA GL 8.1(a) and 2.1", obie = @"Required", psd2 = @"Mandatory", cmaorder = @"n/a", generated_reg.references = @"EBA GL 8.1(a)" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 139 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See FCA PSRs Approach 171-172", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"EBA GL 2.1" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 140 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"This should include describing out of hours support, service level objectives for problems resolution, ticketing systems for issues raised. Confirm that the service level for dedicated interface problem resolution as stringent as the service level for resolving problems with the interface used by the ASPSP’s own payment service users (as per EBA Guideline 2.1). This should include an outline of what the service level targets are for each.", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 141 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"The FCA requests confirmation that the service level for dedicated interface problem resolution is as stringent as the service level for resolving problems with the interface used by the ASPSP’s own payment service users (as per EBA Guideline 2.1). This should include an outline of what the service level targets are for each.", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 142 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"OBIE recognises that the level of technical support that is required by an AISP, PISP or CBPII is likely to be more substantial and specific than a PSU. OBIE therefore recommends that an ASPSP introduces additional SLAs to support testing or dedicated interface requirements for the AISP, PISP or CBPII to ensure their needs are effectively addressed.", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 143 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"OBIE suggests that the description should include the following:", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 144 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"•Name of system and a brief description", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 145 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"•How are issues tracked, resolved and closed", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 146 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"•The type of ticket system used", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 147 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"•Confirmation of FAQs to support problem resolution", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 148 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"•ASPSP brands/products covered", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 149 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"•Is this for the testing facility, production system or both", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 150 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"•Can this be used by PISP, AISP, CBPII, Other", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 151 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"•Access details (e.g. URL, email address, phone number)", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 152 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"•Hours of operation (including out of hours support)", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 153 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"•Details of SLA for acknowledgement, resolution/fix for dedicated interface", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 154 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"•Whether these SLAs are as stringent as or better than those for the PSU interface", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 155 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"•Detail of the reporting capabilities and audit trail ", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 156 , ref = @"14.1", checklistquestion = @"Do your policies and procedures include the direction to update FAQs in response to regular ticket analysis?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 157 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See Section 4.1", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 158 , ref = @"14.2", checklistquestion = @"Are you registered for the Open Banking Dispute Management System (DMS)?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 159 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See Section 4.2", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 160 , ref = @"14.3", checklistquestion = @"Do you regularly review outstanding tickets that have exceeded their SLA and prioritise those with the severest impact on the user (including TPPs)?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 161 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See Section 4.1", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 162 , ref = @"FCA Q15", checklistquestion = @"Please explain any problems, particularly those reported by AISPs, PISPs and CBPIIs, that have not been resolved in accordance with the service level targets defined under EBA Guideline 2.1", fcanotes = @"Free text", obienotes = @"ASPSPs must describe how they meet the requirements of EBA GL 2.1 and 8.1(b) ", obie = @"Required", psd2 = @"Mandatory", cmaorder = @"Mandatory", generated_reg.references = @"RTS Art. 33(6)(d)" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 163 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"See FCA PSRs Approach 17.171-172", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 164 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"This list of unresolved issues should explain clearly why it has been difficult to resolve and detail the remediation plan to resolve the issue.", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"EBA GL 8.1(b) and 2.1" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 165 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"ASPSPs should regularly review any outstanding tickets that have exceeded their SLA and prioritise those with the greatest impact on the user. This rationale should be recorded within the problem resolution policy and an extract should be included in the explanation provided to the NCA of any problems that have not been resolved without undue delay. ", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 166 , ref = @"", checklistquestion = @"", fcanotes = @"", obienotes = @"In our view, for the purposes of the exemption, the explanation should focus on problems raised during functional testing under SCA-RTS Article 30(5) and the areas for testing identified in EBA Guideline 6.5 points a-g. ASPSPs should inform their NCA of the number of reported problems from these categories that have breached its service level targets for problems resolution, and break down this number into the a-g categories. ASPSPs should also include a description of problems reported during operational use of the dedicated interface.", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 167 , ref = @"Change and Communication Management ", checklistquestion = @"", fcanotes = @"", obienotes = @"", obie = @"", psd2 = @"", cmaorder = @"", generated_reg.references = @"" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 168 , ref = @"16", checklistquestion = @"Do you publish the specifications for your dedicated interface at least six month before the 14 September 2019 or at least 6 months before the target date of your market launch?", fcanotes = @"n/a", obienotes = @"Answer must be ""Yes""
See Section 5.2", obie = @"Required", psd2 = @"Mandatory", cmaorder = @"n/a", generated_reg.references = @"RTS Article 30(3)" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 169 , ref = @"17", checklistquestion = @"Do you give TPPs at least three months' notice of any change to the technical specification of your dedicated interface (except in the case of an emergency)?", fcanotes = @"n/a", obienotes = @"Answer must be ""Yes""
See Section 5.2", obie = @"Required", psd2 = @"Mandatory", cmaorder = @"n/a", generated_reg.references = @"RTS Article 30(4)" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 170 , ref = @"18", checklistquestion = @"Do you provide notice of any changes to optional (i.e. non PSD2 required) functionality and fields?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""
See Section 5.2", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 171 , ref = @"19", checklistquestion = @"Do you provide 1 month's notice of all planned downtime?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""
See Section 5.1", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 172 , ref = @"20", checklistquestion = @"Do you confirm planned downtime 5 business days before each event?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""
See Section 5.1", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 173 , ref = @"21", checklistquestion = @"Do you use OBIE's notification service to inform TPPs in advance of any planned changes (including planned downtime)?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""
See Section 5.4", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 174 , ref = @"22", checklistquestion = @"Do you use OBIE Managed Roll out process to ensure that sufficient TPPs have migrated their Apps and customers to any new version (major or minor) before deprecating a previous version?", fcanotes = @"n/a", obienotes = @"Answer must be ""Yes"" for CMA9 and should be “Yes” for other ASPSPs
See Section 5.2", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"Mandatory", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 175 , ref = @"23", checklistquestion = @"Do you provide backward and forward compatibility across versions? (thereby maintaining long-lived consent).", fcanotes = @"n/a", obienotes = @"Answer must be ""Yes"" for CMA9 and should be “Yes” for other ASPSPs
See Section 5.2", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"Mandatory", generated_reg.references = @"n/a" });
                    
                    modelBuilder.Entity<OGChecklistv11>().HasData(
                        new OGChecklistv11(){ id20200914033604 = 176 , ref = @"24", checklistquestion = @"Do you use OBIE's notification service to inform TPPs of contingency measures in advance of any unplanned planned downtime?", fcanotes = @"n/a", obienotes = @"Answer should be ""Yes""
See Section 5.4", obie = @"Recommended", psd2 = @"Optional", cmaorder = @"n/a", generated_reg.references = @"n/a" });
                    
            OnSeed(modelBuilder);


        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        partial void OnSeed(ModelBuilder modelBuilder);       
    }
}