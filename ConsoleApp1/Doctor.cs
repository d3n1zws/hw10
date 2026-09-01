using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Doctor
    {

        public string FullName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Doctor(string fullName, int age, string email, string address)
        {
            FullName = fullName;
            Age = age;
            Email = email;
            Address = address;
        }
    }
}
