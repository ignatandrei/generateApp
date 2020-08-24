

export class CollectionProgram_list1
    {
        
        
        public constructor(other:CollectionProgram_list1 = null){ 

            if(other != null){
				this.CopyPropertiesFrom(other, true);
			}
                
        }
        public CopyPropertiesFrom(other:CollectionProgram_list1, withID: boolean):void{
            if(withID){
                this.id= other.id;
            }

            this.rutadenumireruta = other.rutadenumireruta;
                
            this.stare = other.stare;
                
            this.camionnumarinmatriculare = other.camionnumarinmatriculare;
                
            this.recipientetotal = +other.recipientetotal;
                
            this.volumtotal = +other.volumtotal;
                
            this.greutatetotala = +other.greutatetotala;
                
            this.datastart = other.datastart;
                
            this.timedatastart = +other.timedatastart;
                
            this.timedatafinal = +other.timedatafinal;
                
            
        }
        public  id: number;
            

            public rutadenumireruta : string;
            
            public stare : string;
            
            public camionnumarinmatriculare : string;
            
            public recipientetotal : number;
            
            public volumtotal : number;
            
            public greutatetotala : number;
            
            public datastart : string;
            
            public timedatastart : number;
            
            public timedatafinal : number;
                    
    }

	