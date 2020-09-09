
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
    [Route("api/[controller]")]
    [ApiController]
    public class REST_Sheet1Controller : ControllerBase
    {
        private readonly IRepository<Sheet1,long> _repository;

        public REST_Sheet1Controller(IRepository<Sheet1,long> repository)
        {
            _repository = repository;
        }

        // GET: api/Sheet1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sheet1>>> GetAll()
        {
            return await _repository.GetAll();
        }

        // GET: api/Sheet1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sheet1>> FindAfterId(long id)
        {
            var record = await _repository.FindAfterId(id);

            if (record == null)
            {
                return NotFound($"cannot find record with id = {id}");
            }

            return record;
        }

        // PUT: api/Sheet1/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<ActionResult<Sheet1>> Update(long id, Sheet1 record)
        {
            if (id != record.id20200909002008)
            {
                return BadRequest();
            }
            
            await _repository.Update(record);
            
            return record;
        }

        // POST: api/Sheet1
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<Sheet1> Post(Sheet1 record)
        {
            await _repository.Insert(record);

            return record;
        }

        // DELETE: api/Sheet1/5
        [HttpDelete("{id}")]
        public async Task<long> Delete(long id)
        {
            
            await _repository.Delete( new Sheet1(){
                id20200909002008=id
            });


            return id;
        }

       
    }
}
