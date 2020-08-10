

export class Ani14
    {
        
        
        public constructor(other:Ani14 = null){ 

            if(other != null){
				this.CopyPropertiesFrom(other, true);
			}
                
        }
        public CopyPropertiesFrom(other:Ani14, withID: boolean):void{
            if(withID){
                this.id= other.id;
            }

            this.nume = other.nume;
                
            
        }
        public  id: number;
            

            public nume : string;
                    
    }

