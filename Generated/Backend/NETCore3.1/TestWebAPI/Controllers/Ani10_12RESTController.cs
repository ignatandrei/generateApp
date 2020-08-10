
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
    public class REST_Ani10_12Controller : ControllerBase
    {
        private readonly IRepository<Ani10_12> _repository;

        public REST_Ani10_12Controller(IRepository<Ani10_12> repository)
        {
            _repository = repository;
        }

        // GET: api/Ani10_12
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ani10_12>>> GetAll()
        {
            return await _repository.GetAll();
        }

        // GET: api/Ani10_12/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ani10_12>> FindAfterId(long id)
        {
            var record = await _repository.FindAfterId(id);

            if (record == null)
            {
                return NotFound($"cannot find record with id = {id}");
            }

            return record;
        }

        // PUT: api/Ani10_12/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, Ani10_12 record)
        {
            if (id != record.ID)
            {
                return BadRequest();
            }
            
            await _repository.Update(record);
            
            return NoContent();
        }

        // POST: api/Ani10_12
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ani10_12>> Post(Ani10_12 record)
        {
            await _repository.Insert(record);

            return CreatedAtAction("GetAni10_12", new { id = record.ID }, record);
        }

        // DELETE: api/Ani10_12/5
        [HttpDelete("{id}")]
        public async Task<long> Delete(long id)
        {
            
            await _repository.Delete( new Ani10_12(){
                ID=id
            });


            return id;
        }

       
    }
}
