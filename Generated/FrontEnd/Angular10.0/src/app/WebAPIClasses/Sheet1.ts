

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

            this.customercommercial_customeridout = +other.customercommercial_customeridout;
                
            this.customercommercial_pricelistidout = other.customercommercial_pricelistidout;
                
            
        }
        public  id: number;
            

            public customercommercial_customeridout : number;
            
            public customercommercial_pricelistidout : string;
                    
    }

	