// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8

int GetUserData (string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse (Console.ReadLine()!);
    return UserData;
}
int getRaiseDegree(int numberA, int numberB)
{
    if (numberB==1)
    {
        return numberA;
    }
    return numberA * getRaiseDegree(numberA, numberB - 1);
}
int numberA = GetUserData("Введите первое число");
int numberB = GetUserData("Введите второе число");
int result = getRaiseDegree (numberA,numberB);
Console.WriteLine(result);
