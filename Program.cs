using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Swagger;
namespace WebProject
{
    public class Program
    {

        public static void Main(string[] args)
        {
           
            CreateHostBuilder(args).Build().Run();
          
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            
        // создание хоста 
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {

                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseWebRoot("Pages");// добавялем ссылку на папку с макетами 
                    
                });
    }
}
