using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnitOfWorkWithRepositoryPartens.Data.Models;

namespace UnitOfWorkWithRepositoryPartens.Data
{
    public class TestDbContext:DbContext
    {
        public TestDbContext(DbContextOptions options) : base(options)
        {

        }

        public TestDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=DESKTOP-KK1QB16;Database=TestDb;Trusted_Connection=True");
            base.OnConfiguring(builder);
        }

        public DbSet<Test> Tests { get; set; }
    }
}
