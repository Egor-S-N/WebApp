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

namespace WebProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IConfiguration configuration;
        public UsersController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }


        //Просмотр данных пользователей
        [HttpGet]
        public JsonResult Get()
        {
            string query = "select * from users";
            DataTable table = new DataTable();
            string sqldatasourec = configuration.GetConnectionString("UsersCon");
            NpgsqlDataReader dr;
            using (NpgsqlConnection con = new NpgsqlConnection(sqldatasourec))
            {
                con.Open();
                using (NpgsqlCommand com = new NpgsqlCommand(query, con))
                {
                    dr = com.ExecuteReader();
                    table.Load(dr);

                    dr.Close();
                    con.Close();
                }
            }

          
            return  new JsonResult(table);
        }
        // Добавление нового пользователя 
        [HttpPost]
        public JsonResult Post(User user)
        {
            string query = "insert into users values(@ID, @NAME)";
            DataTable table = new DataTable();
            string sqldatasourec = configuration.GetConnectionString("UsersCon");
            NpgsqlDataReader dr;
            using (NpgsqlConnection con = new NpgsqlConnection(sqldatasourec))
            {
                con.Open();
                using (NpgsqlCommand com = new NpgsqlCommand(query, con))
                {
                    com.Parameters.AddWithValue("@ID", user.UserID);
                    com.Parameters.AddWithValue("@NAME", user.UserName);
                    dr = com.ExecuteReader();
                    table.Load(dr);

                    dr.Close();
                    con.Close();
                }
            }
            return new JsonResult("Added succesfull");

        }

        // Обновление записи
        [HttpPut]
        public JsonResult Put(User user)
        {
            string query = "update users" +
                "set name = @NAME" +
                "where userid = @ID ";
            DataTable table = new DataTable();
            string sqldatasourec = configuration.GetConnectionString("UsersCon");
            NpgsqlDataReader dr;
            using (NpgsqlConnection con = new NpgsqlConnection(sqldatasourec))
            {
                con.Open();
                using (NpgsqlCommand com = new NpgsqlCommand(query, con))
                {
                    com.Parameters.AddWithValue("@ID", user.UserID);
                    com.Parameters.AddWithValue("@NAME", user.UserName);
                    dr = com.ExecuteReader();
                    table.Load(dr);

                    dr.Close();
                    con.Close();
                }
            }
            return new JsonResult("Updated succesfull");

        }
        // Обновление записи
        [HttpDelete ("{id}")]
        public JsonResult Delete(int id)
        {
            string query = "delete from users where" +
                "userid = @ID";
            DataTable table = new DataTable();
            string sqldatasourec = configuration.GetConnectionString("UsersCon");
            NpgsqlDataReader dr;
            using (NpgsqlConnection con = new NpgsqlConnection(sqldatasourec))
            {
                con.Open();
                using (NpgsqlCommand com = new NpgsqlCommand(query, con))
                {
                    com.Parameters.AddWithValue("@ID", id);
                    dr = com.ExecuteReader();
                    table.Load(dr);

                    dr.Close();
                    con.Close();
                }
            }
            return new JsonResult("Deleted succesfull");

        }
    }
}
