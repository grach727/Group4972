// Write a programm which takes in a number and returns the sum from 1 to number.

// 1) Input
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

// 2) Solving 1
int SimpleSum(int numA)
{
    int sumOfNumber = 0;
    for (int i = 0; i <= numA; i++)
    {
        sumOfNumber += i;
    }
    return sumOfNumber;
} 

// 2.1) Solving 2
int GaussSum(int numA)
{
    int sumOfNumber1 = (numA*(numA+1))/2;
    return sumOfNumber1;
}

// 3) Output
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int numberA = ReadData("Enter number A: ");

DateTime d1 = DateTime.Now;
int res1 = SimpleSum(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = GaussSum(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Simple Sum of numbers from 1 to " + numberA + " is " + res1 + ".");
PrintResult("Gauss Sum of numbers from 1 to " + numberA + " is " + res2 + ".");