
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
    public class REST_CollectionProgram_list1Controller : ControllerBase
    {
        private readonly IRepository<CollectionProgram_list1> _repository;

        public REST_CollectionProgram_list1Controller(IRepository<CollectionProgram_list1> repository)
        {
            _repository = repository;
        }

        // GET: api/CollectionProgram_list1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CollectionProgram_list1>>> GetAll()
        {
            return await _repository.GetAll();
        }

        // GET: api/CollectionProgram_list1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CollectionProgram_list1>> FindAfterId(long id)
        {
            var record = await _repository.FindAfterId(id);

            if (record == null)
            {
                return NotFound($"cannot find record with id = {id}");
            }

            return record;
        }

        // PUT: api/CollectionProgram_list1/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<ActionResult<CollectionProgram_list1>> Update(long id, CollectionProgram_list1 record)
        {
            if (id != record.ID)
            {
                return BadRequest();
            }
            
            await _repository.Update(record);
            
            return record;
        }

        // POST: api/CollectionProgram_list1
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<CollectionProgram_list1> Post(CollectionProgram_list1 record)
        {
            await _repository.Insert(record);

            return record;
        }

        // DELETE: api/CollectionProgram_list1/5
        [HttpDelete("{id}")]
        public async Task<long> Delete(long id)
        {
            
            await _repository.Delete( new CollectionProgram_list1(){
                ID=id
            });


            return id;
        }

       
    }
}
