// Make a an array of 123 random numbers. Find how many of them lie between 10 and 99.

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

// 2) Solving
int CountElm(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i] >= 10) && (arr[i] <= 99))
        {
        count++;
        }
    }
    
    return count;
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

// 4) Output
void DataOutput(string msg)
{
    Console.WriteLine(msg);
}

int[] array = GenArr(123);

PrintArray(array);

int elemCounter = CountElm(array);

DataOutput("Search result: " + elemCounter);