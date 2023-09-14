// Write a programm which takes in two numbers and returns either "OK" if one number is multiple of another or the remainer of division.

int numA = int.Parse(Console.ReadLine()?? "0");
int numB = int.Parse(Console.ReadLine()?? "0");

int divResult = numA % numB;

Console.WriteLine((divResult == 0) ? ("OK") : (divResult));