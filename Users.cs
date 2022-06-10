using System;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.Configuration;
using Npgsql;
namespace WebProject
{
     public class User
    {
        public User(int ID, string Name)
        {
            UserID = ID;
            UserName = Name;
        }
        public int UserID{get;set;}
        public string UserName{get;set;}   
    }

   
   
}