// Create an array of real numbers. Find the difference between the max and min element.

// 1) Generating a single-row array
double[] GenArr(int len)
{
    double[] arr = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next();
    }
    return arr;
}

// 2) Array Output
void PrintArray (double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// 3) Maximum search

double MaxElem(double[] arr)
{
    double max = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

// 4) Minimum search

double MinElem(double[] arr)
{
    double min = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

// 5) Output
void DataOutput(string msg)
{
    Console.WriteLine(msg);
}

double[] array = GenArr(9);

PrintArray(array);

double maxNum = MaxElem(array);

double minNum = MinElem(array);

double diffMaxMin = maxNum - minNum;

DataOutput("The difference between max and min element is " + diffMaxMin + ".");