using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazzorDbzPersonagem.Models;

namespace BlazzorDbzPersonagem.Services
{
    public class DbzService
    {
        private readonly HttpClient _http;

        public DbzService(HttpClient http)
        {
            _http = http;
        }

        public async Task<Character?> GetCharacterAsync(int id)
        {
            try
            {
                var url = $"https://dragonball-api.com/api/characters/{id}";
                return await _http.GetFromJsonAsync<Character>(url);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
