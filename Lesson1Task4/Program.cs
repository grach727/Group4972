Console.WriteLine("Enter the first number: ");
int num1 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Enter the second number: ");
int num2 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Enter the third number: ");
int num3 = int.Parse(Console.ReadLine()??"0");

int max = num1;

if (num2 > num1 && num2 > num3) max = num2;
    else if (num3 > num1 && num3 > num2) max = num3;

Console.WriteLine("Max number is " + max);
