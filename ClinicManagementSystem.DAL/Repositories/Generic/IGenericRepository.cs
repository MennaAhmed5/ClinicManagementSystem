using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.DAL.Repositories.Generic
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity? GetbyId(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
