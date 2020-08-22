

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

            this.nume = other.nume;
                
            this.luna = +other.luna;
                
            this.generated_1 = other.generated_1;
                
            this.generated_2 = other.generated_2;
                
            this.generated_3 = other.generated_3;
                
            this.generated_4 = other.generated_4;
                
            this.generated_5 = other.generated_5;
                
            this.generated_6 = other.generated_6;
                
            this.generated_7 = other.generated_7;
                
            this.generated_8 = other.generated_8;
                
            this.generated_9 = other.generated_9;
                
            this.generated_10 = other.generated_10;
                
            this.generated_11 = other.generated_11;
                
            this.generated_12 = other.generated_12;
                
            this.generated_13 = other.generated_13;
                
            this.generated_14 = +other.generated_14;
                
            this.generated_15 = +other.generated_15;
                
            this.generated_16 = other.generated_16;
                
            this.generated_17 = other.generated_17;
                
            this.generated_18 = other.generated_18;
                
            this.generated_19 = other.generated_19;
                
            this.generated_20 = other.generated_20;
                
            this.generated_21 = other.generated_21;
                
            this.generated_22 = +other.generated_22;
                
            this.generated_23 = +other.generated_23;
                
            this.generated_24 = other.generated_24;
                
            this.generated_25 = +other.generated_25;
                
            this.generated_26 = +other.generated_26;
                
            this.generated_27 = other.generated_27;
                
            this.generated_28 = other.generated_28;
                
            this.generated_29 = +other.generated_29;
                
            this.generated_30 = other.generated_30;
                
            this.generated_31 = other.generated_31;
                
            
        }
        public  id: number;
            

            public nume : string;
            
            public luna : number;
            
            public generated_1 : string;
            
            public generated_2 : string;
            
            public generated_3 : string;
            
            public generated_4 : string;
            
            public generated_5 : string;
            
            public generated_6 : string;
            
            public generated_7 : string;
            
            public generated_8 : string;
            
            public generated_9 : string;
            
            public generated_10 : string;
            
            public generated_11 : string;
            
            public generated_12 : string;
            
            public generated_13 : string;
            
            public generated_14 : number;
            
            public generated_15 : number;
            
            public generated_16 : string;
            
            public generated_17 : string;
            
            public generated_18 : string;
            
            public generated_19 : string;
            
            public generated_20 : string;
            
            public generated_21 : string;
            
            public generated_22 : number;
            
            public generated_23 : number;
            
            public generated_24 : string;
            
            public generated_25 : number;
            
            public generated_26 : number;
            
            public generated_27 : string;
            
            public generated_28 : string;
            
            public generated_29 : number;
            
            public generated_30 : string;
            
            public generated_31 : string;
                    
    }

