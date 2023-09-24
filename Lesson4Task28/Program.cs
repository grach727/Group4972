// Write a programm which takes in number N and returns the multiplication of numbers from 1 to number N.

using System.Numerics;

// 1) Input
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

// 2) Solving

BigInteger Factorial(int num)
{
    BigInteger res = 1;
    for (int i = 2; i <= num; i++)
    {
        res = res * i;
    }
    return res;
}

// 3) Output
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int number = ReadData("Input a number: ");

BigInteger factorial = Factorial(number);

PrintResult("The multiple from 1 to " + number + " is " + factorial + ".");

