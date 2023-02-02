// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5 -> "1, 2, 3, 4, 5"
//M = 4; N = 8 -> "4, 6, 7, 8"
int GetUserData (string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse (Console.ReadLine()!);
    return UserData;
}
string getStrRange(int start,int finish)
{
    if (start==finish)
    {
        return start + "";
    }
    return start + ", "+ getStrRange(start +1,finish);
}
int userNumberStart = GetUserData("Введите значение начала ряда");
int userNumberFinish = GetUserData("Введите значение границы ряда");
string range = getStrRange(userNumberStart,userNumberFinish);
Console.WriteLine(range);