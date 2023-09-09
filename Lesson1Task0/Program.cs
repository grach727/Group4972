// Task #0
// Write a programm which takes in a number
// and returns its square (a number multiplied on itself).

Console.WriteLine("Enter a number");
// Reading data from console
string? inputNum = Console.ReadLine()??"0";
// Checking that data is not null
if(inputNum != null)
{
// Converting the type of data from string to int    
    int num = int.Parse(inputNum);
// Finding the square of a number
    int result = num * num;
// Result output into the console
    Console.WriteLine(result);
}

Console.WriteLine("Square of a number: " +Math.Pow(int.Parse(inputNum),2));