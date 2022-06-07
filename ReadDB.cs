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

        public static string tryc()
        {

            using (NpgsqlConnection con=GetConnect())
            {con.Open();
                // if (con.State == ConnectionState.Open )
                // {
                //     return "Yes";
                // }
                // else return "No";
                var com =  new NpgsqlCommand("SELECT*FROM users",con);
                string s = "";
                NpgsqlDataReader dr = com.ExecuteReader();
 
                // Output rows
                while (dr.Read())
                s +=dr[1] + "\n";
 
         con.Close();
                
               
                return s;

            }
        }
    }
}