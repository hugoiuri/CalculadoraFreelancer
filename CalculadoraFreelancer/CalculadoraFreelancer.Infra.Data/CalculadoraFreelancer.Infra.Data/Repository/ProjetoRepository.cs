using CalculadoraFreelancer.Domain.Interfaces;
using CalculadoraFreelancer.Domain.Projetos;

namespace CalculadoraFreelancer.Infra.Data.Repository
{
    public class ProjetoRepository : SqLiteRepository<Projeto>, IProjetoRepository
    {
    }
}
