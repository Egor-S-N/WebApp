using System;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WebProject.Models
{
     public partial class User
    {
        public int userid{get;set;}
        public string name{get;set;}   
    }

   
   
}