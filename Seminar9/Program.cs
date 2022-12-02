// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Введите положительное число N = ");
int n = Convert.ToInt32(Console.ReadLine());

int m = 1;
if (n < 1)
{
    Console.WriteLine("Ввели не положительное число");
}

int NaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNumber(n, m + 1)} ");
    return m;
}

Console.WriteLine(NaturalNumber(n, m));



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int ShowNumbers(int m, int n)
{
    if(m == n)
        return n;
    return n + ShowNumbers(m, n - 1);
}

Console.Write("Введите число M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N = ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Сумма натуральных чисел = " + ShowNumbers(m, n));
*/



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.WriteLine("Введите два неотрицательных целых числа");
Console.Write("Введите число M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N = ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");
*/