// Write a programm which flips a 1D-array.

// 1) Generating a single-row array
int[] GenArr(int len)
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }
    return arr;
}

// 2) Array Output
void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int[] SwapNewArray(int[] arr)
{
    int[] outArray = new int[arr.Length];
    
    for(int i = 0; i < arr.Length; i++)
    {
        outArray[arr.Length - 1 - i] = arr[i];
    }
    return outArray;
}

void SwapArray(int[] arr)
{
    int buferElement = 0;

    for(int i = 0; i < arr.Length / 2; i++)
    {
        buferElement = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = arr[i];
        arr[i] = buferElement;
    }
}

int[] array = GenArr(15);

int[] swapArr = SwapNewArray(array);

Console.WriteLine("Base array");

PrintArray(array);

Console.WriteLine("Final array");

PrintArray(swapArr);
///////////////////////////////////
SwapArray(array);

Console.WriteLine("Final array");

PrintArray(array);


