

export class Ani10_12
    {
        
        
        public constructor(other:Ani10_12 = null){ 

            if(other != null){
				this.CopyPropertiesFrom(other, true);
			}
                
        }
        public CopyPropertiesFrom(other:Ani10_12, withID: boolean):void{
            if(withID){
                this.id= other.id;
            }

            this.nume = other.nume;
                
            
        }
        public  id: number;
            

            public nume : string;
                    
    }

