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
using WebProject.Repositories.ForUsersInfo;
using Microsoft.EntityFrameworkCore;
using WebProject.Models;
namespace WebProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersInfoController : Controller
    {
        private readonly IInfoRepository _infoRepository;

        public UsersInfoController(IInfoRepository infoRepository)
        {
            _infoRepository = infoRepository;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<UsersInfo>> GetOne(int id)
        {
            var info = await _infoRepository.Get(id);
            if (info == null)
                return NotFound();
            return Ok(info);
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsersInfo>>> Gett()
        {
            var info = await _infoRepository.GetAll();
            return Ok(info);
        }
        [HttpPost]
        public async Task<ActionResult> Post(UsersInfo info)
        {

            await _infoRepository.Add(info);
            return Ok(info);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _infoRepository.Delete(id);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UsersInfo info)
        {
            UsersInfo newInfo = new()
            {
                lastname = info.lastname,
                dob = info.dob,
                age = info.age
                
            };
            await _infoRepository.Update(newInfo);
            return Ok();
        }


    }
}
