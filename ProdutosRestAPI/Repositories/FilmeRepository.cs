using ProdutosRestAPI.Entities;
using ProdutosRestAPI.Interfaces;

namespace ProdutosRestAPI.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        private readonly List<Filme> _filmes;

        public FilmeRepository()
        {
            _filmes =
            [
                new (1, "Harry Potter e a Pedra Filosofal", "Chris Columbus", 2001, "Fantasia", 59.99m),
                new (2, "Harry Potter e a Câmara Secreta", "Chris Columbus", 2002, "Fantasia", 49.99m),
                new (3, "Harry Potter e o Prisioneiro de Azkaban", "Alfonso Cuarón", 2004, "Fantasia", 69.99m),
                new (4, "Harry Potter e o Cálice de Fogo", "Mike Newell", 2005, "Fantasia", 39.99m),
                new (5, "Harry Potter e a Ordem da Fênix", "David Yates", 2007, "Fantasia", 29.99m),
                new (6, "Harry Potter e o Enigma do Príncipe", "David Yates", 2009, "Fantasia", 79.99m),
                new (7, "Harry Potter e as Relíquias da Morte - Parte 1", "David Yates", 2010, "Fantasia", 89.99m),
                new (8, "Harry Potter e as Relíquias da Morte - Parte 2", "David Yates", 2011, "Fantasia", 99.99m)
            ];
        }        

        public Task<IEnumerable<Filme>> GetAllFilmes()
            => Task.FromResult<IEnumerable<Filme>>(_filmes);

        public Task AddFilme(Filme filme)
        {
            filme.Id = _filmes.Count + 1;
            _filmes.Add(filme);
            return Task.CompletedTask;
        }
    }
}
