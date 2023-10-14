// Write a programm which flips (T) matrix.

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

// 3) Test array rotation possibility
bool TestArrayRotation(int[,] matrix)
{
    if (matrix.GetLength(0) == matrix.GetLength(1))
    {
        return true;
    }
    else
    {
        return false;
    }
}

// 4) Rotating 2D Array
void Rotate2DArr(int[,] matrix)
{
    int buf = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1 + i; j < matrix.GetLength(0); j++)
        {
            buf = matrix[i,j];
            matrix[i,j] = matrix[j,i];
            matrix[j,i] = buf;
        }
    }
}

int[,] arr2D = Fill2DArray(10, 10, 10, 1);
Print2DArray(arr2D);
Console.WriteLine("-------------------------------------------------------------------------");
bool test = TestArrayRotation(arr2D);
if (test == true)
{
    Rotate2DArr(arr2D);
    Print2DArray(arr2D);
}
else
{
    Console.WriteLine("Transponation impossible.");
}