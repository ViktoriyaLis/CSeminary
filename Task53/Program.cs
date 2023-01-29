/*Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
*/
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

int [,] swapRows(int [,] array, int row1, int row2)
{
    for (int i =0; i<array.GetLength(0);i++)
    {
        int temp = array[i,row1];
        array[i,row1] = array[i,row2];
        array[i,row2] = temp;
    }
    return array;
}

int[,]array = get2DArray(5,3,-10,100);
printArray(array);
int[,] swappedArray = swapRows(array,0,array.GetLength(1) - 1);
printArray(swappedArray);
