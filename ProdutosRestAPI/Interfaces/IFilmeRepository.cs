using ProdutosRestAPI.Entities;

namespace ProdutosRestAPI.Interfaces
{
    public interface IFilmeRepository
    {
        Task<IEnumerable<Filme>> GetAllFilmes();
        Task AddFilme(Filme filme);
    }
}
