
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
    public class REST_PropertySheet20032020Controller : ControllerBase
    {
        private readonly IRepository<PropertySheet20032020> _repository;

        public REST_PropertySheet20032020Controller(IRepository<PropertySheet20032020> repository)
        {
            _repository = repository;
        }

        // GET: api/PropertySheet20032020
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PropertySheet20032020>>> GetAll()
        {
            return await _repository.GetAll();
        }

        // GET: api/PropertySheet20032020/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PropertySheet20032020>> FindAfterId(long id)
        {
            var record = await _repository.FindAfterId(id);

            if (record == null)
            {
                return NotFound($"cannot find record with id = {id}");
            }

            return record;
        }

        // PUT: api/PropertySheet20032020/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<ActionResult<PropertySheet20032020>> Update(long id, PropertySheet20032020 record)
        {
            if (id != record.id)
            {
                return BadRequest();
            }
            
            await _repository.Update(record);
            
            return record;
        }

        // POST: api/PropertySheet20032020
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<PropertySheet20032020> Post(PropertySheet20032020 record)
        {
            await _repository.Insert(record);

            return record;
        }

        // DELETE: api/PropertySheet20032020/5
        [HttpDelete("{id}")]
        public async Task<long> Delete(long id)
        {
            
            await _repository.Delete( new PropertySheet20032020(){
                id=id
            });


            return id;
        }

       
    }
}
