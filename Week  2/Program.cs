using System;

Console.WriteLine("Enter your age: ");

string userAge = Console.ReadLine();

int userAgeNum = 0;

bool isageNumber = int.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {isageNumber}. User is {userAgeNum} years old");

if (isageNumber)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram.");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram.");
    }
}
else
{
    Console.WriteLine("Could not read your age");
}