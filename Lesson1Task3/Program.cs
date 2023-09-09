Console.WriteLine("Enter the number of a day of the week: ");
int day = int.Parse(Console.ReadLine()??"0");

string[] DayOfTheWeek = new string[7];

DayOfTheWeek[0] = "Monday";
DayOfTheWeek[1] = "Tuesday";
DayOfTheWeek[2] = "Wednesday";
DayOfTheWeek[3] = "Thursday";
DayOfTheWeek[4] = "Friday";
DayOfTheWeek[5] = "Saturday";
DayOfTheWeek[6] = "Sunday";

Console.WriteLine(DayOfTheWeek[day-1]);
