

export class OGChecklistv11
    {
        
        
        public constructor(other:OGChecklistv11 = null){ 

            if(other != null){
				this.CopyPropertiesFrom(other, true);
			}
                
        }
        public CopyPropertiesFrom(other:OGChecklistv11, withID: boolean):void{
            if(withID){
                this.id20200914033604= other.id20200914033604;
            }

            this.ref = other.ref;
                
            this.checklistquestion = other.checklistquestion;
                
            this.fcanotes = other.fcanotes;
                
            this.obienotes = other.obienotes;
                
            this.obie = other.obie;
                
            this.psd2 = other.psd2;
                
            this.cmaorder = other.cmaorder;
                
            this.generated_reg.references = other.generated_reg.references;
                
            
        }
        public  id20200914033604: number;
            

            public ref : string;
            
            public checklistquestion : string;
            
            public fcanotes : string;
            
            public obienotes : string;
            
            public obie : string;
            
            public psd2 : string;
            
            public cmaorder : string;
            
            public generated_generated_reg.references : string;
                    
    }

	