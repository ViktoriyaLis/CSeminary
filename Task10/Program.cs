// Нап прогр, котора выводит случайное число из отрезка (10,99) и показывает наибольшую цифру числа

int GetNumberFromRange(int start, int end)
{
    int number = new Random().Next(start,end + 1);
    return number;
}
int GetMaxDigit(int number)
{
    int max = number % 10;    // последнее число в цифре как макс
    int digit2 = number / 10;
    
    if (max < digit2)
    {
        max = digit2;
    }
    return max;
}

int RandomNumber = GetNumberFromRange(10,99);
int maxDigit = GetMaxDigit(RandomNumber);
Console.WriteLine ($" Для числа {RandomNumber} максимальной цифрой в числе является {maxDigit}");