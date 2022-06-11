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
    public class HomeController:Controller
    {

            private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
       
            public ActionResult Get()
            { 
                IEnumerable<User> users =ReadDB.ReadUsers();
                return View(users);
            }

       

            // [HttpPost]
            // public ActionResult Post()
            // {
            //     return View();
            // }



    }
}