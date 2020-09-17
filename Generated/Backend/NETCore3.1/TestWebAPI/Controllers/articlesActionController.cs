
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
    public class articlesController : ControllerBase
    {
        private readonly IRepository<articles,long> _repository;

        public articlesController(IRepository<articles,long> repository)
        {
            _repository = repository;
        }

        // GET: api/articles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<articles>>> GetAll()
        {
            return await _repository.GetAll();
        }

        // GET: api/articles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<articles>> Get(long id)
        {
            var record = await _repository.FindAfterId(id);

            if (record == null)
            {
                return NotFound($"cannot find record with id = {id}");
            }

            return record;
        }

        // PUT: api/articles/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<ActionResult<articles>> Put(long id, articles record)
        {
            if (id != record.id20200916234906)
            {
                return BadRequest();
            }
            
             await _repository.Update(record);
            
            return record;
        }

        // POST: api/articles
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<articles> Insert(articles record)
        {
            await _repository.Insert(record);

            return record;
        }

        // DELETE: api/articles/5
        [HttpDelete("{id}")]
        public async Task<long> Delete(long id)
        {
            
            await _repository.Delete( new articles(){
                id20200916234906=id
            });


            return id;
        }

       
    }
}
