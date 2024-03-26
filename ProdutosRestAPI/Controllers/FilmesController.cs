using Microsoft.AspNetCore.Mvc;
using ProdutosRestAPI.Entities;
using ProdutosRestAPI.Services;

namespace ProdutosRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmesController(FilmeService filmeService) : ControllerBase
    {
        private readonly FilmeService _filmeService = filmeService;

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var filmes = await _filmeService.GetAllFilmes();

            if(filmes == null || !filmes.Any())
                return NoContent();

            return Ok(filmes);
        }

        [HttpPost]
        public async Task<ActionResult<Filme>> AddFilme(Filme filme)
        {
            try
            {
                if (filme == null)
                    return BadRequest();

                await _filmeService.AddFilme(filme);

                return Created();
            }
            catch(Exception ex) 
            {
                return Problem(
                    detail: $"An error ocurred while creating the product: {ex}",
                    title: "Internal Server Error",
                    statusCode: 500);
            }            
        }
    }
}
