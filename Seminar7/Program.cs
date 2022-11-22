// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreaterRandom2Array (int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double [rows, columns];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
            array[i, j] = Math.Round(array[i, j], 2);
        }
    }

    return array;
}

void Show2Array (double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число строк: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreaterRandom2Array (r, c, min, max);

Show2Array(myArray);




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreaterRandom2Array (int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int [rows, columns];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return array;
}

void Show2Array (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число строк: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreaterRandom2Array (r, c, min, max);

Show2Array(myArray);

void ShowNumber (int rows, int columns, int [,] array)
{
    int i = rows;
    int j = columns;
    int res = 0;
    if (i < array.GetLength(0) && j < array.GetLength(1))
    {
        res = array[i, j];
        Console.Write($"Значение элемента на интересующей позиции равно: {res}");
    }
    else
    {
        Console.Write("Значение элемента на интересующей позиции отсутствует");
    }
}

Console.Write("Введите позицию строки элемента: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца элемента: ");
int c1 = Convert.ToInt32(Console.ReadLine());

ShowNumber(r1, c1, myArray);
*/




// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] CreaterRandom2Array (int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int [rows, columns];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return array;
}

void Show2Array (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SumColumns (int [,] array)
{
    Console.Write("Среднее арифметическое элементов в каждом столбце: ");
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array [i, j];
        }
        sum = sum / array.GetLength(0);
        sum = Math.Round(sum, 2);
        Console.Write(sum + " ");
    } 
}

Console.Write("Введите число строк: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreaterRandom2Array (r, c, min, max);

Show2Array(myArray);
Console.WriteLine();
SumColumns(myArray);
*/