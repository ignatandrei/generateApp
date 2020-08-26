using System;

namespace TestWebAPI_BL
{
    public partial class csv20200826135839
    {
        #region partial functions
        partial void OnConstructor();
        partial void OnCopyConstructor(csv20200826135839 other, bool withID);
        #endregion

        #region constructors
        public csv20200826135839 (){
            OnConstructor();
        }
        
        public csv20200826135839(csv20200826135839 other):base(){ 

            OnCopyConstructor(other:other,withID: false);
                
        }
        public void CopyPropertiesFrom(csv20200826135839 other, bool withID){
            if(withID){
                this.ID= other.ID;
            }

            this.firstname = other.firstname;
                
            this.lastname = other.lastname;
                
            OnCopyConstructor(other,withID);
        }

        #endregion
        
        #region Properties
        public long ID{get;set;}
            

            public String firstname { get; set; }
            
            public String lastname { get; set; }
                    #endregion
        
    }
}
