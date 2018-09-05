using CalculadoraFreelancer.Domain.Interfaces;
using CalculadoraFreelancer.Domain.Profissionais;
using CalculadoraFreelancer.Services.Interfaces;

namespace CalculadoraFreelancer.Services
{
    public class ProfissionalService : IProfissionalService
    {
        private readonly IProfissionalRepository ProfissionalRepository;

        public ProfissionalService(IProfissionalRepository profissionalRepository)
        {
            ProfissionalRepository = profissionalRepository;
        }

        public void Inserir(Profissional profissional)
        {
            ProfissionalRepository.Insert(profissional);
        }
    }

}
