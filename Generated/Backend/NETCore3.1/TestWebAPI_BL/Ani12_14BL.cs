using System;

namespace TestWebAPI_BL
{
    public partial class Ani12_14
    {
        #region partial functions
        partial void OnConstructor();
        partial void OnCopyConstructor(Ani12_14 other, bool withID);
        #endregion

        #region constructors
        public Ani12_14 (){
            OnConstructor();
        }
        
        public Ani12_14(Ani12_14 other):base(){ 

            OnCopyConstructor(other:other,withID: false);
                
        }
        public void CopyPropertiesFrom(Ani12_14 other, bool withID){
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
