// Write a programm which takes in a number (N) and returns the table of squares of numbers from 1 to N.

// 1) Input a number N
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

// 2) Solving
string BuildLine(int num, int pow)
{
    string result = String.Empty;

    for (int i = 1; i <= num; i++)
    {
        result = result + Math.Pow(i, pow) + " ";
    }
    return result;
}

// 3) Output
void DataOutput(string msg)
{
    Console.WriteLine(msg);
}

int num = ReadData("Input a number: ");
int pow = ReadData("Input power: ");

string result = BuildLine(num, pow);

DataOutput("Table of squares: " + result);