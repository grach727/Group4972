// Write a programm which takes in a 3-digit number and returns it's 2nd digit.

Console.WriteLine("Enter a 3-digit number: ");
int num = int.Parse(Console.ReadLine()??"0");

int res = num / 10 % 10;

if (num>=100 && num<1000)
{
   Console.WriteLine(res);
}