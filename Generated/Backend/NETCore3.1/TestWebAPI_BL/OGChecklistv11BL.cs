using System;

namespace TestWebAPI_BL
{
    public partial class OGChecklistv11
    {
        #region partial functions
        partial void OnConstructor();
        partial void OnCopyConstructor(OGChecklistv11 other, bool withID);
        #endregion

        #region constructors
        public OGChecklistv11 (){
            OnConstructor();
        }
        
        public OGChecklistv11(OGChecklistv11 other):base(){ 

            OnCopyConstructor(other:other,withID: false);
                
        }
        public void CopyPropertiesFrom(OGChecklistv11 other, bool withID){
            if(withID){
                this.id20200914033604= other.id20200914033604;
            }

            this.ref = other.ref;
                
            this.checklistquestion = other.checklistquestion;
                
            this.fcanotes = other.fcanotes;
                
            this.obienotes = other.obienotes;
                
            this.obie = other.obie;
                
            this.psd2 = other.psd2;
                
            this.cmaorder = other.cmaorder;
                
            this.generated_reg.references = other.generated_reg.references;
                
            OnCopyConstructor(other,withID);
        }

        #endregion
        
        #region Properties
        public long id20200914033604{get;set;}
            

            public String ref { get; set; }
            
            public String checklistquestion { get; set; }
            
            public String fcanotes { get; set; }
            
            public String obienotes { get; set; }
            
            public String obie { get; set; }
            
            public String psd2 { get; set; }
            
            public String cmaorder { get; set; }
            
            public String generated_reg.references { get; set; }
                    #endregion
        
    }
}
