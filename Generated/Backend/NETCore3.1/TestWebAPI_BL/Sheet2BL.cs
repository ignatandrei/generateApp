using System;

namespace TestWebAPI_BL
{
    public partial class Sheet2
    {
        #region partial functions
        partial void OnConstructor();
        partial void OnCopyConstructor(Sheet2 other, bool withID);
        #endregion

        #region constructors
        public Sheet2 (){
            OnConstructor();
        }
        
        public Sheet2(Sheet2 other):base(){ 

            OnCopyConstructor(other:other,withID: false);
                
        }
        public void CopyPropertiesFrom(Sheet2 other, bool withID){
            if(withID){
                this.ID= other.ID;
            }

            this.ddd = other.ddd;
                
            this.adsasd = other.adsasd;
                
            OnCopyConstructor(other,withID);
        }

        #endregion
        
        #region Properties
        public long ID{get;set;}
            

            public String ddd { get; set; }
            
            public String adsasd { get; set; }
                    #endregion
        
    }
}
