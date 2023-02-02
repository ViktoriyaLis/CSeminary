// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9
int GetUserData (string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse (Console.ReadLine()!);
    return UserData;
}
int getSumOfDigit(int number)
{
    if (number==0)
    {
        return 0;
    }
    return number % 10 + getSumOfDigit(number/10);
}
int number = GetUserData("Введите число");
int result = getSumOfDigit(number);
Console.WriteLine(result);