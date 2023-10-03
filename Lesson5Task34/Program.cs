// Write a programm which generates an array of 3-digit positive numbers and returns the number of even elements of an array.

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

int CountEvn(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

// 4) Output
void DataOutput(string msg)
{
    Console.WriteLine(msg);
}

int[] array = GenArr(9);

PrintArray(array);

int evnCounter = CountEvn(array);

DataOutput("There are " + evnCounter + " even numbers in the array.");

// 5) Bubble sort

int temp = 0;

for (int write = 0; write < array.Length; write++) 
{
    for (int sort = 0; sort < array.Length - 1; sort++) 
    {
        if (array[sort] > array[sort + 1]) 
        {
            temp = array[sort + 1];
            array[sort + 1] = array[sort];
            array[sort] = temp;
        }
    }
}

for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");

Console.ReadKey();
