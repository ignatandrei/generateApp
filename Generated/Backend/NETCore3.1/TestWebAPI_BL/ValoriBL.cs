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
                this.id20200914041510= other.id20200914041510;
            }

            this.moneda = other.moneda;
                
            this.curs = other.curs;
                
            OnCopyConstructor(other,withID);
        }

        #endregion
        
        #region Properties
        public long id20200914041510{get;set;}
            

            public String moneda { get; set; }
            
            public Decimal curs { get; set; }
                    #endregion
        
    }
}
