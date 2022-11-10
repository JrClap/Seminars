//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Degree (int NumA, int NumB)
{
    int sum = 1;
    int current = 0;
    while ( current < NumB)
    {
        sum = sum * NumA;
        current++;
    }
    return sum;
}

Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write($"При возведении числа {a} в степень {b} получим: {Degree(a,b)}");
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Summa (int number)
{
    int sum = 0;
    int current = 0;
    while (number > 0)
    {
        number = number % 10 + ((number / 10) % 10);
        sum = 
        current++;
    }
    return sum;
}

Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write($"Сумма всех чисел в значении {a} равна: {Summa(a)}");
*/
