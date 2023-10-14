// Create a 2D-array of real numbers. Write a programm which deletes the row and column, where they intersect on the minimum element.

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

// 3) Minimum element search

void FindMinElm(int[,] arr, ref int x, ref int y)
{
    int min = arr[0,0];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] < min)
            {
                min = arr[i,j]; x = i; y = j;
            }
        }
    }
}

// 4) Updating 2D element
int[,] Update2DArr(int[,] arr, int x, int y)
{
    int[,] res = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int m = 0;
    int n = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        if(i != x)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j != y)
                {
                    res[m,n] = arr[i,j];
                    n++;
                }
                m++; n = 0;
            }

        }
    }
    return res;
}

int[,] arr2D = Fill2DArray(10, 10, 10, 1);
Print2DArray(arr2D);

int x = -1;
int y = -1;
FindMinElm(arr2D, ref x, ref y);
int[,] outArr = Update2DArr(arr2D, x, y);
Print2DArray(outArr);