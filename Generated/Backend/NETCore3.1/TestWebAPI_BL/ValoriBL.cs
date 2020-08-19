using System;

namespace TestWebAPI_BL
{
    public partial class Valori
    {
        #region partial functions
        partial void OnConstructor();
        partial void OnCopyConstructor(Valori other, bool withID);
        #endregion

        #region constructors
        public Valori (){
            OnConstructor();
        }
        
        public Valori(Valori other):base(){ 

            OnCopyConstructor(other:other,withID: false);
                
        }
        public void CopyPropertiesFrom(Valori other, bool withID){
            if(withID){
                this.ID= other.ID;
            }

            this.moneda = other.moneda;
                
            this.cursbnr = other.cursbnr;
                
            OnCopyConstructor(other,withID);
        }

        #endregion
        
        #region Properties
        public long ID{get;set;}
            

            public String moneda { get; set; }
            
            public Decimal cursbnr { get; set; }
                    #endregion
        
    }
}
