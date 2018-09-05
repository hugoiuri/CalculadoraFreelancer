using CalculadoraFreelancer.Domain.Interfaces;
using CalculadoraFreelancer.Domain.Projetos;
using CalculadoraFreelancer.Services.Interfaces;

namespace CalculadoraFreelancer.Services
{
    public class ProjetoService : IProjetoService
    {
        private readonly IProjetoRepository ProjetoRepository;

        public ProjetoService(IProjetoRepository projetoRepository)
        {
            ProjetoRepository = projetoRepository;
        }

        public void Inserir(Projeto projeto)
        {
            ProjetoRepository.Insert(projeto);
        }
    }
}
