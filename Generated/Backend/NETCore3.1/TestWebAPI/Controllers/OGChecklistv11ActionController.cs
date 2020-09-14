
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
    public class OGChecklistv11Controller : ControllerBase
    {
        private readonly IRepository<OGChecklistv11,long> _repository;

        public OGChecklistv11Controller(IRepository<OGChecklistv11,long> repository)
        {
            _repository = repository;
        }

        // GET: api/OGChecklistv11
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OGChecklistv11>>> GetAll()
        {
            return await _repository.GetAll();
        }

        // GET: api/OGChecklistv11/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OGChecklistv11>> Get(long id)
        {
            var record = await _repository.FindAfterId(id);

            if (record == null)
            {
                return NotFound($"cannot find record with id = {id}");
            }

            return record;
        }

        // PUT: api/OGChecklistv11/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<ActionResult<OGChecklistv11>> Put(long id, OGChecklistv11 record)
        {
            if (id != record.id20200914033604)
            {
                return BadRequest();
            }
            
             await _repository.Update(record);
            
            return record;
        }

        // POST: api/OGChecklistv11
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<OGChecklistv11> Insert(OGChecklistv11 record)
        {
            await _repository.Insert(record);

            return record;
        }

        // DELETE: api/OGChecklistv11/5
        [HttpDelete("{id}")]
        public async Task<long> Delete(long id)
        {
            
            await _repository.Delete( new OGChecklistv11(){
                id20200914033604=id
            });


            return id;
        }

       
    }
}
