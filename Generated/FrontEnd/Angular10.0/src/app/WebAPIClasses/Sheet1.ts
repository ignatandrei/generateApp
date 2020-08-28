

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

            this.coloana1 = other.coloana1;
                
            this.coloana2 = other.coloana2;
                
            this.coloana3 = other.coloana3;
                
            this.coloana4 = other.coloana4;
                
            this.coloana5 = other.coloana5;
                
            this.coloana6 = other.coloana6;
                
            this.coloana7 = other.coloana7;
                
            this.coloana8 = other.coloana8;
                
            this.coloana9 = other.coloana9;
                
            this.coloana10 = other.coloana10;
                
            
        }
        public  id: number;
            

            public coloana1 : string;
            
            public coloana2 : string;
            
            public coloana3 : string;
            
            public coloana4 : string;
            
            public coloana5 : string;
            
            public coloana6 : string;
            
            public coloana7 : string;
            
            public coloana8 : string;
            
            public coloana9 : string;
            
            public coloana10 : string;
                    
    }

	