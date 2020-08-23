
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
    public class REST_MyDataController : ControllerBase
    {
        private readonly IRepository<MyData> _repository;

        public REST_MyDataController(IRepository<MyData> repository)
        {
            _repository = repository;
        }

        // GET: api/MyData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MyData>>> GetAll()
        {
            return await _repository.GetAll();
        }

        // GET: api/MyData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MyData>> FindAfterId(long id)
        {
            var record = await _repository.FindAfterId(id);

            if (record == null)
            {
                return NotFound($"cannot find record with id = {id}");
            }

            return record;
        }

        // PUT: api/MyData/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<ActionResult<MyData>> Update(long id, MyData record)
        {
            if (id != record.ID)
            {
                return BadRequest();
            }
            
            await _repository.Update(record);
            
            return record;
        }

        // POST: api/MyData
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<MyData> Post(MyData record)
        {
            await _repository.Insert(record);

            return record;
        }

        // DELETE: api/MyData/5
        [HttpDelete("{id}")]
        public async Task<long> Delete(long id)
        {
            
            await _repository.Delete( new MyData(){
                ID=id
            });


            return id;
        }

       
    }
}
