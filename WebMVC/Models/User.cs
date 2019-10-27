using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreMVC.Models
{
    public class User
    {
        public int Id { get; }
        public string Name { get; }
        public string Department { get; }
        public string Role { get; }

        public User(int id, string name, string department, string role)
        {
            Id = id;
            Name = name;
            Department = department;
            Role = role;
        }
    }
}
