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
                this.id20200909002008= other.id20200909002008;
            }

            this.noticeno = other.noticeno;
                
            this.contractobject = other.contractobject;
                
            this.contractingauthority = other.contractingauthority;
                
            this.supplier = other.supplier;
                
            this.contractvalue = other.contractvalue;
                
            this.currency = other.currency;
                
            this.cpvcode = other.cpvcode;
                
            this.noticetype = other.noticetype;
                
            this.procedurestate = other.procedurestate;
                
            this.awardstate = other.awardstate;
                
            this.county = other.county;
                
            this.communityreference = other.communityreference;
                
            this.publicationdate = other.publicationdate;
                
            OnCopyConstructor(other,withID);
        }

        #endregion
        
        #region Properties
        public long id20200909002008{get;set;}
            

            public String noticeno { get; set; }
            
            public String contractobject { get; set; }
            
            public String contractingauthority { get; set; }
            
            public String supplier { get; set; }
            
            public String contractvalue { get; set; }
            
            public String currency { get; set; }
            
            public String cpvcode { get; set; }
            
            public String noticetype { get; set; }
            
            public String procedurestate { get; set; }
            
            public String awardstate { get; set; }
            
            public String county { get; set; }
            
            public String communityreference { get; set; }
            
            public String publicationdate { get; set; }
                    #endregion
        
    }
}
