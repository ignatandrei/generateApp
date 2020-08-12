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

            this.Brand = other.Brand;
                
            this.Beneficiar = other.Beneficiar;
                
            this.Departament = other.Departament;
                
            this.SerieSim = other.SerieSim;
                
            this.NumarTelefon = other.NumarTelefon;
                
            this.Firma = other.Firma;
                
            OnCopyConstructor(other,withID);
        }

        #endregion
        
        #region Properties
        public long ID{get;set;}
            

            public String Brand { get; set; }
            
            public String Beneficiar { get; set; }
            
            public String Departament { get; set; }
            
            public String SerieSim { get; set; }
            
            public String NumarTelefon { get; set; }
            
            public String Firma { get; set; }
                    #endregion
        
    }
}
