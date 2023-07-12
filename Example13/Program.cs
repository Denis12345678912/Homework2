//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры не
Console.Write("Введите любой число: ");
int theSecondFigure = int.Parse(Console.ReadLine());
int number = theSecondFigure;
if(theSecondFigure < 100)
{
    Console.WriteLine($"Число: {theSecondFigure} - не имеет третьей цифры");
}
if(theSecondFigure>=1000 )
{
while(theSecondFigure>=1000)
{
theSecondFigure /=10;
}
while(theSecondFigure > 9)
{
theSecondFigure%=10;
}
 Console.WriteLine($"Третья цифра {theSecondFigure} числа - {number}");
}
if(theSecondFigure >=100 && theSecondFigure <=999)
{
    theSecondFigure%=100;
     theSecondFigure%=10;
    Console.WriteLine($"Третья цифра {theSecondFigure} числа - {number}");
}