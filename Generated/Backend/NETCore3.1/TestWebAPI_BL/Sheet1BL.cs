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

            this.id = other.id;
                
            this.firstname = other.firstname;
                
            this.lastname = other.lastname;
                
            OnCopyConstructor(other,withID);
        }

        #endregion
        
        #region Properties
        public long id{get;set;}
            

            public Decimal id { get; set; }
            
            public String firstname { get; set; }
            
            public String lastname { get; set; }
                    #endregion
        
    }
}
