using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheCocktailDb.Models;
using TheCocktailDb.Services;

namespace TheCocktailDb.Repositoris
{
    public class UserRepository : IUserRepository
    {
        private static List<Register> Users = new List<Register>();
        private static int CurrentId = 1;

        public List<Register> GetAllUser()
        {
            return Users;
        }

        public Register GetByInfoUser(CheckUser check)
        {
            try
            {
                return Users.FirstOrDefault(x => x.Email == check.email && x.UserName==check.username);
            }
            catch 
            {
                Console.WriteLine($"email vared shode ya user name vared shode rezerv shode ast ");
                throw;
            }
        }

        public void Insert(Register register)
        {
            try
            {
                if (!Users.Any(x=>x.Email==register.Email))
                {
                    if (!Users.Any(x => x.UserName == register.UserName))
                    {
                        register.UserId = CurrentId++;
                        Users.Add(register);
                    }
                }
            }
            catch 
            {
                Console.WriteLine($"in {register.Email} ghblan sabt shode ast");
            }
        }
    }
}
