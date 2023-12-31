﻿// Write a programm which finds the positive elements of a 2D-array and substitute them with their squares.

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

// 4) Solving
void Update2DArray(int[,] mtrx)
{
    for(int i = 0; i < mtrx.GetLength(0); i = i + 2)
    {
        for(int j = 0; j < mtrx.GetLength(1); j = j + 2)
        {
            mtrx[i,j] = mtrx[i,j] * mtrx[i,j];
        }
    }
}

int row = ReadData("Enter the number of rows: ");
int column = ReadData("Enter the number of columns: ");

int[,] arr2D = Fill2DArray(row, column, 100, 10);
Print2DArray(arr2D);
Update2DArray(arr2D);
Print2DArray(arr2D);