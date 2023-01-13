// Напишите программу, принимает число (А) и выдает сумму чисел от 1 до А
// 7 - 28, 4 - 10, 8 - 36
int GetUserData (string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse (Console.ReadLine()!);
    return UserData;
}

int getSumOfRange(int start, int end)
{
    int sum = 0;
    for (int i = start; i <= end; i++)
    {
        sum += i;
    }
    return sum;
}
void showData (string messageStart, int data)
{
    Console.Write(messageStart);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(data);
    Console.ResetColor();
}
int end = GetUserData ("Введите число А для получения суммы");
int sum = getSumOfRange(1,end);
showData($"Сумма чисел от 1 до {end} = ",sum);