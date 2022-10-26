// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int numbers (int num)
{
    int a = num / 10;
    int b = a % 10;
    return b;
}

Console.Write("Введите любое 3-х значное число - ");
int num = Convert.ToInt32(Console.ReadLine());

int result = numbers (num);

Console.WriteLine($"New version of a numbers {num} number in the middle {result}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int numbers (int num)
{
    int count = 0;
    int res = 0;
    while (count < 7)
    {
        if(num > 99 && num < 1000)
        {
            res = num % 10;
            break;
        }
        else
        {
            num = num / 10;
        }
        count++;
    }
    return res;
}

Console.Write("Введите положительное число - ");
int num = Convert.ToInt32(Console.ReadLine());

int result = numbers (num);

Console.WriteLine($"The third digit {result} from the number is {num}");
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool day (int num)
{
    if(num == 6 || num == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Введите число обозначающее день недели - ");
int num = Convert.ToInt32(Console.ReadLine());

bool result = day (num);

Console.WriteLine($"Is the day of the week entered - {num} a weekday off? - {result}");
*/

// Задача 15: Через string, а не bool.
/*
string day (int num)
{
    if(num == 6 || num == 7)
    {
        return "DayOff";
    }
    else
    {
        return "WorkingDay";
    }
}

Console.Write("Введите число обозначающее день недели - ");
int num = Convert.ToInt32(Console.ReadLine());

string result = day (num);

Console.WriteLine($"Is the day of the week entered - {num} a weekday off? - {result}");
*/
