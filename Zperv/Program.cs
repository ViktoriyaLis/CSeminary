// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

Console.Clear();

Console.WriteLine ("Введите первое число");
int numberA = int.Parse (Console.ReadLine ()!);
Console.WriteLine ("Введите второе число");
int numberB = int.Parse (Console.ReadLine ()!);
if (numberA == numberB * numberB)
{
    Console.WriteLine ($"Да, {numberA} является квадратом {numberB}");
}   
else
{
    Console.WriteLine ($"Нет, {numberA} НЕ является квадратом {numberB}");
}