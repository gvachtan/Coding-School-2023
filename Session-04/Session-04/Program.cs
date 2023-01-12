// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

// Exercise One

Console.WriteLine("Hello " + " " + "Giorgos");


// Exercise Two
int num_1 = 36;
int num_2 = 4;
int sum = num_1 + num_2;
int division = num_1 / num_2;

Console.WriteLine("The sum of " + num_1 + " and " + num_2 + " is: " + sum);
Console.WriteLine("The division of " + num_1 + " and " + num_2 + " is: " + division);


// Exercise Three

int num1 = -1;
int num2 = 5;
int num3 = 6;
int num4 = 7;
int num5 = 14;
int num6 = -3;
int num7 = 13;
int num8 = 6;
int num9 = 9;
int mod = num2 % num4;
int result1 = num1 + num2 * num3;
int result2 = 38 + (num2 * mod);
int result3 = num5 + ((num6 * num3) / num4);
int result4 = 2 + (num7 / num8) * num3 + (int)Math.Sqrt(num4);
double result5 = (Math.Pow(num3, 4) + Math.Pow(num2, 7)) / (num9 * (num2 % num4));
Console.WriteLine("The result of -1 + 5 x 6 is: " + result1);
Console.WriteLine("The result of 38 + (5 x (mod7)) is: " + result2);
Console.WriteLine("The result of 14 + ((-3 x 6)/7) is: " + result3);
Console.WriteLine("The result of 2 + (13/6) x 6 + sqrt(7) is: " + result4);
Console.WriteLine("The result of (6^4 + 5^7)/(9 x (mod4)) is: " + result5);


// Exercise Four

int age = 32;
string gender = "male";
Console.WriteLine("You are " + gender + " and look younger than " + age + ".");


// Exercise Five

int seconds = 45678;
int minutes = seconds / 60;
int hours = minutes / 60;
int days = hours / 24;
int years = days / 365;
Console.WriteLine(seconds + " seconds is equivalent to:");
Console.WriteLine(minutes + " minutes");
Console.WriteLine(hours + " hours");
Console.WriteLine(days + " days");
Console.WriteLine(years + " years");


// Exercise Six

int secs = 45678;
TimeSpan timeSpan = TimeSpan.FromSeconds(secs);
Console.WriteLine(secs + " seconds is equivalent to:");
Console.WriteLine(timeSpan.Minutes + " minutes");
Console.WriteLine(timeSpan.Hours + " hours");
Console.WriteLine(timeSpan.Days + " days");
Console.WriteLine(timeSpan.TotalDays / 365 + " years");


// Exercise Seven

double celsius = 25.0;
double kelvin = celsius + 273.15;
double fahrenheit = celsius * (9.0 / 5.0) + 32;

Console.WriteLine(celsius + " degrees Celsius is equivalent to:");
Console.WriteLine(kelvin + " degrees Kelvin");
Console.WriteLine(fahrenheit + " degrees Fahrenheit");