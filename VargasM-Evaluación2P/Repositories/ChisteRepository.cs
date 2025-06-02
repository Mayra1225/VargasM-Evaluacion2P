using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace VargasM_Evaluación2P.Repositories
{
    public class ChisteRepository
    {
        private readonly HttpClient _httpClient;


        public ChisteRepository()
        {
            _httpClient = new HttpClient();
        }

        public async Task<Chiste> GetChisteRandom()
        {
            try
            {
                var url = "https://official-joke-api.appspot.com/random_joke";
                var response = await _httpClient.GetStringAsync(url);
                var chiste = JsonSerializer.Deserialize<Chiste>(response);
                return chiste;
            }
                catch (Exception ex)
            {
                return new Chiste
                {
                    setup = "Error al obtener el chiste",
                    punchline = ex.Message
                };
            }
        }
        public class Chiste
        {
            public string setup { get; set; }
            public string punchline { get; set; }
        }
    }
}
