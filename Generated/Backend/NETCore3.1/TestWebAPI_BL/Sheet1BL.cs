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
                this.id= other.id;
            }

            this.customercommercial_customeridout = other.customercommercial_customeridout;
                
            this.customercommercial_pricelistidout = other.customercommercial_pricelistidout;
                
            OnCopyConstructor(other,withID);
        }

        #endregion
        
        #region Properties
        public long id{get;set;}
            

            public Decimal customercommercial_customeridout { get; set; }
            
            public String customercommercial_pricelistidout { get; set; }
                    #endregion
        
    }
}
