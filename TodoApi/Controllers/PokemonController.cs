using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TodoApi.Interfaces;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokemonController : ControllerBase, IPokemonF
    {

        private readonly IPokemonF pokemonF;
        public PokemonController(IPokemonF pokemonF)
        {
                this.pokemonF = pokemonF;
        }

        [HttpGet("GetListPokemons")]
        public async Task<NamedAPIResourceList<Pokemon>> GetListPokemons(int limit, int offset)
        {
            try
            {
                return await pokemonF.GetListPokemons(limit, offset);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("GetListPokemonsUrl")]
        public async Task<NamedAPIResourceList<Pokemon>> GetListPokemons(string Url)
        {
            try
            {
                return await pokemonF.GetListPokemons(Url);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
