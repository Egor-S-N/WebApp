using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.OpenApi.Models;
namespace WebProject
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        // регистрирует сервисы, используемые приложением 
        public void ConfigureServices(IServiceCollection services)
        {
                services.AddMvc();
                //генерация json документа 
                services.AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Ip Doc", Version = "v1" });
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // устанавливает то, как приложение будет обрабатывать запрос 
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //ВАЖНО!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("v1/swagger.json", "My API V1");
            });
            app.UseStaticFiles();
            
        app.Run(async (context) =>
        {
            await context.Response.WriteAsync(ReadDB.tryc());
        });

        // app.Map("/Swagger", Swagger);

























            // app.Run(async context=>
            // {
            //     await context.Response.WriteAsync("hello");
            // });
                // если приложение в процессе разработки 
                //(есть 3 режима: разработка, подготовка к развертыванию, полноценное исползование)
            // if (env.IsDevelopment())
            // {
            //     // то выводим информацию об ошибке, при наличии ошибки
            //     app.UseDeveloperExceptionPage();
            // }
            // // добавляем возможности маршрутизации
            // app.UseRouting();


            //  app.UseStaticFiles();   // добавляем поддержку статических файлов
             
            // app.Run(async (context) =>
            // {
            //     await context.Response.WriteAsync("Hello World");
            // });
        // app.UseDirectoryBrowser();
        








            //use - добавляет копоненты в конвеер, но он еще может вызывать следующий компонент в конвеере
            // int x = 5;
            // int y = 8;
            // int z = 0;
            // app.Use(async(context,next)=>
            // {
            //     z = x * y;
            //     await next.Invoke(); // переход к run 
            // });


            // // run - добавление компонентов в конвейер
            // app.Run(async(context)=>
            // {
            //     await context.Response.WriteAsync($"{x} * {y} = {z}"); // финальная отпарвка ответа пользователю 
            //     // await context.Response.WriteAsync("AAAAAAAAAAAAAA");
            // });



            // методы MAP - применяются для проверки пути запроса с определенным делегатом 



        //     app.Map("/index", Index);
        //     app.Map("/about", About);

        //     app.Run(async(context)=>
        //     {
        //         await context.Response.WriteAsync("Error!PageNotFount!");
        //     });

        // }

      

        // private static void About(IApplicationBuilder app)
        // {
        //     app.Run(async context =>
        //     {
        //         await context.Response.WriteAsync("About");
        //     });
        // }


        // app.UseMiddleware<Token>();

        // app.Run(async context =>
        // {
        //     await context.Response.WriteAsync("hello");
        // });


      
        }

  private static void Swagger(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("swagger");
            });
        }


    }
    
}
