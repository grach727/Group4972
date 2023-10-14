// Write a programm which takes in two numbers and powers A to B.

// 1) Console input
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

// 2) Result Output
void DataOutput(string msg)
{
    Console.WriteLine(msg);
}

// 3) Solving
long RecPow(int a, int b)
{
    long res = 1;
    if (b <= 0)
    {
        return 1;
    }
    else
    {
        res = a * RecPow(a, b - 1);
    }
    return res;
}

// 3.1) Solving
long MyPow(int a, int b)
{
    if (b == 2)
    {
        return a * a;
    }
    if (b == 1)
    {
        return a;
    }
    if (b % 2 == 0)
    {
        return MyPow(a, b / 2) * MyPow(a, b / 2);
    }
    else
    {
        return MyPow(a, b / 2) * MyPow(a, b / 2 + 1);   
    }
}

int numberA = ReadData("Enter number A: ");
int numberB = ReadData("Enter number B: ");

long result1 = RecPow(numberA, numberB);
DataOutput("Result: " + result1);

long result2 = MyPow(numberA, numberB);
DataOutput("Result: " + result2);