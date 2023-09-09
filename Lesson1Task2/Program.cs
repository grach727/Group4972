Console.WriteLine("Enter the first number: ");
int num1 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Enter the second number: ");
int num2 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine(num1 < num2 ? "Number 1 is less than Number 2. Number 2 is greater than Number 1." : "Number 2 is less than Number 1. Number 1 is greater than Number 2.");