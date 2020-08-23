

export class MyData
    {
        
        
        public constructor(other:MyData = null){ 

            if(other != null){
				this.CopyPropertiesFrom(other, true);
			}
                
        }
        public CopyPropertiesFrom(other:MyData, withID: boolean):void{
            if(withID){
                this.id= other.id;
            }

            this.nume = other.nume;
                
            this.prenume = other.prenume;
                
            
        }
        public  id: number;
            

            public nume : string;
            
            public prenume : string;
                    
    }

	