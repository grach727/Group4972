Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine()??"0");

Console.WriteLine(number%2 == 0 ? "This is an even number." : "This is an odd number.");