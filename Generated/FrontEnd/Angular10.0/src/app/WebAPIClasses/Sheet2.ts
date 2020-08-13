

export class Sheet2
    {
        
        
        public constructor(other:Sheet2 = null){ 

            if(other != null){
				this.CopyPropertiesFrom(other, true);
			}
                
        }
        public CopyPropertiesFrom(other:Sheet2, withID: boolean):void{
            if(withID){
                this.id= other.id;
            }

            this.ddd = other.ddd;
                
            this.adsasd = other.adsasd;
                
            
        }
        public  id: number;
            

            public ddd : string;
            
            public adsasd : string;
                    
    }

