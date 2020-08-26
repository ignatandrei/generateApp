using System;

namespace TestWebAPI_BL
{
    public partial class PropertySheet20032020
    {
        #region partial functions
        partial void OnConstructor();
        partial void OnCopyConstructor(PropertySheet20032020 other, bool withID);
        #endregion

        #region constructors
        public PropertySheet20032020 (){
            OnConstructor();
        }
        
        public PropertySheet20032020(PropertySheet20032020 other):base(){ 

            OnCopyConstructor(other:other,withID: false);
                
        }
        public void CopyPropertiesFrom(PropertySheet20032020 other, bool withID){
            if(withID){
                this.id= other.id;
            }

            this.address = other.address;
                
            this.column1 = other.column1;
                
            this.date = other.date;
                
            this.worktobeundertaken = other.worktobeundertaken;
                
            this.column2 = other.column2;
                
            this.column3 = other.column3;
                
            this.column4 = other.column4;
                
            OnCopyConstructor(other,withID);
        }

        #endregion
        
        #region Properties
        public long id{get;set;}
            

            public String address { get; set; }
            
            public String column1 { get; set; }
            
            public String date { get; set; }
            
            public String worktobeundertaken { get; set; }
            
            public String column2 { get; set; }
            
            public String column3 { get; set; }
            
            public String column4 { get; set; }
                    #endregion
        
    }
}
