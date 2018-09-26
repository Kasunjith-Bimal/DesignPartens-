using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using UnitOfWorkWithRepositoryPartens.BusinessServise;
using UnitOfWorkWithRepositoryPartens.Data;
using UnitOfWorkWithRepositoryPartens.Data.Models;
using UnitOfWorkWithRepositoryPartens.Interface.Repository;
using UnitOfWorkWithRepositoryPartens.Interface.Servise;
using UnitOfWorkWithRepositoryPartens.Repository;
using UnitOfWorkWithRepositoryPartens.Repository.Base;

namespace UnitOfWorkWithRepositoryPartens
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
    
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
          
            services.AddSingleton<IUnitOfWork, UnitOfWork>();
            services.AddSingleton<IDisposable, UnitOfWork>();
            services.AddSingleton<ITestServise, TestServise>();
            services.AddSingleton<ITestRepository, TestRepository>();
            services.AddSingleton(typeof(IRepository<>), typeof(GenericRepository<>));


            //services.AddSingleton<IRepository<Test>>(x => x.GetService<ITestRepository>());
            var connection = @"Server=DESKTOP-KK1QB16;Database=TestDb;Trusted_Connection=True";
            services.AddDbContext<TestDbContext>(options => options.UseSqlServer(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
