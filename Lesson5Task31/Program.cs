// Write a programm which generates a single-row array filled with numbers from -9 to 9 and returns the sum of  positive and negative numbers.

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

// 3) Neg and Pos Sum

(int, int) NegPosSum(int[] arr)
{
    int posSum = 0;
    int negSum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            posSum = posSum + arr[i];
        }
        else
        {
            negSum += arr[i];
        }
    }
    return (posSum, negSum);
}

int[] array = GenArr(12, -9, 9);
PrintArray(array);
(int pos, int neg) sum = NegPosSum(array);

Console.WriteLine("Sum positive: " + sum.pos + "; Sum negative: " + sum.neg);