

export class PropertySheet20032020
    {
        
        
        public constructor(other:PropertySheet20032020 = null){ 

            if(other != null){
				this.CopyPropertiesFrom(other, true);
			}
                
        }
        public CopyPropertiesFrom(other:PropertySheet20032020, withID: boolean):void{
            if(withID){
                this.id= other.id;
            }

            this.address = other.address;
                
            this.column1 = other.column1;
                
            this.date = other.date;
                
            this.worktobeundertaken = other.worktobeundertaken;
                
            this.column2 = other.column2;
                
            this.column3 = other.column3;
                
            this.column4 = other.column4;
                
            
        }
        public  id: number;
            

            public address : string;
            
            public column1 : string;
            
            public date : string;
            
            public worktobeundertaken : string;
            
            public column2 : string;
            
            public column3 : string;
            
            public column4 : string;
                    
    }

	