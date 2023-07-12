//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
int number = new Random().Next(100, 1000);
Console.WriteLine("Рандомное число: " + number);
int theSecondFigure = number / 10;
theSecondFigure %=  10;
Console.WriteLine($"Вторая цифра, числа {number} - {theSecondFigure}");

