using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class UsersInfo
    {
       
        public int id{get;set;}
        public string lastname{ get; set; }
        public DateTime dob { get; set; }
        public int age { get; set; }

    }
}
