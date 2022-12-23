// 12 Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine()); // Int.Parse
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1%num2==0)
{
    Console.WriteLine("Число кратно");
}
else
{
    int Ostatok = num1%num2; 
    Console.WriteLine($"Число {num1}  не кратно {num2}, остаток равен {Ostatok}");
}
