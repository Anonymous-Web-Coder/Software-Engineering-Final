using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System.Business_Logic_Layer
{
    internal class Student
    {
        public Student(string name, string surname, string password, string email, string course)
        {
            Name = name;
            Surname = surname;
            Password = password;
            Email = email;
            Course = course;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }


        public override string? ToString()
        {
            return $"{Name},{Surname},{Email},{Password}";
        }
    }
}

