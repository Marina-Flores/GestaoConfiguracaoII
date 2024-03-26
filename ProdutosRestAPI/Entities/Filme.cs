using System.Text.Json.Serialization;

namespace ProdutosRestAPI.Entities
{
    public class Filme(int id, string titulo, string diretor, int ano, string genero, decimal preco)
    {
        [JsonIgnore]
        public int Id { get; set; } = id;
        public string Titulo { get; set; } = titulo;
        public string Diretor { get; set; } = diretor;
        public int Ano { get; set; } = ano;
        public string Genero { get; set; } = genero;
        public decimal Preco { get; set; } = preco;
    }
}
