using System;

namespace TestWebAPI_BL
{
    public partial class Sheet1
    {
        #region partial functions
        partial void OnConstructor();
        partial void OnCopyConstructor(Sheet1 other, bool withID);
        #endregion

        #region constructors
        public Sheet1 (){
            OnConstructor();
        }
        
        public Sheet1(Sheet1 other):base(){ 

            OnCopyConstructor(other:other,withID: false);
                
        }
        public void CopyPropertiesFrom(Sheet1 other, bool withID){
            if(withID){
                this.ID= other.ID;
            }

            this.nume = other.nume;
                
            this.luna = other.luna;
                
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
                
            this.generated_14 = other.generated_14;
                
            this.generated_15 = other.generated_15;
                
            this.generated_16 = other.generated_16;
                
            this.generated_17 = other.generated_17;
                
            this.generated_18 = other.generated_18;
                
            this.generated_19 = other.generated_19;
                
            this.generated_20 = other.generated_20;
                
            this.generated_21 = other.generated_21;
                
            this.generated_22 = other.generated_22;
                
            this.generated_23 = other.generated_23;
                
            this.generated_24 = other.generated_24;
                
            this.generated_25 = other.generated_25;
                
            this.generated_26 = other.generated_26;
                
            this.generated_27 = other.generated_27;
                
            this.generated_28 = other.generated_28;
                
            this.generated_29 = other.generated_29;
                
            this.generated_30 = other.generated_30;
                
            this.generated_31 = other.generated_31;
                
            OnCopyConstructor(other,withID);
        }

        #endregion
        
        #region Properties
        public long ID{get;set;}
            

            public String nume { get; set; }
            
            public Decimal luna { get; set; }
            
            public String generated_1 { get; set; }
            
            public String generated_2 { get; set; }
            
            public String generated_3 { get; set; }
            
            public String generated_4 { get; set; }
            
            public String generated_5 { get; set; }
            
            public String generated_6 { get; set; }
            
            public String generated_7 { get; set; }
            
            public String generated_8 { get; set; }
            
            public String generated_9 { get; set; }
            
            public String generated_10 { get; set; }
            
            public String generated_11 { get; set; }
            
            public String generated_12 { get; set; }
            
            public String generated_13 { get; set; }
            
            public Decimal generated_14 { get; set; }
            
            public Decimal generated_15 { get; set; }
            
            public String generated_16 { get; set; }
            
            public String generated_17 { get; set; }
            
            public String generated_18 { get; set; }
            
            public String generated_19 { get; set; }
            
            public String generated_20 { get; set; }
            
            public String generated_21 { get; set; }
            
            public Decimal generated_22 { get; set; }
            
            public Decimal generated_23 { get; set; }
            
            public String generated_24 { get; set; }
            
            public Decimal generated_25 { get; set; }
            
            public Decimal generated_26 { get; set; }
            
            public String generated_27 { get; set; }
            
            public String generated_28 { get; set; }
            
            public Decimal generated_29 { get; set; }
            
            public String generated_30 { get; set; }
            
            public String generated_31 { get; set; }
                    #endregion
        
    }
}
