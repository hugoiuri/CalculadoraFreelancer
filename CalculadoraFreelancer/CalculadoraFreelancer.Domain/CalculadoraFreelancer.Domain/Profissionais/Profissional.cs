using CalculadoraFreelancer.Domain.Core.Models;
using SQLite;

namespace CalculadoraFreelancer.Domain.Profissionais
{
    [Table("Profissional")]
    public class Profissional: Entity
    {
        public double ValorGanhoMes { get; set; }
        public int HorasTrabalhadasPorDia { get; set; }
        public int DiasTrabalhadosPorMes { get; set; }
        public int DiasFeriasPorAno { get; set; }
        public double ValorPorHora { get; set; }
    }
}
