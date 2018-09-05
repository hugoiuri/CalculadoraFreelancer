using CalculadoraFreelancer.Domain.Core.Models;
using SQLite;

namespace CalculadoraFreelancer.Domain.Projetos
{
    [Table("Projeto")]
    public class Projeto : Entity
    {
        public string Nome { get; set; }
        public double ValorPorHora { get; set; }
        public int HorasPorDia { get; set; }
        public int DiasDuracaoProjeto { get; set; }
        public double ValorTotal { get; set; }
    }
}
