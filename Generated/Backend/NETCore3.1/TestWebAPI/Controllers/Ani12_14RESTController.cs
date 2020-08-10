
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
    public class REST_Ani12_14Controller : ControllerBase
    {
        private readonly IRepository<Ani12_14> _repository;

        public REST_Ani12_14Controller(IRepository<Ani12_14> repository)
        {
            _repository = repository;
        }

        // GET: api/Ani12_14
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ani12_14>>> GetAll()
        {
            return await _repository.GetAll();
        }

        // GET: api/Ani12_14/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ani12_14>> FindAfterId(long id)
        {
            var record = await _repository.FindAfterId(id);

            if (record == null)
            {
                return NotFound($"cannot find record with id = {id}");
            }

            return record;
        }

        // PUT: api/Ani12_14/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, Ani12_14 record)
        {
            if (id != record.ID)
            {
                return BadRequest();
            }
            
            await _repository.Update(record);
            
            return NoContent();
        }

        // POST: api/Ani12_14
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ani12_14>> Post(Ani12_14 record)
        {
            await _repository.Insert(record);

            return CreatedAtAction("GetAni12_14", new { id = record.ID }, record);
        }

        // DELETE: api/Ani12_14/5
        [HttpDelete("{id}")]
        public async Task<long> Delete(long id)
        {
            
            await _repository.Delete( new Ani12_14(){
                ID=id
            });


            return id;
        }

       
    }
}
