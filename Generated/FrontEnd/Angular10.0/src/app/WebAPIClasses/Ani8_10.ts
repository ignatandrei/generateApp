

export class Ani8_10
    {
        
        
        public constructor(other:Ani8_10 = null){ 

            if(other != null){
				this.CopyPropertiesFrom(other, true);
			}
                
        }
        public CopyPropertiesFrom(other:Ani8_10, withID: boolean):void{
            if(withID){
                this.id= other.id;
            }

            this.nume = other.nume;
                
            
        }
        public  id: number;
            

            public nume : string;
                    
    }

