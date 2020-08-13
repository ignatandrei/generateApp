
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
    public class REST_Sheet2Controller : ControllerBase
    {
        private readonly IRepository<Sheet2> _repository;

        public REST_Sheet2Controller(IRepository<Sheet2> repository)
        {
            _repository = repository;
        }

        // GET: api/Sheet2
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sheet2>>> GetAll()
        {
            return await _repository.GetAll();
        }

        // GET: api/Sheet2/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sheet2>> FindAfterId(long id)
        {
            var record = await _repository.FindAfterId(id);

            if (record == null)
            {
                return NotFound($"cannot find record with id = {id}");
            }

            return record;
        }

        // PUT: api/Sheet2/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, Sheet2 record)
        {
            if (id != record.ID)
            {
                return BadRequest();
            }
            
            await _repository.Update(record);
            
            return NoContent();
        }

        // POST: api/Sheet2
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Sheet2>> Post(Sheet2 record)
        {
            await _repository.Insert(record);

            return CreatedAtAction("GetSheet2", new { id = record.ID }, record);
        }

        // DELETE: api/Sheet2/5
        [HttpDelete("{id}")]
        public async Task<long> Delete(long id)
        {
            
            await _repository.Delete( new Sheet2(){
                ID=id
            });


            return id;
        }

       
    }
}
