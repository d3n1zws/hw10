using ConsoleApp4;
using System.ComponentModel;

Console.WriteLine("username daxil edin:");
string username = Console.ReadLine();
Console.WriteLine("password daxil edin:");
string password = Console.ReadLine();
ConsoleApp4.User user = new ConsoleApp4.User(username, password);
Console.WriteLine($"username : {user.Username}");
Console.WriteLine($"password : {user.Password}");
Console.WriteLine("yas daxil edin:");
int age = int.Parse(Console.ReadLine());
user.Age = age;
Console.WriteLine(user.Age);
