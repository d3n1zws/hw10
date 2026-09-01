using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Calculation
    {
        public int n { get; set; }
        public int m { get; set; }
        public char c 
        { 
            get; 
            set
            {
                if (value == '+' || value == '-' || value == '*' || value == '/')
                {
                    field = value;
                }
                else
                {
                    Console.WriteLine("sehv operator daxil elemisiniz");
                }
            }
        }
        public Calculation(int n, int m, char c)
        {
            this.n = n;
            this.m = m;
            this.c = c;
        }
        public void Calculate()
        {
            switch (c)
            {
                case '+':
                    Console.WriteLine($"Cavab: {n + m}");
                    break;
                case '-':
                    Console.WriteLine($"Cavab: {n - m}");
                    break;
                case '*':
                    Console.WriteLine($"Cavab: {n * m}");
                    break;
                case '/':
                    if (m != 0)
                    {
                        Console.WriteLine($"Cavab: {(double)n / m}");
                    }
                    else
                    {
                        Console.WriteLine("0-a bolme sehvdir");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
