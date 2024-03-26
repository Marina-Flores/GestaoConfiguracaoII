using ProdutosRestAPI.Entities;
using ProdutosRestAPI.Interfaces;

namespace ProdutosRestAPI.Services
{
    public class FilmeService(IFilmeRepository filmeRepository)
    {
        private readonly IFilmeRepository _filmeRepository = filmeRepository;

        public async Task<IEnumerable<Filme>> GetAllFilmes()
            => await _filmeRepository.GetAllFilmes();

        public async Task AddFilme(Filme filme)
            => await _filmeRepository.AddFilme(filme);
    }
}
