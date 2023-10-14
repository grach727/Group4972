// Write a programm which returns the sum of all natural elements from M to N, entered by user.

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
int RecSum(int m, int n)
{
    int sum = 0;
    if (n <= m)
    {
    sum = n;
    }
    else
    {
    sum = m + RecSum(m + 1, n);
    }
    return sum;
}

int numberM = ReadData("Enter number M: ");
int numberN = ReadData("Enter number N: ");

DataOutput($"{RecSum(numberM, numberN)}");