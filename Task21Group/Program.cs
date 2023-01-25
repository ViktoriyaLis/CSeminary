// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
int getUserValue (string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

double getDistaseCoordinat(int userAx, int userAy, int userBx, int userBy)
{
    double result = Math.Sqrt(Math.Pow((userAx-userBx),2) + Math.Pow((userAy-userBy),2));
    return result;
}

int userAx = getUserValue("Введите X");
int userAy = getUserValue("Введите Y");
int userBx = getUserValue("Введите X");
int userBy = getUserValue("Введите Y");

double distanse = getDistaseCoordinat(userAx,userAy,userBx,userBy);
Console.WriteLine($"Расстояние = {Math.Round(distanse,2)}");