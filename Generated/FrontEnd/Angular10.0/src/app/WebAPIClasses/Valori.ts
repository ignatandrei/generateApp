

export class Valori
    {
        
        
        public constructor(other:Valori = null){ 

            if(other != null){
				this.CopyPropertiesFrom(other, true);
			}
                
        }
        public CopyPropertiesFrom(other:Valori, withID: boolean):void{
            if(withID){
                this.id= other.id;
            }

            this.moneda = other.moneda;
                
            this.cursbnr = +other.cursbnr;
                
            
        }
        public  id: number;
            

            public moneda : string;
            
            public cursbnr : number;
                    
    }

