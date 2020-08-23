using System;

namespace TestWebAPI_BL
{
    public partial class MyData
    {
        #region partial functions
        partial void OnConstructor();
        partial void OnCopyConstructor(MyData other, bool withID);
        #endregion

        #region constructors
        public MyData (){
            OnConstructor();
        }
        
        public MyData(MyData other):base(){ 

            OnCopyConstructor(other:other,withID: false);
                
        }
        public void CopyPropertiesFrom(MyData other, bool withID){
            if(withID){
                this.ID= other.ID;
            }

            this.nume = other.nume;
                
            this.prenume = other.prenume;
                
            OnCopyConstructor(other,withID);
        }

        #endregion
        
        #region Properties
        public long ID{get;set;}
            

            public String nume { get; set; }
            
            public String prenume { get; set; }
                    #endregion
        
    }
}
