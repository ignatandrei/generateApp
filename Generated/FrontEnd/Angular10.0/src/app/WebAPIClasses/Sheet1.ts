

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

            this.firstname = other.firstname;
                
            this.lastname = other.lastname;
                
            
        }
        public  id: number;
            

            public firstname : string;
            
            public lastname : string;
                    
    }

	