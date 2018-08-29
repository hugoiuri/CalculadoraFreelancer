using CalculadoraFreelancer.Domain.Projeto;
using CalculadoraFreelancer.Infra.Data.Repository;

namespace CalculadoraFreelancer.Services
{
    public class ProjetoService
    {
        private readonly AzureProjetoRepository ProjetoRepository;

        public ProjetoService()
        {
            ProjetoRepository = new AzureProjetoRepository();
        }

        public void Inserir(Projeto projeto)
        {
            ProjetoRepository.Insert(projeto);
        }
    }
}
