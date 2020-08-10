using System;

namespace TestWebAPI_BL
{
    public partial class Ani8_10
    {
        #region partial functions
        partial void OnConstructor();
        partial void OnCopyConstructor(Ani8_10 other, bool withID);
        #endregion

        #region constructors
        public Ani8_10 (){
            OnConstructor();
        }
        
        public Ani8_10(Ani8_10 other):base(){ 

            OnCopyConstructor(other:other,withID: false);
                
        }
        public void CopyPropertiesFrom(Ani8_10 other, bool withID){
            if(withID){
                this.ID= other.ID;
            }

            this.Nume = other.Nume;
                
            OnCopyConstructor(other,withID);
        }

        #endregion
        
        #region Properties
        public long ID{get;set;}
            

            public String Nume { get; set; }
                    #endregion
        
    }
}
