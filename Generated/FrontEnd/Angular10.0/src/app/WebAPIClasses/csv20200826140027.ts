

export class csv20200826140027
    {
        
        
        public constructor(other:csv20200826140027 = null){ 

            if(other != null){
				this.CopyPropertiesFrom(other, true);
			}
                
        }
        public CopyPropertiesFrom(other:csv20200826140027, withID: boolean):void{
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

	