using CalculadoraFreelancer.Domain.Interfaces;
using CalculadoraFreelancer.Domain.Projetos;
using CalculadoraFreelancer.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public Task<IEnumerable<Projeto>> ObterTodos()
        {
            return ProjetoRepository.GetAll();
        }
    }
}
