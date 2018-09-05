﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace CalculadoraFreelancer.Domain.Interfaces
{
    public interface IRepository<TEntity>
    {
        Task<TEntity> Find(string id);
        Task<TEntity> GetFirst();
        Task<IEnumerable<TEntity>> GetAll();
        Task Insert(TEntity tEntity);
        Task Update(TEntity tEntity);
        Task Delete(TEntity tEntity);
    }
}
