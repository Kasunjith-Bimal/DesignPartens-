using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorkWithRepositoryPartens.Data.Models;
using UnitOfWorkWithRepositoryPartens.Interface.Repository;
using UnitOfWorkWithRepositoryPartens.Repository.Base;

namespace UnitOfWorkWithRepositoryPartens.Repository
{
    public class TestRepository : GenericRepository<Test>, ITestRepository
    {
        public TestRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
