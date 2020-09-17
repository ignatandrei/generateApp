

export class articles
    {
        
        
        public constructor(other:articles = null){ 

            if(other != null){
				this.CopyPropertiesFrom(other, true);
			}
                
        }
        public CopyPropertiesFrom(other:articles, withID: boolean):void{
            if(withID){
                this.id20200916234906= other.id20200916234906;
            }

            this.id = +other.id;
                
            this.title = other.title;
                
            this.description = other.description;
                
            this.created_at = +other.created_at;
                
            this.updated_at = +other.updated_at;
                
            
        }
        public  id20200916234906: number;
            

            public id : number;
            
            public title : string;
            
            public description : string;
            
            public created_at : number;
            
            public updated_at : number;
                    
    }

	