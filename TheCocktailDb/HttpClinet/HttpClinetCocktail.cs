using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TheCocktailDb.Services;

namespace TheCocktailDb.HttpClinet
{
    public class HttpClinetCocktail
    {
        private readonly HttpClient client;

        private const string BaseAddress = "https://www.thecocktaildb.com";
        private IUserRepository repository;

        public HttpClinetCocktail(HttpClient client, IUserRepository repository)
        {
            this.client = client;
            this.client.BaseAddress = new Uri(BaseAddress);
            this.client.DefaultRequestHeaders.Add("Accept","application/json");
            this.repository = repository;
        }


    }
}
