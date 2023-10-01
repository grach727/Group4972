// Find the multiple of numbers in a 1D array. *First - last, second - second to last ...*

// 1) Generating a single-row array
int[] GenArr(int len)
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(0, 1340);
    }
    return arr;
}

// 2) Converting array
int[] ConvertArr(int[] arr)
{
    int[] outArr = new int[arr.Length / 2];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        outArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }

    return outArr;
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

int[] array = GenArr(6);

PrintArray(array);

int[] multArr = ConvertArr(array);

PrintArray(multArr);
