
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
    public class REST_Ani8_10Controller : ControllerBase
    {
        private readonly IRepository<Ani8_10> _repository;

        public REST_Ani8_10Controller(IRepository<Ani8_10> repository)
        {
            _repository = repository;
        }

        // GET: api/Ani8_10
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ani8_10>>> GetAll()
        {
            return await _repository.GetAll();
        }

        // GET: api/Ani8_10/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ani8_10>> FindAfterId(long id)
        {
            var record = await _repository.FindAfterId(id);

            if (record == null)
            {
                return NotFound($"cannot find record with id = {id}");
            }

            return record;
        }

        // PUT: api/Ani8_10/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, Ani8_10 record)
        {
            if (id != record.ID)
            {
                return BadRequest();
            }
            
            await _repository.Update(record);
            
            return NoContent();
        }

        // POST: api/Ani8_10
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ani8_10>> Post(Ani8_10 record)
        {
            await _repository.Insert(record);

            return CreatedAtAction("GetAni8_10", new { id = record.ID }, record);
        }

        // DELETE: api/Ani8_10/5
        [HttpDelete("{id}")]
        public async Task<long> Delete(long id)
        {
            
            await _repository.Delete( new Ani8_10(){
                ID=id
            });


            return id;
        }

       
    }
}
