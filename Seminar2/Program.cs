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
    if(99 < num & num <= 999)
    {
        int a = num % 10;
        return a;
    }
    else
    {
        if(num >= 1000 & num <= 9999)
        {
            int b = (num % 100) / 10;
            return b;
        }
        else
        {
            if(num >= 10000 & num <= 99999)
            {
                int c = (num % 1000) / 100;
                return c;
            }
            else
            {
                int d = 0;
                return d;
            }
        }
    }
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
