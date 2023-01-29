// Задайте двумерный массив, заполненный случайными вещественными числами
// m = 3, n = 4.
//1 4 8 19
//5 -2 33 -2
//77 3 8 1
int GetUserData (string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse (Console.ReadLine()!);
    return UserData;
}
/*void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();
}
*/
double [,] get2DDoubleArray(int colLength, int rowLength, int start, int finish)
{
    double [,] array = new double[colLength,rowLength];
    for (int i = 0; i < colLength; i++)
    {   
        for (int j = 0; j < rowLength; j++)
        {
            array[i,j] = (double)new Random().Next(start, finish+1)+Math.Round(new Random().NextDouble(),2);
        }
    }
    return array;
}
void print2DArray (double[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " \t");
        }
        Console.WriteLine();
    }
}
int m = GetUserData ("Введите количество строк");
int n = GetUserData ("Введите количество стобцов");
double[,]array = get2DDoubleArray(m,n,0,100);
print2DArray(array);