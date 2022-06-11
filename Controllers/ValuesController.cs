    using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.OpenApi.Models;
using Npgsql;


namespace WebProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Values : ControllerBase
    {
        
        private readonly ILogger<Values> _logger;
        public Values(ILogger<Values> logger)
        {
            _logger = logger;
        }
       

        // [HttpGet]
        // public IEnumerable<User> Get()
        // {
        //     return ReadDB.ReadUsers();           
        // }
        // [HttpPost]
        // public IEnumerable<User> Post()
        // {
        //      ReadDB.AddUser();
        //      return null;
        // }
    }
}