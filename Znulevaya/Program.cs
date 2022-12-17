// Программа принимает число и выдает его квадрат

Console.Clear();

Console.WriteLine("Введите число");
int number = int.Parse (Console.ReadLine()!);
int q = number * number ;

Console.WriteLine ($"Квадрат числа {number} равен {q}");
