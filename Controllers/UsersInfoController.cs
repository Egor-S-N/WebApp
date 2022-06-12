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
    public class UsersInfoController : Controller
    {
        private readonly IConfiguration configuration;
        public UsersInfoController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        //Просмотр данных пользователей
        [HttpGet]
        public JsonResult Get()
        {
            string query = "select * from usersinfo";
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


            return new JsonResult(table);
        }
        // Добавление нового пользователя 
        [HttpPost]
        public JsonResult Post(Models.UsersInfo usersInfo)
        {
            string query = "insert into  usersinfo Values(@ID, @LASTNAME,@DATA,@AGE)";
            DataTable table = new DataTable();
            string sqldatasourec = configuration.GetConnectionString("UsersCon");
            NpgsqlDataReader dr;
            using (NpgsqlConnection con = new NpgsqlConnection(sqldatasourec))
            {
                con.Open();
                using (NpgsqlCommand com = new NpgsqlCommand(query, con))
                {
                    com.Parameters.AddWithValue("@ID", usersInfo.InfoID);
                    com.Parameters.AddWithValue("@LASTNAME", usersInfo.LastName);
                    com.Parameters.AddWithValue("@DATA", usersInfo.Date);
                    com.Parameters.AddWithValue("@AGE", usersInfo.Age);
                    dr = com.ExecuteReader();
                    table.Load(dr);

                    dr.Close();
                    con.Close();
                }
            }
            return new JsonResult("Added succesfull");

        }

        // Обновление записи////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [HttpPut]
        public JsonResult Put(Models.UsersInfo usersInfo)
        {
            string query = "update usersinfo" +
                "set lastname = @NAME," +
                "dob = @DATA," +
                "age = @AGE" +
                "where id = @ID";
            DataTable table = new DataTable();
            string sqldatasourec = configuration.GetConnectionString("UsersCon");
            NpgsqlDataReader dr;
            using (NpgsqlConnection con = new NpgsqlConnection(sqldatasourec))
            {
                con.Open();
                using (NpgsqlCommand com = new NpgsqlCommand(query, con))
                {
                    com.Parameters.AddWithValue("@ID", usersInfo.InfoID);
                    com.Parameters.AddWithValue("@LASTNAME", usersInfo.LastName);
                    com.Parameters.AddWithValue("@DATA", usersInfo.Date);
                    com.Parameters.AddWithValue("@AGE", usersInfo.Age);
                    dr = com.ExecuteReader();
                    table.Load(dr);

                    dr.Close();
                    con.Close();
                }
            }
            return new JsonResult("Updated succesfull");

        }
        // Обновление записи
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            string query = "delete from usersinfo where" +
                "id = @ID";
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
