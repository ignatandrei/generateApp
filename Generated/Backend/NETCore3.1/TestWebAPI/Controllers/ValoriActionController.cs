
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
    public class ValoriController : ControllerBase
    {
        private readonly IRepository<Valori> _repository;

        public ValoriController(IRepository<Valori> repository)
        {
            _repository = repository;
        }

        // GET: api/Valori
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Valori>>> GetAll()
        {
            return await _repository.GetAll();
        }

        // GET: api/Valori/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Valori>> Get(long id)
        {
            var record = await _repository.FindAfterId(id);

            if (record == null)
            {
                return NotFound($"cannot find record with id = {id}");
            }

            return record;
        }

        // PUT: api/Valori/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<ActionResult<Valori>> Put(long id, Valori record)
        {
            if (id != record.ID)
            {
                return BadRequest();
            }
            
             await _repository.Update(record);
            
            return record;
        }

        // POST: api/Valori
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<Valori> Insert(Valori record)
        {
            await _repository.Insert(record);

            return record;
        }

        // DELETE: api/Valori/5
        [HttpDelete("{id}")]
        public async Task<long> Delete(long id)
        {
            
            await _repository.Delete( new Valori(){
                ID=id
            });


            return id;
        }

       
    }
}
