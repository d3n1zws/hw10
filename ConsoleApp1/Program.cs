using ConsoleApp1;

Console.WriteLine("hekim sayi daxil edin:");
int n = int.Parse(Console.ReadLine());
Doctor[] doctors = new Doctor[n];
for  (int i = 0; i < n; i++)
{
    Console.WriteLine($"hekim{i+1} adi daxil edin:");
    string fullName = Console.ReadLine();
    Console.WriteLine("hekim yasini daxil edin:");
    int age = int.Parse(Console.ReadLine());
    Console.WriteLine("hekim emailini daxil edin:");
    string email = Console.ReadLine();
    Console.WriteLine("hekim adresini daxil edin:");
    string address = Console.ReadLine();
    doctors[i] = new Doctor(fullName, age, email, address);
}
ConsoleApp1.DoctorService doctorService = new ConsoleApp1.DoctorService(doctors);
doctorService.GetAll();

Console.WriteLine("Axracaginiz adi daxil edin:");
string searchFullName = Console.ReadLine();
doctorService.SearchByFullName(searchFullName);

Console.WriteLine("Axracaginiz yasi daxil edin:");
int searchAge = int.Parse(Console.ReadLine());
doctorService.SearchByAge(searchAge);

doctorService.GetAverageByAge();

