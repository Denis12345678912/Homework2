//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли  этот день выходным
Console.WriteLine("Введите цифру от 1 - 7, чтобы узнать день недели");
int dayOfWeek = int.Parse(Console.ReadLine());
switch (dayOfWeek)
{
        case 1:
    Console.WriteLine("Сегодня понедельник, вставай на работу");
    break;
      case 2:
    Console.WriteLine("Сегодня вторник, вставай на работу");
    break;
      case 3:
    Console.WriteLine("Сегодня среда, вставай на работу");
    break;
      case 4:
    Console.WriteLine("Сегодня четверг, вставай на работу");
    break;
      case 5:
    Console.WriteLine("Сегодня пятница, вставай на работу");
    break;  
      case 6:
    Console.WriteLine("Выходной, сегодня суббота, спи до обеда");
    break;
      case 7:
    Console.WriteLine("Выходной, сегодня воскресенье, спи до обеда");
    break;
      default:
    Console.WriteLine("Введите цифру от 1 - 7!!!!!");
    break;
}