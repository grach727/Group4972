// Print a 3-digit number and then print the same number without 2nd digit.

int num = new Random().Next(100, 1000);

Console.WriteLine(num);

int digit1 = num / 100;
int digit2 = num % 10;

int newNum = digit1 * 10 + digit2;

Console.WriteLine(newNum);