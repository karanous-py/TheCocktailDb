using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheCocktailDb.Models;

namespace TheCocktailDb.Services
{
    public interface IUserRepository
    {
         void Insert(Register register);

         Register GetByInfoUser(string username);

         List<Register> GetAllUser();
    }
}
