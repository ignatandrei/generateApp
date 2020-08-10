

export class Ani12_14
    {
        
        
        public constructor(other:Ani12_14 = null){ 

            if(other != null){
				this.CopyPropertiesFrom(other, true);
			}
                
        }
        public CopyPropertiesFrom(other:Ani12_14, withID: boolean):void{
            if(withID){
                this.id= other.id;
            }

            this.nume = other.nume;
                
            
        }
        public  id: number;
            

            public nume : string;
                    
    }

