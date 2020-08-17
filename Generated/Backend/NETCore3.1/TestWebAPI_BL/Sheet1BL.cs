using System;

namespace TestWebAPI_BL
{
    public partial class Sheet1
    {
        #region partial functions
        partial void OnConstructor();
        partial void OnCopyConstructor(Sheet1 other, bool withID);
        #endregion

        #region constructors
        public Sheet1 (){
            OnConstructor();
        }
        
        public Sheet1(Sheet1 other):base(){ 

            OnCopyConstructor(other:other,withID: false);
                
        }
        public void CopyPropertiesFrom(Sheet1 other, bool withID){
            if(withID){
                this.ID= other.ID;
            }

            this.iso_code = other.iso_code;
                
            this.continent = other.continent;
                
            this.location = other.location;
                
            this.date = other.date;
                
            this.total_cases = other.total_cases;
                
            this.new_cases = other.new_cases;
                
            this.total_deaths = other.total_deaths;
                
            this.new_deaths = other.new_deaths;
                
            this.total_cases_per_million = other.total_cases_per_million;
                
            this.new_cases_per_million = other.new_cases_per_million;
                
            this.total_deaths_per_million = other.total_deaths_per_million;
                
            this.new_deaths_per_million = other.new_deaths_per_million;
                
            this.new_tests = other.new_tests;
                
            this.total_tests = other.total_tests;
                
            this.total_tests_per_thousand = other.total_tests_per_thousand;
                
            this.new_tests_per_thousand = other.new_tests_per_thousand;
                
            this.new_tests_smoothed = other.new_tests_smoothed;
                
            this.new_tests_smoothed_per_thousand = other.new_tests_smoothed_per_thousand;
                
            this.tests_per_case = other.tests_per_case;
                
            this.positive_rate = other.positive_rate;
                
            this.tests_units = other.tests_units;
                
            this.stringency_index = other.stringency_index;
                
            this.population = other.population;
                
            this.population_density = other.population_density;
                
            this.median_age = other.median_age;
                
            this.aged_65_older = other.aged_65_older;
                
            this.aged_70_older = other.aged_70_older;
                
            this.gdp_per_capita = other.gdp_per_capita;
                
            this.extreme_poverty = other.extreme_poverty;
                
            this.cardiovasc_death_rate = other.cardiovasc_death_rate;
                
            this.diabetes_prevalence = other.diabetes_prevalence;
                
            this.female_smokers = other.female_smokers;
                
            this.male_smokers = other.male_smokers;
                
            this.handwashing_facilities = other.handwashing_facilities;
                
            this.hospital_beds_per_thousand = other.hospital_beds_per_thousand;
                
            this.life_expectancy = other.life_expectancy;
                
            OnCopyConstructor(other,withID);
        }

        #endregion
        
        #region Properties
        public long ID{get;set;}
            

            public String iso_code { get; set; }
            
            public String continent { get; set; }
            
            public String location { get; set; }
            
            public String date { get; set; }
            
            public Decimal total_cases { get; set; }
            
            public Decimal new_cases { get; set; }
            
            public Decimal total_deaths { get; set; }
            
            public Decimal new_deaths { get; set; }
            
            public Decimal total_cases_per_million { get; set; }
            
            public Decimal new_cases_per_million { get; set; }
            
            public Decimal total_deaths_per_million { get; set; }
            
            public Decimal new_deaths_per_million { get; set; }
            
            public String new_tests { get; set; }
            
            public String total_tests { get; set; }
            
            public String total_tests_per_thousand { get; set; }
            
            public String new_tests_per_thousand { get; set; }
            
            public String new_tests_smoothed { get; set; }
            
            public String new_tests_smoothed_per_thousand { get; set; }
            
            public String tests_per_case { get; set; }
            
            public String positive_rate { get; set; }
            
            public String tests_units { get; set; }
            
            public String stringency_index { get; set; }
            
            public Decimal population { get; set; }
            
            public Decimal population_density { get; set; }
            
            public Decimal median_age { get; set; }
            
            public Decimal aged_65_older { get; set; }
            
            public Decimal aged_70_older { get; set; }
            
            public Decimal gdp_per_capita { get; set; }
            
            public String extreme_poverty { get; set; }
            
            public Decimal cardiovasc_death_rate { get; set; }
            
            public Decimal diabetes_prevalence { get; set; }
            
            public String female_smokers { get; set; }
            
            public String male_smokers { get; set; }
            
            public Decimal handwashing_facilities { get; set; }
            
            public Decimal hospital_beds_per_thousand { get; set; }
            
            public Decimal life_expectancy { get; set; }
                    #endregion
        
    }
}
