Console.WriteLine("eded1 daxil edin");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("eded2 daxil edin");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("operator daxil edin");
char c = char.Parse(Console.ReadLine());
ConsoleApp2.Calculation calc = new ConsoleApp2.Calculation(n, m, c);
calc.Calculate();