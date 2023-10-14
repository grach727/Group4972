// Create a frequency dictionary

// 1) 2D-array generation
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int lowBorder)
{
    System.Random rnd = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for(int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i,j] = rnd.Next(lowBorder, topBorder);
        }
    }
    return array2D;
}

// 2) 2D-array output
void Print2DArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

// 3) Frequency dictionary
int[] FreqDict(int[,] arr, int len)
{
    int[] dic = new int[len];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 1 + i; j < arr.GetLength(0); j++)
        {
            dic[arr[i,j]]++;
        }
    }
    return dic;
}

// 4) Array Output

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int[,] arr2D = Fill2DArray(10, 10, 10, 1);
Print2DArray(arr2D);

int[] freqDict = FreqDict(arr2D, 10);
PrintArray(freqDict);