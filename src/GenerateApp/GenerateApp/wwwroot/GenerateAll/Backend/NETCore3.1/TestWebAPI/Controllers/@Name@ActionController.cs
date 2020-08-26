﻿@model Stankins.Interfaces.IDataToSent
@{

string ClassNameFromTableName(string tableName){
		return tableName.Replace(" ","").Replace(".","").Replace("(","").Replace(")","");
	}
	
    var dt= Model.FindAfterName("@Name@").Value;
    var dtOptions= Model.FindAfterName("@@Options@@").Value;
    var idTable = dtOptions.Rows.Find(dt.TableName +"_PK")[1].ToString();
	
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
        private readonly IRepository<@(nameClass)> _repository;

        public @(nameClass)Controller(IRepository<@(nameClass)> repository)
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
        public async Task<ActionResult<@(nameClass)>> Get(long id)
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
        public async Task<ActionResult<@(nameClass)>> Put(long id, @(nameClass) record)
        {
            if (id != record.@(idTable))
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
        public async Task<long> Delete(long id)
        {
            
            await _repository.Delete( new @(nameClass)(){
                @(idTable)=id
            });


            return id;
        }

       
    }
}
