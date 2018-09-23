using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorkWithRepositoryPartens.Data;

namespace UnitOfWorkWithRepositoryPartens.Interface.Repository
{
    public interface IUnitOfWork
    {
         TestDbContext DbContext { get; }
    }
}
