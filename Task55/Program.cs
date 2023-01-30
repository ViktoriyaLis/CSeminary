// See https://aka.ms/new-console-template for more information
int [,] get2DArray(int colLength, int rowLength, int start, int finish)
{
    int [,] array = new int[colLength,rowLength];
    for (int i = 0; i < colLength; i++)
    {   
        for (int j = 0; j < rowLength; j++)
        {
            array[i,j] = (int)new Random().Next(start, finish+1);
        }
    }
    return array;
}

void printInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}
void printHeadOfArray(int length)
{
    Console.Write(" \t");
    for (int i = 0; i < length; i++)
    {   
        printInColor(i + "\t", ConsoleColor.DarkGreen);
    }
    Console.WriteLine();
}
void printArray(int [,] array)
{
    printHeadOfArray(array.GetLength(1));
    for (int i =0; i<array.GetLength(0);i++)
    {
        printInColor(i + "|\t",ConsoleColor.DarkCyan);
        for (int j = 0; j<array.GetLength(1);j++)
        {
            Console.Write(array[i,j]+ "\t");
        }
        Console.WriteLine();
    }
}
int getDataFromUser (string message)
{
    printInColor(message + "\n",ConsoleColor.Yellow);
    int data = int.Parse(Console.ReadLine()!);
    return data;
}
// Проверка:можем ли мы вообще перевернуть массив(одинаковое ли кол-во стобцов и строк)
bool CheckCanRotate(int rows,int cols)
{
    return rows == cols;
}

int [,] rotateMatrix (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            int temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
    }
    return array;
}

int rows = getDataFromUser("Введите количество строк");
int cols = getDataFromUser("Введите количество колонок");
bool canContinue = CheckCanRotate(rows,cols);
if (canContinue)
{
    int[,]array = get2DArray(rows,cols,0,50);
    printArray(array);
    int[,] rotatedArray = rotateMatrix(array);
    printArray(rotatedArray);
}
else
{
    printInColor($"Для переворота нужна квадратная матрица, Вы ввели [{rows}:{cols}]",ConsoleColor.Red);
}
