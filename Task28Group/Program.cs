/*Напишите программу, принимает число N и выдает произведение чисел от 1 до N
4 - 24
5 - 120
*/
int GetUserData (string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse (Console.ReadLine()!);
    return UserData;
}
int GetMultiplic(int start, int end)
{
    int multi = 1;
    for (int i = 1; i<= end; i++)
    {
        multi = multi * i;
    }
    return multi;
}

int num = GetUserData("Введите число");
int result = GetMultiplic(1, num);
Console.WriteLine($"Произведение чисел от 1 до {num} = {result}");