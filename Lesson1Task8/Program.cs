Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine()??"0");

int i = 0;

while (i < number)
{
    if (i % 2 == 0 && i > 1)
        Console.Write(i + ", ");
    i++;
}

Console.Write(number);