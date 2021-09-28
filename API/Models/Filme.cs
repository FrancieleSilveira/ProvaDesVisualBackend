using System;
namespace API.Models
{
    public class Filme
    {
        public Filme() => CriadoEm = DateTime.Now;
        
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int Ano { get; set; }
        public string Diretor { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString() =>
            $"Título: { Titulo } | Gênero: { Genero } | Ano: { Ano } | Diretor: { Diretor } | Criado em: { CriadoEm }";
    }
}