using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using System.Data;
using Npgsql;
using System.Net.Http;
using WebProject.DAL;
using WebProject.Repositories.ForUsers;
using Microsoft.EntityFrameworkCore;
using WebProject.Models;

namespace WebProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetOne(int id)
        {
            var user = await _userRepository.Get(id);
            if (user == null)
                return NotFound();
            return Ok(user);
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> Get()
        {
            var users = await _userRepository.GetAll();
            return Ok(users);
        }
        [HttpPost]
        public async Task<ActionResult> Post(User user)
        {
           
            await _userRepository.Add(user);
            return Ok(user);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _userRepository.Delete(id);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult>Update(int id, User user)
        {
            User newUser = new()
            {
                name = user.name
            };
            await _userRepository.Update(newUser);
            return Ok();
        }

       
      
    }
}
