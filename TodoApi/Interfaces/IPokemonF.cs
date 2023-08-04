using TodoApi.Models;

namespace TodoApi.Interfaces
{
    public interface IPokemonF
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public Task<NamedAPIResourceList<Pokemon>> GetListPokemons(int limit, int offset);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public Task<NamedAPIResourceList<Pokemon>> GetListPokemons(string Url);
    }
}
