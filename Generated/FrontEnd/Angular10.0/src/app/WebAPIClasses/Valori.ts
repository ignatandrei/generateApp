

export class Valori
    {
        
        
        public constructor(other:Valori = null){ 

            if(other != null){
				this.CopyPropertiesFrom(other, true);
			}
                
        }
        public CopyPropertiesFrom(other:Valori, withID: boolean):void{
            if(withID){
                this.id20200914041510= other.id20200914041510;
            }

            this.moneda = other.moneda;
                
            this.curs = +other.curs;
                
            
        }
        public  id20200914041510: number;
            

            public moneda : string;
            
            public curs : number;
                    
    }

	