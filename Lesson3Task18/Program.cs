// Write a programm which takes in number of a quarter and returns the interval of possible x,y meanings.

// 1) Input number of a quarter
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}
// 2) Solving
string QuarterBorderAsk (int numQuarter)
{
    if (numQuarter == 1) return "x > 0, y > 0";
    if (numQuarter == 2) return "x < 0, y > 0";
    if (numQuarter == 3) return "x < 0, y < 0";
    if (numQuarter == 4) return "x > 0, y < 0";
    return "Error";
}
// 3) Output
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int numQuarter = ReadData("Input quarter number: ");

string result = QuarterBorderAsk(numQuarter);

PrintResult("X,Y: " + result);