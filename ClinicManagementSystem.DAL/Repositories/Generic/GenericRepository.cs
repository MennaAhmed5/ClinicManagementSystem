using ClinicManagementSystem.DAL.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.DAL.Repositories.Generic
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly AppDbContext _context;
        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().AsNoTracking();
        }

        public TEntity? GetbyId(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Update(TEntity entity)
        {

        }
    }
}
