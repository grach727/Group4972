// Write a programm which takes in three numbers and checks if a triangle with such sides can exist.

// 1) Input
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

// 2) Output
void DataOutput(string msg)
{
    Console.WriteLine(msg);
}

// 3) Solving
bool TriangleTest(int a, int b, int c)
{
    bool res = true;
    if (a + b < c) res = false;
    if (b + c < a) res = false;
    if (a + c < b) res = false;
    return res;
}

int A = ReadData("Enter the first number: ");
int B = ReadData("Enter the second number: ");
int C = ReadData("Enter the third number: ");

bool result = TriangleTest(A, B, C);

DataOutput("It is " + result + " that such triangle can exist.");
