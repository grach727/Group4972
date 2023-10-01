// Write a programm which finds out if there is a desired number in an array.

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

// 3) Input element
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

// 4) Output
void DataOutput(string msg)
{
    Console.WriteLine(msg);
}

// 5) Finding element
int FindElm(int[] arr, int elm)
{
        for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == elm)
        {
            return i;
        }
    }
    return -1;
}

int[] array = GenArr(12, -10, 10);

PrintArray(array);

int userElement = ReadData("Input element number: ");

int findElement = FindElm(array, userElement);

DataOutput("Search result: " + findElement);