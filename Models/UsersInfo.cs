using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class UsersInfo
    {
        public UsersInfo(int id, string lastname, DateTime dob, int age)
        {
            InfoID = id;
            LastName = lastname;
            Date = dob;
            Age = age;
        }

        public int InfoID{get;set;}
        public string LastName { get; set; }
        public DateTime Date { get; set; }
        public int Age { get; set; }

    }
}
