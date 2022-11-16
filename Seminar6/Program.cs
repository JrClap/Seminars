// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int[] CreaterArray()
{
    Console.Write("Введите сколько цифр будет в массиве N = ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] a = new int[n];
    for(int i = 0; i < n; i++)
    {
        Console.Write($"A[{i}] = ");
        a[i] = Convert.ToInt32(Console.ReadLine());
    }
    return a;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int AmountNumbers (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            count++;
    }
    return count;
}

int [] MyArray = CreaterArray();

ShowArray(MyArray);

Console.Write($"Количество чисел в массиве больше 0 равно: {AmountNumbers(MyArray)}");
*/



// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
Console.Write("Input b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double CoordinateX = 0;

double CoordinateY = 0;

if (b1 == b2 && k1 == k2)
    Console.WriteLine("Прямые совпадают");
else
    if((b1 * k2 - b2 * k1) == 0)
        Console.WriteLine("Прямые параллельны");
    else
        if((b1 * b2 + k1 * k2) == 0)
            Console.WriteLine("Прямые перпендикулярны");
        else
            CoordinateX = (b2 - b1) / (k1 - k2);
            CoordinateX = Math.Round(CoordinateX, 2);
            CoordinateY = k1 * CoordinateX + b1;
            CoordinateY = Math.Round(CoordinateY, 2);
            Console.WriteLine($"Точка пересечения двух прямых: [{CoordinateX}, {CoordinateY}]");
*/