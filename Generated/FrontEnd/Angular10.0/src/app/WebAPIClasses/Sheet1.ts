

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

            this.noticeno = other.noticeno;
                
            this.contractobject = other.contractobject;
                
            this.contractingauthority = other.contractingauthority;
                
            this.supplier = other.supplier;
                
            this.contractvalue = other.contractvalue;
                
            this.currency = other.currency;
                
            this.cpvcode = other.cpvcode;
                
            this.noticetype = other.noticetype;
                
            this.procedurestate = other.procedurestate;
                
            this.awardstate = other.awardstate;
                
            this.county = other.county;
                
            this.communityreference = other.communityreference;
                
            this.publicationdate = other.publicationdate;
                
            
        }
        public  id: number;
            

            public noticeno : string;
            
            public contractobject : string;
            
            public contractingauthority : string;
            
            public supplier : string;
            
            public contractvalue : string;
            
            public currency : string;
            
            public cpvcode : string;
            
            public noticetype : string;
            
            public procedurestate : string;
            
            public awardstate : string;
            
            public county : string;
            
            public communityreference : string;
            
            public publicationdate : string;
                    
    }

	