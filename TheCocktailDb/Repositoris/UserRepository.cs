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

        public Register GetByInfoUser(string username)
        {
            try
            {
                return Users.FirstOrDefault(x=> x.UserName==username);
            }
            catch 
            {
                Console.WriteLine($"hamchin user name vojo nadarad");
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
