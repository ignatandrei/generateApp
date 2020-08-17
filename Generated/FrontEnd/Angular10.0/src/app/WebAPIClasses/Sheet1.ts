

export class Sheet1
    {
        
        
        public constructor(other:Sheet1 = null){ 

            if(other != null){
				this.CopyPropertiesFrom(other, true);
			}
                
        }
        public CopyPropertiesFrom(other:Sheet1, withID: boolean):void{
            if(withID){
                this.id= other.id;
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
                
            
        }
        public  id: number;
            

            public iso_code : string;
            
            public continent : string;
            
            public location : string;
            
            public date : string;
            
            public total_cases : number;
            
            public new_cases : number;
            
            public total_deaths : number;
            
            public new_deaths : number;
            
            public total_cases_per_million : number;
            
            public new_cases_per_million : number;
            
            public total_deaths_per_million : number;
            
            public new_deaths_per_million : number;
            
            public new_tests : string;
            
            public total_tests : string;
            
            public total_tests_per_thousand : string;
            
            public new_tests_per_thousand : string;
            
            public new_tests_smoothed : string;
            
            public new_tests_smoothed_per_thousand : string;
            
            public tests_per_case : string;
            
            public positive_rate : string;
            
            public tests_units : string;
            
            public stringency_index : string;
            
            public population : number;
            
            public population_density : number;
            
            public median_age : number;
            
            public aged_65_older : number;
            
            public aged_70_older : number;
            
            public gdp_per_capita : number;
            
            public extreme_poverty : string;
            
            public cardiovasc_death_rate : number;
            
            public diabetes_prevalence : number;
            
            public female_smokers : string;
            
            public male_smokers : string;
            
            public handwashing_facilities : number;
            
            public hospital_beds_per_thousand : number;
            
            public life_expectancy : number;
                    
    }

