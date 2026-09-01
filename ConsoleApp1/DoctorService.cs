using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class DoctorService
    {
        Doctor[] doctors;
        public DoctorService(Doctor[] doctors)
        {
            this.doctors = doctors;
        }

        public void GetAll()
        {
            foreach (var doctor in doctors)
            {
                Console.WriteLine($"FullName: {doctor.FullName}, Age: {doctor.Age}, Email: {doctor.Email}, Address: {doctor.Address}");
            }
        }
        public void SearchByFullName(string fullName)
        {
            foreach (var doctor in doctors)
            {
                if (doctor.FullName.ToLower().Contains(fullName.ToLower()))
                {
                    Console.WriteLine($"FullName: {doctor.FullName}, Age: {doctor.Age}, Email: {doctor.Email}, Address: {doctor.Address}");
                }
            }
        }
        public void SearchByAge(int age)
        {
            foreach (var doctor in doctors)
            {
                if (doctor.Age == age)
                {
                    Console.WriteLine($"FullName: {doctor.FullName}, Age: {doctor.Age}, Email: {doctor.Email}, Address: {doctor.Address}");
                }
            }
        }
        public void GetAverageByAge()
        {
            int sum = 0;
            foreach (var doctor in doctors)
            {
                sum += doctor.Age;
            }
            Console.WriteLine($"Average Age: {sum / doctors.Length}");
        }
    }
}
