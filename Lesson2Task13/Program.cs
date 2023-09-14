// Write a programm which takes in a number and returns it's third digit or reports, that there is no third digit.

Console.WriteLine("Enter a number: ");
int num = int.Parse(Console.ReadLine()??"0");

if (num < 100)
{
    Console.WriteLine("No third digit!");
}
else
{
    while (num > 999)
{
    num = num / 10;
}

int result = num % 10;

Console.WriteLine(result);
}

