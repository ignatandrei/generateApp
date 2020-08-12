

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

            this.brand = other.brand;
                
            this.beneficiar = other.beneficiar;
                
            this.departament = other.departament;
                
            this.serieSim = other.serieSim;
                
            this.numarTelefon = other.numarTelefon;
                
            this.firma = other.firma;
                
            
        }
        public  id: number;
            

            public brand : string;
            
            public beneficiar : string;
            
            public departament : string;
            
            public serieSim : string;
            
            public numarTelefon : string;
            
            public firma : string;
                    
    }

