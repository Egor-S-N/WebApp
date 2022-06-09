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

        public static List<string> tryc()
        {

            using (NpgsqlConnection con=GetConnect())
            {
                con.Open();
                var com =  new NpgsqlCommand("SELECT*FROM users",con);
                List<string> s = new List<string>();
                NpgsqlDataReader dr = com.ExecuteReader();
                int ColumnCount = dr.FieldCount;
                while(dr.Read())
                {
                    for (var i = 0; i < ColumnCount; i++)
                    {
                        s.Add(dr[i]+"");
                    }
                }
                con.Close();
                return s;

            }
        }
    }
}