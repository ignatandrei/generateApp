using System;

namespace TestWebAPI_BL
{
    public partial class Ani14
    {
        #region partial functions
        partial void OnConstructor();
        partial void OnCopyConstructor(Ani14 other, bool withID);
        #endregion

        #region constructors
        public Ani14 (){
            OnConstructor();
        }
        
        public Ani14(Ani14 other):base(){ 

            OnCopyConstructor(other:other,withID: false);
                
        }
        public void CopyPropertiesFrom(Ani14 other, bool withID){
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
