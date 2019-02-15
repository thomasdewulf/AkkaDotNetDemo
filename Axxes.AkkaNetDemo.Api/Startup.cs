using System;
using System.Threading.Tasks;
using Axxes.AkkaNetDemo.Api.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySql.Data.MySqlClient;

namespace Axxes.AkkaNetDemo.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            //  CheckDatabases();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<DbConnectionContext>();
            services.AddDbContext<PersistenceContext>();
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

        /// <summary>
        /// Used to check if the databases have been initialized.
        /// </summary>
        /* private void CheckDatabases()
         {
             CheckResultsDatabase();
             CheckPresistenceDatabase();
         }*/

        /* private async Task CheckResultsDatabase()
         {
             try
             {
                 using (var conn = new MySqlConnection(Configuration.GetConnectionString(("DbConnection")))
                 {
                     await conn.var query =
                     "select * FROM dbo.HourlyConsumption where DeviceId = '00000000-0000-0000-0000-000000000000\';";
                     var command = conn.CreateCommand();
                     command.CommandText = query;
                     command.CommandType = CommandType.Text;
                     using (var reader = command.ExecuteReader())
                     {
                     while (reader.Read())
                     {
                     Debug.WriteLine("This shouldn't happen");
                 }
                 }
                 }
             }
             catch (Exception)
             {
                 // You will only get here if there is a problem with your AkkaNetResults DB.
                 // Consult the readme on https://github.com/Belenar/AkkaDotNetDemo to solve this
                 throw new Exception("Database not initialized correctly.");
             }
         }*/


        /* private void CheckPresistenceDatabase()
             {
                 try
                 {
                     using (var conn = new MySqlConnection(Configuration.GetConnectionString("PersistenceConnection"))
                     {
                         conn.
                     }
                 }
                 catch (Exception)
                 {
                     // You will only get here if there is a problem with your AkkaPersistence DB.
                     // Consult the readme on https://github.com/Belenar/AkkaDotNetDemo to solve this
                     throw new Exception("Database not initialized correctly.");
                 }
             }  
         }*/
    }
}
