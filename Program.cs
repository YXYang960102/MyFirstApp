// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

var name = "jeremy";
int age = 19;
Console.WriteLine($"Hello, my name is {name} and I am {age} years old.");
Console.WriteLine($"I'm a student!");

Console.WriteLine("What is your name?");
var userName = Console.ReadLine();
Console.WriteLine($"Hello, {userName}! Nice to meet you.");

Console.WriteLine("What is your age?");
var userAgeInput = Console.ReadLine();
int userAge = int.Parse(userAgeInput);
Console.WriteLine($"You are {userAge} years old.");
