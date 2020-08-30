using System;

namespace TestWebAPI_BL
{
    public partial class Employees
    {
        #region partial functions
        partial void OnConstructor();
        partial void OnCopyConstructor(Employees other, bool withID);
        #endregion

        #region constructors
        public Employees (){
            OnConstructor();
        }
        
        public Employees(Employees other):base(){ 

            OnCopyConstructor(other:other,withID: false);
                
        }
        public void CopyPropertiesFrom(Employees other, bool withID){
            if(withID){
                this.id= other.id;
            }

            this.firstname = other.firstname;
                
            this.lastname = other.lastname;
                
            OnCopyConstructor(other,withID);
        }

        #endregion
        
        #region Properties
        public long id{get;set;}
            

            public String firstname { get; set; }
            
            public String lastname { get; set; }
                    #endregion
        
    }
}
