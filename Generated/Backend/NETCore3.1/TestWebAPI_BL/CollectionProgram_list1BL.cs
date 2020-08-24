using System;

namespace TestWebAPI_BL
{
    public partial class CollectionProgram_list1
    {
        #region partial functions
        partial void OnConstructor();
        partial void OnCopyConstructor(CollectionProgram_list1 other, bool withID);
        #endregion

        #region constructors
        public CollectionProgram_list1 (){
            OnConstructor();
        }
        
        public CollectionProgram_list1(CollectionProgram_list1 other):base(){ 

            OnCopyConstructor(other:other,withID: false);
                
        }
        public void CopyPropertiesFrom(CollectionProgram_list1 other, bool withID){
            if(withID){
                this.ID= other.ID;
            }

            this.rutadenumireruta = other.rutadenumireruta;
                
            this.stare = other.stare;
                
            this.camionnumarinmatriculare = other.camionnumarinmatriculare;
                
            this.recipientetotal = other.recipientetotal;
                
            this.volumtotal = other.volumtotal;
                
            this.greutatetotala = other.greutatetotala;
                
            this.datastart = other.datastart;
                
            this.timedatastart = other.timedatastart;
                
            this.timedatafinal = other.timedatafinal;
                
            OnCopyConstructor(other,withID);
        }

        #endregion
        
        #region Properties
        public long ID{get;set;}
            

            public String rutadenumireruta { get; set; }
            
            public String stare { get; set; }
            
            public String camionnumarinmatriculare { get; set; }
            
            public Decimal recipientetotal { get; set; }
            
            public Decimal volumtotal { get; set; }
            
            public Decimal greutatetotala { get; set; }
            
            public String datastart { get; set; }
            
            public Decimal timedatastart { get; set; }
            
            public Decimal timedatafinal { get; set; }
                    #endregion
        
    }
}
