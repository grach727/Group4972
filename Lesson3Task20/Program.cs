// Write a programm which takes in two points and returns the distance between them.

// 1) Input coordinates of the points
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

// 2) Solving
double Length(int x1, int x2, int y1, int y2)
{
    double lengthXY = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
    return lengthXY;
}

// 3) Output
void DataOutput(string msg)
{
    Console.WriteLine(msg);
}

int x1 = ReadData("Input X1: ");
int y1 = ReadData("Input Y1: ");
int x2 = ReadData("Input X2: ");
int y2 = ReadData("Input Y2: ");

double result = Length(x1, x2, y1, y2);

DataOutput("Length is: " + result);