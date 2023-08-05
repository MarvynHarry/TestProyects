using TodoApi.Interfaces;
using TodoApi.Models;

namespace TodoApi.Services
{
    public class PokemonService : IPokemonF
    {
        private const string Key = "ApiUrl";
        private readonly string? ApiUrl;
        private readonly HttpClient httpClient;
        public PokemonService(IConfiguration configuration, HttpClient httpClient)
        {
            ApiUrl = configuration.GetSection(Key).GetValue<string>("pokeapi");
            this.httpClient = httpClient;
        }

        public async Task<NamedAPIResourceList<Pokemon>> GetListPokemons(int limit, int offset)
        {
            try
            {

                string Url = string.Format("{0}pokemon/?limit={1}&offset={2}", ApiUrl, limit, offset);
                var nameds = await httpClient.GetFromJsonAsync<Named>(Url);

                var Result = new NamedAPIResourceList<Pokemon>()
                {
                    Count = nameds.Count,
                    Next = nameds.Next,
                    Previous = nameds.Previous,
                    Name = "Pokemons"
                };

                foreach (var item in nameds.Results)
                    Result.Results.Add(await httpClient.GetFromJsonAsync<Pokemon>(item.url));

                return Result;
            }
            catch (Exception)
            {
                throw;
            }
        }       
        
        public async Task<NamedAPIResourceList<Pokemon>> GetListPokemons(string Url)
        {
            try
            {
                var nameds = await httpClient.GetFromJsonAsync<Named>(Url);
                var Result = new NamedAPIResourceList<Pokemon>()
                {
                    Count = nameds.Count,
                    Next = nameds.Next,
                    Previous = nameds.Previous,
                    Name = "Pokemons"
                };

                foreach (var item in nameds.Results)
                    Result.Results.Add(await httpClient.GetFromJsonAsync<Pokemon>(item.url));

                return Result;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
