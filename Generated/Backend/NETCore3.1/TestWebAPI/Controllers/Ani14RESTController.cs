
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
    public class REST_Ani14Controller : ControllerBase
    {
        private readonly IRepository<Ani14> _repository;

        public REST_Ani14Controller(IRepository<Ani14> repository)
        {
            _repository = repository;
        }

        // GET: api/Ani14
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ani14>>> GetAll()
        {
            return await _repository.GetAll();
        }

        // GET: api/Ani14/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ani14>> FindAfterId(long id)
        {
            var record = await _repository.FindAfterId(id);

            if (record == null)
            {
                return NotFound($"cannot find record with id = {id}");
            }

            return record;
        }

        // PUT: api/Ani14/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, Ani14 record)
        {
            if (id != record.ID)
            {
                return BadRequest();
            }
            
            await _repository.Update(record);
            
            return NoContent();
        }

        // POST: api/Ani14
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ani14>> Post(Ani14 record)
        {
            await _repository.Insert(record);

            return CreatedAtAction("GetAni14", new { id = record.ID }, record);
        }

        // DELETE: api/Ani14/5
        [HttpDelete("{id}")]
        public async Task<long> Delete(long id)
        {
            
            await _repository.Delete( new Ani14(){
                ID=id
            });


            return id;
        }

       
    }
}
