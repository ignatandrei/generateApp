

export class Employees
    {
        
        
        public constructor(other:Employees = null){ 

            if(other != null){
				this.CopyPropertiesFrom(other, true);
			}
                
        }
        public CopyPropertiesFrom(other:Employees, withID: boolean):void{
            if(withID){
                this.id= other.id;
            }

            this.firstname = other.firstname;
                
            this.lastname = other.lastname;
                
            
        }
        public  id: number;
            

            public firstname : string;
            
            public lastname : string;
                    
    }

	