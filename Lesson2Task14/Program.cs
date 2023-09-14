// Write a programm which takes in a number and returns "Yes" if the number is multiple to 7 and 23, otherwise returns "No".

Console.WriteLine("Enter a number: ");

int num = int.Parse(Console.ReadLine()?? "0");

Console.WriteLine(num % 7 == 0 && num % 23 == 0 ? "Yes" : "No");