using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorkWithRepositoryPartens.Data.Models;

namespace UnitOfWorkWithRepositoryPartens.Data
{
    public class TestDbContext:DbContext
    {
        public TestDbContext(DbContextOptions options):base(options)
        {

        }
        public TestDbContext()
        {

        }
        public DbSet<Test> Tests { get; set; }
    }
}
