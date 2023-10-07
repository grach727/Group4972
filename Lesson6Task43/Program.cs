// Write a programm which calculates the intersection point of two functions y1 = k1 * x1 + b1; y2 = k2 * x2 + b2.

// 1) Console input
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

// 2) Finding functions intersection

(double x, double y) FuncIntersect(double k1, double b1, double k2, double b2)
{
   double X1 = (b2 - b1) / (k1 - k2);
   double Y1 = (k1 * b2 - k2 * b1) / (k1 - k2);
   return (X1, Y1);
}

// 4) Result Output
void DataOutput(string msg)
{
    Console.WriteLine(msg);
}

double k1 = ReadData("Enter K1: ");
double b1 = ReadData("Enter B1: ");
double k2 = ReadData("Enter K2: ");
double b2 = ReadData("Enter B2: ");

(double x, double y) intersectionPoint = FuncIntersect(k1, b1, k2, b2);

double iX = intersectionPoint.x;
double iY = intersectionPoint.y;

DataOutput("The y1(x) and y2(x) intersection point coordinates are: " + "[" + iX + ", " + iY + "].");