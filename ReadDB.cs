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
using System.Data;
using System.Windows;
using Npgsql;
namespace WebProject
{
    public class ReadDB
    {
        public static NpgsqlConnection GetConnect()
        {
            return new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres; Password=111;Database=WebDB"); 
        }

        public static List<User> ReadUsers()
        {

            using (NpgsqlConnection con=GetConnect())
            {
                con.Open();
                var com =  new NpgsqlCommand("SELECT*FROM users",con);
                List<User> s = new List<User>();
                NpgsqlDataReader dr = com.ExecuteReader();
                while(dr.Read())
                {

                        User user = new User(Convert.ToInt32(dr.GetValue(0)),dr.GetValue(1).ToString());
                        s.Add(user);
                   
                }
                con.Close();
                return s;

            }
        }

        public static void AddUser()
        {
            using(NpgsqlConnection con = GetConnect())
            {
                
                con.Open();
                var com = new NpgsqlCommand($"Insert into users VALUES (4,'tst')", con);
                com.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}