// Write a programm which returns an array filled with 8 numbers and prints it.

// 1) Input
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

// 2) Generating an array

int[] ArrayGen(int length)
{
    int[] array = new int[length];
    Random rndm = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rndm.Next(0,10);
    }
    return array;
}

// 3) Array Output

void ArrayPrint (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

int lengthOfArray = ReadData("Input length of an array: ");
int[] rndmArray = ArrayGen(lengthOfArray);
ArrayPrint(rndmArray);