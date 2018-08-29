using CalculadoraFreelancer.Domain.Profissionais;
using CalculadoraFreelancer.Infra.Data.Repository;

namespace CalculadoraFreelancer.Services
{
    public class ProfissionalService
    {
        private readonly AzureRepository ProfissionalRepository;

        public ProfissionalService()
        {
            ProfissionalRepository = new AzureRepository();
        }

        public void Inserir(Profissional profissional)
        {
            ProfissionalRepository.Insert(profissional);
        }
    }
}
