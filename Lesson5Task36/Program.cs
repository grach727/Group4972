// Create a 1D-array of random numbers and compute the sum of odd elements.

// 1) Generating a single-row array
int[] GenArr(int len)
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(99, 1000);
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

// 3) Solving

int SumOddPos(int[] arr)
{
    int sum = 0;
    for(int i = 1; i < arr.Length; i++)
    {
        sum = sum + arr[i];
    }
    return sum;
}

// 4) Output
void DataOutput(string msg)
{
    Console.WriteLine(msg);
}

int[] array = GenArr(9);

PrintArray(array);

int oddSum = SumOddPos(array);

DataOutput("The sum of all odd elements is " + oddSum + ".");