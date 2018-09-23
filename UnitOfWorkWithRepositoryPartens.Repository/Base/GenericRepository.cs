using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitOfWorkWithRepositoryPartens.Interface.Repository;

namespace UnitOfWorkWithRepositoryPartens.Repository.Base
{
    public class GenericRepository<T> : IRepository<T>  where T : class
    {
        public GenericRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.dbset = unitOfWork.DbContext.Set<T>();
        }
        private DbSet<T> dbset;
        public IUnitOfWork unitOfWork { get; private set; }

        public void Add(T entity)
        {
            this.dbset.Add(entity);
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            this.unitOfWork.DbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> getAll()
        {
            return this.dbset.ToList();
        }
    }
}
