using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorkWithRepositoryPartens.Data;
using UnitOfWorkWithRepositoryPartens.Interface.Repository;


namespace UnitOfWorkWithRepositoryPartens.Repository.Base
{
    public class UnitOfWork :IDisposable, IUnitOfWork
    {
        private static TestDbContext dbContext = null;
        public bool disposed = false;
        public TestDbContext DbContext
        {
            get
            {
                if (dbContext == null)
                {
                    dbContext = new TestDbContext();
                }
                return dbContext;
            }
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.DbContext.Dispose();
                }
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
