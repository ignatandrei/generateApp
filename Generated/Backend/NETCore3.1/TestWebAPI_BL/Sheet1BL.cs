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

            this.title = other.title;
                
            OnCopyConstructor(other,withID);
        }

        #endregion
        
        #region Properties
        public long ID{get;set;}
            

            public String title { get; set; }
                    #endregion
        
    }
}
