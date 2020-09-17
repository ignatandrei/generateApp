using System;

namespace TestWebAPI_BL
{
    public partial class articles
    {
        #region partial functions
        partial void OnConstructor();
        partial void OnCopyConstructor(articles other, bool withID);
        #endregion

        #region constructors
        public articles (){
            OnConstructor();
        }
        
        public articles(articles other):base(){ 

            OnCopyConstructor(other:other,withID: false);
                
        }
        public void CopyPropertiesFrom(articles other, bool withID){
            if(withID){
                this.id20200916234906= other.id20200916234906;
            }

            this.id = other.id;
                
            this.title = other.title;
                
            this.description = other.description;
                
            this.created_at = other.created_at;
                
            this.updated_at = other.updated_at;
                
            OnCopyConstructor(other,withID);
        }

        #endregion
        
        #region Properties
        public long id20200916234906{get;set;}
            

            public Decimal id { get; set; }
            
            public String title { get; set; }
            
            public String description { get; set; }
            
            public Decimal created_at { get; set; }
            
            public Decimal updated_at { get; set; }
                    #endregion
        
    }
}
