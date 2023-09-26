// Write a programm which takes in a number and returns the sum of the digits of this number.

// 1) Input a, b
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

// 2) Solving
int DigitSum(int num)
{
    int  result = 0;
    while (num > 0)
    {
        result = result + num % 10;
        num = num / 10;
    }
    return result; 
}

// 3) Output
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int number = ReadData("Enter a number: ");

int sumOfDigits = DigitSum(number);

PrintResult("The sum of digits of the number is " + sumOfDigits + ".");
