// Write a programm which takes in two numbers (a, b) and returns result = a^b.

// 1) Input a, b
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

// 2) Solving
long MyPow(int a, int b)
{
    long result = 1;
    while (b > 0)
    {
        result = result * a;
        b = b - 1;
    }
return result;
}

// 3) Output
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int a = ReadData("Enter number A");
int b = ReadData("Enter number B");

long powerAB = MyPow(a, b);

PrintResult("A power B result is " + powerAB + ".");