// Write a programm which converts neg elements to pos and vice versa.

// 1) Generating a single-row array
int[] GenArr(int num, int lowBorder, int highBorder)
{
    int[] arr = new int[num];
    
    for (int i = 0; i < num; i++)
    {
        arr[i] = new Random().Next(lowBorder, highBorder);
    }
    return arr;
}

// 2) Inverting elements of an array
void InversArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * (-1);
    }
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

int[] array = GenArr(12, -10, 10);
PrintArray(array);
InversArray(array);
PrintArray(array);