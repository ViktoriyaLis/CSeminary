// по заданному номеру четверти показ диапазон возможных координат в этой четверти (x и y)

int getUserValue (string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
string getRangeFromQuater(int quarter)
{
    string result = $"Диапазон значений в {quarter} четверти";
    switch (quarter)
    {
        case 1:
        {
            result += " x>0 и y >0"; // это result=result+"x>0 и y >0"
            break;
        }
        case 2:
        {
            result += " x<0 и y >0";
            break;
        }
        case 3:
        {
            result += " x<0 и y <0";
            break;
        }
        case 4:
        {
            result += " x>0 и y <0";
            break;
        }
        default:
        {
            result = $"Четверти {quarter} не существует";
            break;
        }
    }
    return result;
}

int quarter =getUserValue ("Введите номер четверти");
string RangeDiscriptions=getRangeFromQuater(quarter);
Console.WriteLine(RangeDiscriptions);