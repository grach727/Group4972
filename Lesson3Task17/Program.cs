// Write a programm which takes in two coordinates of a point and returns the number of a quarter where this point is situated.


// 1) Input X,Y
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}
// 2) Solving
int QuarterTest(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}
// 3) Output
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int x = ReadData("Input X coordinate: ");
int y = ReadData("Input Y coordinate: ");

int res = QuarterTest(x,y);

PrintResult("Point is in a quarter # " + res);