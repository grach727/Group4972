// Write a programm which finds all natural elements from M to N, entered by user.

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
string RecMN(int m, int n)
{
    string res = string.Empty;
    if (n <= m)
    {
    res = $"{n}";
    }
    else
    {
    res = $"{m}" + " " + $"{RecMN(m + 1, n)}";
    }
        return res;
}

int numberM = ReadData("Enter number M: ");
int numberN = ReadData("Enter number N: ");

DataOutput(RecMN(numberM, numberN));