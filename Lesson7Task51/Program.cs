// Generate a 2D-array and find the sum of the elements on the main diag.

// 1) Console input
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

// 2) 2D-array generation
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

// 3) 2D-array output
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

// 4) Result Output
void DataOutput(string msg)
{
    Console.WriteLine(msg);
}

// 5) Solving
int MainDiagSum(int[,] mtx)
{
    int res = 0;
    int min = mtx.GetLength(0);
    if(min > mtx.GetLength(1)) min = mtx.GetLength(1);
    for(int i = 0; i < min; i++)
    {
        res = res + mtx[i,i];
    }
    return res;
}

int row = ReadData("Enter the number of rows: ");
int column = ReadData("Enter the number of columns: ");

int[,] arr2D = Fill2DArray(row, column, 100, 10);
Print2DArray(arr2D);
int result = MainDiagSum(arr2D);
DataOutput("Sum: " + result);