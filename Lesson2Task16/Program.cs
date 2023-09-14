// Write a programm which takes in two numbers and checks if one number is a square of another.

int numA = int.Parse(Console.ReadLine()?? "0");
int numB = int.Parse(Console.ReadLine()?? "0");

bool test1 = (numA == numB * numB);
bool test2 = (numB == numA * numA);

Console.WriteLine(test1 == true && test2 == false ? "First number is a square of the second" : "Second number is a square of the first");