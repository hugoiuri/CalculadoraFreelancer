using CalculadoraFreelancer.Domain.Interfaces;
using CalculadoraFreelancer.Domain.Profissionais;

namespace CalculadoraFreelancer.Infra.Data.Repository
{
    public class ProfissionalRepository : SqLiteRepository<Profissional>, IProfissionalRepository
    {
    }
}
