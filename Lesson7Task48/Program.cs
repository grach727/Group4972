// Write a programm which prints a 2D-array, with elements mn = m + n.

// 1) Console input
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

// 2) 2D-array generation
int[,] Fill2DSumInd(int row, int column)
{
    int[,] array2D = new int[row, column];

    for(int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array2D[i,j] = i + j;
        }
    }
    return array2D;
}

// 3) 2D-array output
void Print2DArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " \t");
        }
        Console.WriteLine();
    }
}

int row = ReadData("Enter the number of rows: ");
int column = ReadData("Enter the number of columns: ");

int[,] arr2D = Fill2DSumInd(row, column);
Print2DArray(arr2D);