// Write a programm which computes Akkerman function with recursion with numbers m, n.

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
int AkkermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AkkermanFunc(m - 1, 1);
    }
    else
    {
        return (AkkermanFunc(m - 1, AkkermanFunc(m, n - 1)));
    }
}

int numberM = ReadData("Enter number m: ");
int numberN = ReadData("Enter number n: ");

int result = AkkermanFunc(numberM, numberN);
DataOutput("The result is: " + result);