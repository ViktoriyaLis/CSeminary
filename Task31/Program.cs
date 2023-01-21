/*Задайте массив из 12 элементов, заполненными случ числами из промежутка (-9,9) Найдите сумму отрицательных чисел и положительных чисел в массиве
*/
int [] generateArray (int length, int start, int end)
{
    int [] result = new int [length];
    for (int i = 0; i<length; i++)
    {
        result [i] = new Random().Next(start,end+1);
    }
    return result;
}
int getSumOfPositiveOrNegative (int [] array, int flag = 1)
{
    int sum = 0;
    for (int i =0; i < array.Length; i++)
    {
        if (array[i] * flag > 0)
        {
            sum+=array [i];
        }
    }
    return sum;
}

void printArray(int[]array)
{
    Console.Write("[");
    for (int i = 0; i< array.Length; i++)
    {
        Console.Write(array[i]);
        if (i<array.Length-1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
int[] array = generateArray(10,-9,9);
int sumOfPositive = getSumOfPositiveOrNegative(array,1);
int sumOfNegative = getSumOfPositiveOrNegative(array,-1);
printArray(array);
Console.WriteLine($"Сумма положительных чисел в массиве равна {sumOfPositive}");
Console.WriteLine($"Сумма отрицательных чисел в массиве равна {sumOfNegative}");