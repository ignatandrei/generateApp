

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

            this.title = other.title;
                
            
        }
        public  id: number;
            

            public title : string;
                    
    }

