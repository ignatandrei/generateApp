
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
    public class REST_csv20200826140027Controller : ControllerBase
    {
        private readonly IRepository<csv20200826140027> _repository;

        public REST_csv20200826140027Controller(IRepository<csv20200826140027> repository)
        {
            _repository = repository;
        }

        // GET: api/csv20200826140027
        [HttpGet]
        public async Task<ActionResult<IEnumerable<csv20200826140027>>> GetAll()
        {
            return await _repository.GetAll();
        }

        // GET: api/csv20200826140027/5
        [HttpGet("{id}")]
        public async Task<ActionResult<csv20200826140027>> FindAfterId(long id)
        {
            var record = await _repository.FindAfterId(id);

            if (record == null)
            {
                return NotFound($"cannot find record with id = {id}");
            }

            return record;
        }

        // PUT: api/csv20200826140027/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<ActionResult<csv20200826140027>> Update(long id, csv20200826140027 record)
        {
            if (id != record.ID)
            {
                return BadRequest();
            }
            
            await _repository.Update(record);
            
            return record;
        }

        // POST: api/csv20200826140027
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<csv20200826140027> Post(csv20200826140027 record)
        {
            await _repository.Insert(record);

            return record;
        }

        // DELETE: api/csv20200826140027/5
        [HttpDelete("{id}")]
        public async Task<long> Delete(long id)
        {
            
            await _repository.Delete( new csv20200826140027(){
                ID=id
            });


            return id;
        }

       
    }
}
