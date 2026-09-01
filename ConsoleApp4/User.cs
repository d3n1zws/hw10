using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    internal class User
    {
        public string Username; 
        public string Password
        {
            get
            {
                return field;
            }
            set
            {
                if (value == "" || value == null)
                {
                    Console.WriteLine("password bos ola bilmez");
                    return;
                }
                bool check1 = false, check2 = false, check3 = false;
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsUpper(value[i]))
                        check1 = true;
                    if (char.IsLower(value[i]))
                        check2 = true;
                    if (char.IsNumber(value[i]))
                        check3 = true;
                }
                if (check1 && check2 && check3)
                    field = value;
                else
                    Console.WriteLine("sertler odenmir");
            }
        }
        public int Age
        {
            get;
            set
            {
                if (value < 0)
                    Console.WriteLine("yas 0-dan kicik ola bilmez");
                field = value;
            }
        }
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}

