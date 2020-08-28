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

            this.coloana1 = other.coloana1;
                
            this.coloana2 = other.coloana2;
                
            this.coloana3 = other.coloana3;
                
            this.coloana4 = other.coloana4;
                
            this.coloana5 = other.coloana5;
                
            this.coloana6 = other.coloana6;
                
            this.coloana7 = other.coloana7;
                
            this.coloana8 = other.coloana8;
                
            this.coloana9 = other.coloana9;
                
            this.coloana10 = other.coloana10;
                
            OnCopyConstructor(other,withID);
        }

        #endregion
        
        #region Properties
        public long id{get;set;}
            

            public String coloana1 { get; set; }
            
            public String coloana2 { get; set; }
            
            public String coloana3 { get; set; }
            
            public String coloana4 { get; set; }
            
            public String coloana5 { get; set; }
            
            public String coloana6 { get; set; }
            
            public String coloana7 { get; set; }
            
            public String coloana8 { get; set; }
            
            public String coloana9 { get; set; }
            
            public String coloana10 { get; set; }
                    #endregion
        
    }
}
