@model Stankins.Interfaces.IDataToSent
@{

string ClassNameFromTableName(string tableName){
		return tableName.Replace(" ","").Replace(".","").Replace("(","").Replace(")","");
	}
	string nameProperty(string original){
		var name = original.Replace(" ","").Replace("<","").Replace(">","").Replace("(","").Replace(")","").ToLower();
		if(!IsIdentifier(name))
			name = "generated_"+name;
		
		return name;
	}
	//https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.csharp.syntaxfacts?view=roslyn-dotnet
	bool IsIdentifier(string text)
	{
     if (string.IsNullOrEmpty(text))
        return false;
     if (!char.IsLetter(text[0]) && text[0] != '_')
        return false;
     for (int ix = 1; ix < text.Length; ++ix)
        if (!char.IsLetterOrDigit(text[ix]) && text[ix] != '_')
           return false;
     return true;
	}
    var dt= Model.FindAfterName("@Name@").Value;
    var dtOptions= Model.FindAfterName("@@Options@@").Value;
    var idTable = dtOptions.Rows.Find(dt.TableName +"_PK")[1].ToString();
    var idType = dtOptions.Rows.Find(dt.TableName +"_PK_Type")[1].ToString();  	
	string nameClass= ClassNameFromTableName(dt.TableName);
    
    string repo= nameClass  + "_Repository";

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestWEBAPI_DAL;
using TestWebAPI_BL;


namespace TestWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class @(nameClass)Controller : ControllerBase
    {
        private readonly IRepository<@(nameClass),@(idType)> _repository;

        public @(nameClass)Controller(IRepository<@(nameClass),@(idType)> repository)
        {
            _repository = repository;
        }

        // GET: api/@(nameClass)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<@(nameClass)>>> GetAll()
        {
            return await _repository.GetAll();
        }

        // GET: api/@(nameClass)/5
        [HttpGet("{id}")]
        public async Task<ActionResult<@(nameClass)>> Get(@(idType) id)
        {
            var record = await _repository.FindAfterId(id);

            if (record == null)
            {
                return NotFound($"cannot find record with id = {id}");
            }

            return record;
        }

        // PUT: api/@(nameClass)/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<ActionResult<@(nameClass)>> Put(@(idType) id, @(nameClass) record)
        {
            if (id != record.@(nameProperty(idTable)))
            {
                return BadRequest();
            }
            
             await _repository.Update(record);
            
            return record;
        }

        // POST: api/@(nameClass)
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<@(nameClass)> Insert(@(nameClass) record)
        {
            await _repository.Insert(record);

            return record;
        }

        // DELETE: api/@(nameClass)/5
        [HttpDelete("{id}")]
        public async Task<@(idType)> Delete(@(idType) id)
        {
            
            await _repository.Delete( new @(nameClass)(){
                @(nameProperty(idTable))=id
            });


            return id;
        }

       
    }
}
