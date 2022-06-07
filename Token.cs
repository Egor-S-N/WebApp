using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
namespace WebProject
{
    public class Token
    {
        private readonly RequestDelegate next;

        public Token(RequestDelegate next)
        {
            this.next = next;
        }


        public async Task InvokeAsync(HttpContext context)
        {
            var token = context.Request.Query["token"];
            if (token != "12345678")
            {
                 context.Response.StatusCode = 403;
                await context.Response.WriteAsync("Token is invalid");
                }
            else
                {
                    await next.Invoke(context);
                }
        }
    }
}