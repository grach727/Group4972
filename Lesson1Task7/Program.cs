int num = int.Parse(Console.ReadLine()??"0");

if (num >= 100 && num < 1000)
{
    int lastDigit = num % 10;
    Console.WriteLine("Last digit of this number is " + lastDigit);
}
else
{
    Console.WriteLine("This number is not a 3-digit number!");
}
