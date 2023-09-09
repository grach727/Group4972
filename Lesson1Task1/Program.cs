Console.WriteLine("Enter first number: ");
int numA = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Enter second number: ");
int numB = int.Parse(Console.ReadLine()??"0");

Console.WriteLine(numA == Math.Pow(numB,2) ? "Yes" : "No");