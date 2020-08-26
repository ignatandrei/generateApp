

export class csv20200826135839
    {
        
        
        public constructor(other:csv20200826135839 = null){ 

            if(other != null){
				this.CopyPropertiesFrom(other, true);
			}
                
        }
        public CopyPropertiesFrom(other:csv20200826135839, withID: boolean):void{
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

	