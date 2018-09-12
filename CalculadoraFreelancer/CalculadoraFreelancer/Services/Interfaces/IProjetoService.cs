using CalculadoraFreelancer.Domain.Projetos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFreelancer.Services.Interfaces
{
    public interface IProjetoService
    {
        void Inserir(Projeto projeto);
        Task<IEnumerable<Projeto>> ObterTodos();
    }
}
