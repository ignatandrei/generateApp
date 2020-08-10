using System;

namespace TestWebAPI_BL
{
    public partial class Ani10_12
    {
        #region partial functions
        partial void OnConstructor();
        partial void OnCopyConstructor(Ani10_12 other, bool withID);
        #endregion

        #region constructors
        public Ani10_12 (){
            OnConstructor();
        }
        
        public Ani10_12(Ani10_12 other):base(){ 

            OnCopyConstructor(other:other,withID: false);
                
        }
        public void CopyPropertiesFrom(Ani10_12 other, bool withID){
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
