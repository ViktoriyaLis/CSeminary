// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
//от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4
int getUserValue (string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int N = int.Parse(Console.ReadLine()!);
int i = 1;
while (i<=N)
{
      
    Console.Write(Math.Pow(i,2) + ",");
    i++;
}