// Write a programm whick returns all natural numbers from N to 1.

// 1) Console input
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

// 2) Solving
void GenLineRec(int num)
{
    Console.Write(num + " ");
    if (num <= 1)
    {

    }
    else
    {
    GenLineRec(num - 1);
    }
}

int number = ReadData("Enter number N: ");
GenLineRec(number);