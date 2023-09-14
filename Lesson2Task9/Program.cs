// Print random 2-digit number and then print the biggest digit of this number.

void Variant()
{
Console.WriteLine("Metod #1");

System.Random numberGenerator = new System.Random();
int number = numberGenerator.Next(10,100);
Console.WriteLine(number);

int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit);
}
else
{
    Console.WriteLine(secondDigit);
}
}
/////////////////////////////////////////////////////
void Variant1()
{
Console.WriteLine("Metod #2");

System.Random numberGenerator1 = new System.Random();
int number1 = numberGenerator1.Next(10,100);
Console.WriteLine(number1);

Console.WriteLine((number1 / 10 > number1 % 10) ? (int)(number1 / 10) : (int)(number1 % 10));
}
////////////////////////////////////////////////////
void Variant2()
{
Console.WriteLine("Metod #3");

System.Random numberGenerator = new System.Random();
int number = numberGenerator.Next(10,100);
Console.WriteLine(number);

char[] digitChar = number.ToString().ToCharArray();
Console.WriteLine((int)digitChar[0] > (int)digitChar[1] ? digitChar[0] : digitChar[1]);
}

Variant2();