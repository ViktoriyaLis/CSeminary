/*
Напишите программу, принимает число и выдает количество цифр в числе.
546 - 3
78 - 2
89562 - 5
*/
int GetUserData (string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse (Console.ReadLine()!);
    return UserData;
}
int getNumberOfDigit(int number)
{
    int numberOfDigit = 0;
    while (number>0)
    {
        number = number / 10;
        numberOfDigit ++;
    }
    return numberOfDigit;
}
void showData (string messageStart, int data)
{
    Console.Write(messageStart);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(data);
    Console.ResetColor();
}
int number = GetUserData ("Введите число");
int numberOfDigit = getNumberOfDigit(number);
showData ($"В числе {number} = ", numberOfDigit);