// Write a programm which takes in a number and returns the number of digits in it.

// 1) Input
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

// 2) Solving

int NumDigits(int num)
{
    int count = 0;
    
    while (num > 0)
    {
        count++;
        num = num / 10;
    }
    return count;
}

// 3) Output
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int inputNumber = ReadData("Input a number: ");

int numberOfDigits = NumDigits(inputNumber);

PrintResult("This number has " + numberOfDigits + " digits.");