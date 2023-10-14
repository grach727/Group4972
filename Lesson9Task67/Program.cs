// Write a programm which takes in number N and returns the sum of its digits.

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
int SumDigRec(int num)
{
    if (num == 0)
    {
        return 0;
    }
    else
    {
        return num % 10 + SumDigRec(num / 10);
    }
}

int number = ReadData("Enter the number: ");
int sum = SumDigRec(number);
DataOutput("The sum of digits of the number is " + sum);