// Write a programm which counts how many positive numbers were entered by a user.

// 1) Console input
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}


// 2) Array Input
int[] InputArray(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = ReadData("Enter the " + (i + 1) + " element.");
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

// 4) Positive elements counter
int PositiveElementsCounter(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            counter++;
        }
    }
    return counter;
}

// 4) Result Output
void DataOutput(string msg)
{
    Console.WriteLine(msg);
}

int len = ReadData("Enter the number of elements: ");
int[] array = InputArray(len);
PrintArray(array);
DataOutput("The number of positive elements is " + (PositiveElementsCounter(array)) + ".");
