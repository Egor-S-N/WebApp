using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Http;
using Npgsql;
using System.Net.Http;
namespace WebProject.Controllers
{
    [ApiExplorerSettings(IgnoreApi=true)]
    [Route("[controller]")]

    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string login, string password)
        {
            string authData = $"Login: {login}   Password: {password}";
            return Content(authData);
        }



        // [HttpPost]
        // public ActionResult Post()
        // {
        //     return View();
        // }



    }
}