using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorkWithRepositoryPartens.Data.Models;
using UnitOfWorkWithRepositoryPartens.Interface.Repository;

namespace UnitOfWorkWithRepositoryPartens.Interface.Servise
{
    public interface ITestServise
    {
        void Add(Test entity);

        void SaveChanges();

        IEnumerable<Test> getAll();
    }
}
