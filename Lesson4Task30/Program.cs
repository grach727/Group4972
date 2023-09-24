// Write a programm which returns an array of 8 numbers, randomly filled with 0 and 1.

// 1) Input
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

// 2) Generating an array

int[] GenArr(int len)
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(0,2);
    }
    return arr;
}

// 3) Array Output

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int lengthOfArray = ReadData("Input length of an array: ");
int[] array = GenArr(lengthOfArray);
PrintArray(array);