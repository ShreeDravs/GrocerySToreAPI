using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using GroceryStoreAPI.Models;
using GroceryStoreAPI.Data;

namespace GroceryStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
       

        private readonly CustomersRepository _repository;

        public CustomerController(CustomersRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> Get()
        {
            if (!ModelState.IsValid)
            {
               return BadRequest(ModelState);
            }
            else
            {
                return await _repository.GetAllAsync();
            }
        }

       

        // POST api/values
        [HttpPost]
        public async Task Post([FromBody] Customer value)
        {
            if (!ModelState.IsValid)
            {
                BadRequest(ModelState);
            }
            else
            {
                await _repository.Insert(value);
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Customer value)
        {
            await _repository.Update(value,id);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _repository.DeleteById(id);
        }

     
        
    }
}
