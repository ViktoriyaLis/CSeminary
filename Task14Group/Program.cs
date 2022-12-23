// 14 Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23,н-р 150 и 161

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine()); // Int.Parse
 
if (num % 7 == 0 && num % 23 == 0)     //&& если оба true, || - или один из
{
    Console.WriteLine("Число кратно");
}
else
{
        Console.WriteLine($"Число {num}  не кратно 7 и 23");
}

