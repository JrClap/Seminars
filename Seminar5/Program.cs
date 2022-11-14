//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int [] CreaterRandomArray (int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    } 
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int CountNumbers (int [] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            count++;
    }
    return count;
}

Console.Write("Input a number of elemets: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreaterRandomArray(size);
ShowArray(myArray);

Console.Write($"Количество чётных чисел: {CountNumbers(myArray)}");
*/





//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int [] CreaterRandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue +1);
    } 
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int OddNumbers (int [] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i= i + 2)
    {
        sum = sum + array [i]; 
    }
    return sum;
}

Console.Write("Input a number of elemets: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min number of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max number of array: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreaterRandomArray(size, min, max);
ShowArray(myArray);

Console.Write($"Cумма элементов, стоящих на нечётных позициях: {OddNumbers(myArray)}");
*/





//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double [] CreaterRandomArray (int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue +1) + new Random().NextDouble();
        array[i] = Math.Round(array[i], 2);
    } 
    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double MaxNumbers (double [] array)
{
    double max = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
            max = array [i];
    }
    return max;
}

double MinNumbers (double [] array)
{
    double min = MaxNumbers(array);
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
            min = array [i];
    }
    return min;
}

double DifferenceNumbers (double [] array)
{
    double dif = MaxNumbers(array) - MinNumbers(array);
    return dif;
}

Console.Write("Input a number of elemets: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min number of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max number of array: ");
int max = Convert.ToInt32(Console.ReadLine());

double [] myArray = CreaterRandomArray(size, min, max);
ShowArray(myArray);

Console.Write($"Максимальное значение равно: {MaxNumbers(myArray)}, а минимальное равно: {MinNumbers(myArray)}, а разница равна {DifferenceNumbers(myArray)}");
*/