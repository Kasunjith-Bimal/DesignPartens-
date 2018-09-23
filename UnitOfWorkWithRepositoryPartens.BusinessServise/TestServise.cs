using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorkWithRepositoryPartens.Data.Models;
using UnitOfWorkWithRepositoryPartens.Interface.Repository;
using UnitOfWorkWithRepositoryPartens.Interface.Servise;
using UnitOfWorkWithRepositoryPartens.Repository;

namespace UnitOfWorkWithRepositoryPartens.BusinessServise
{
    public class TestServise : ITestServise
    {
        public ITestRepository _ITestRepository;
        public TestServise(ITestRepository ITestRepository)
        {
           _ITestRepository = ITestRepository;
        }

        public void Add(Test entity)
        {
            _ITestRepository.Add(entity);
        }

      
        public void SaveChanges()
        {
            _ITestRepository.SaveChanges();
        }


        public IEnumerable<Test> getAll()
        {
            return _ITestRepository.getAll();
        }
    }
}
