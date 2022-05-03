int x = new Random().Next(100, 999);
System.Console.WriteLine(x);
int a = int.Parse(Convert.ToString(x)[0].ToString());
int b = int.Parse(Convert.ToString(x)[2].ToString());
System.Console.WriteLine($"{a}{b}");