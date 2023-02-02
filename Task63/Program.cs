// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"         
int GetUserData (string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse (Console.ReadLine()!);
    return UserData;
}
void printRange(int N)
{
    if (N==0)
    {
        return;
    }
    printRange(N-1);
    Console.Write(N + ", ");
}
int userNumber = GetUserData("Введите число");
printRange(userNumber);