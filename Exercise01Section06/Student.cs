using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01Section06
{
    internal class Student
    {
        private string Name { get; set; } = "";
        private string Email { get; set; } = "";

        public Student(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Name}, {Email}";
        }
    }
}
