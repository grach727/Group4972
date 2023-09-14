// Write a programm which takes in a number and checks if it is a weekend or not.

Console.WriteLine("Enter a number: ");
int num = int.Parse(Console.ReadLine()??"0");

var daysOfWeek = new Dictionary<int, string>()
{
    [1] = "Monday",
    [2] = "Tuesday",
    [3] = "Wednesday",
    [4] = "Thursday",
    [5] = "Friday",
    [6] = "Saturday",
    [7] = "Sunday"
};

switch(num)
{
    case < 1:
    case > 7:
        Console.WriteLine("There are 7 days in a week!");
        break;
    
    case 1:
        Console.WriteLine(daysOfWeek[1] + " is a weekday.");
        break;

    case 2:
        Console.WriteLine(daysOfWeek[2] + " is a weekday.");
        break;
    
    case 3:
        Console.WriteLine(daysOfWeek[3] + " is a weekday.");
        break;
    
    case 4:
        Console.WriteLine(daysOfWeek[4] + " is a weekday.");
        break;

    case 5:
        Console.WriteLine(daysOfWeek[5] + " is a weekday.");
        break;

    case 6:
        Console.WriteLine(daysOfWeek[6] + " is a weekend.");
        break;

    case 7:
        Console.WriteLine(daysOfWeek[7] + " is a weekend.");
        break;
}
