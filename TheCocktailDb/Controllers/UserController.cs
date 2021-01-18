using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheCocktailDb.Models;
using TheCocktailDb.Services;

namespace TheCocktailDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserRepository repository;

        public UserController(IUserRepository repository)
        {
            this.repository = repository;
        }

        [HttpPost]
        public string Create([FromBody]Register register)
        {
            repository.Insert(register);
            return register.Email;
        }

        [HttpGet]
        public List<Register> Get()
        {
            return repository.GetAllUser();
        }
    }
}
