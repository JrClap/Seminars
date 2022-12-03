// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write("Введите число строк: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

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

int[,] myArray = CreaterRandom2Array (r, c, min, max);
Show2Array(myArray);

void OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

Console.WriteLine("Отсортированный массив");
OrderArrayLines(myArray);
Show2Array(myArray);




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
Console.Write("Введите число строк: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

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

int[,] myArray = CreaterRandom2Array (r, c, min, max);
Show2Array(myArray);

int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int MinSumLine = 0;
int sumLine = SumLineElements(myArray, 0);
for (int i = 1; i < myArray.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(myArray, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    MinSumLine = i;
  }
}

Console.WriteLine($"{MinSumLine+1} - строкa с наименьшей суммой элементов, равная = {sumLine}");
*/



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
Console.WriteLine($"Введите размеры матриц и диапазон случайных значений:");
Console.Write("Введите число строк для двух матриц: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов для двух матриц: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] CreaterRandom2Array (int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int [rows, columns];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(1, maxValue + 1);
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

int[,] myArray1 = CreaterRandom2Array (r, c, min, max);
int[,] myArray2 = CreaterRandom2Array (r, c, min, max);
Console.WriteLine("Первая матрица");
Show2Array(myArray1);
Console.WriteLine("Вторая матрица");
Show2Array(myArray2);

int[,] ResultArray = new int[r,c]; 

void MultiplyMatrix (int[,] myArray1, int[,] myArray2, int[,] ResultArray)
{
  for (int i = 0; i < ResultArray.GetLength(0); i++)
  {
    for (int j = 0; j < ResultArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < myArray1.GetLength(1); k++)
      {
        sum += myArray1[i,k] * myArray2[k,j];
      }
      ResultArray[i,j] = sum;
    }
  }
}

MultiplyMatrix(myArray1, myArray2, ResultArray);
Console.WriteLine("Произведение первой и второй матриц:");
Show2Array(ResultArray);
*/



// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
Console.WriteLine("Введите размер массива X x Y x Z:");

Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] Create3Array = new int[x, y, z];
CreateArray (Create3Array);
WriteArray (Create3Array);

void WriteArray (int[,,] Create3Array)
{
  for (int i = 0; i < Create3Array.GetLength(0); i++)
  {
    for (int j = 0; j < Create3Array.GetLength(1); j++)
    {
      Console.Write($"");
      for (int k = 0; k < Create3Array.GetLength(2); k++)
      {
        Console.Write($"({i},{j},{k}) {Create3Array[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] Create3Array)
{
  int[] temp = new int [Create3Array.GetLength(0) * Create3Array.GetLength(1) * Create3Array.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < Create3Array.GetLength(0); x++)
  {
    for (int y = 0; y < Create3Array.GetLength(1); y++)
    {
      for (int z = 0; z < Create3Array.GetLength(2); z++)
      {
     Create3Array[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
*/



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
int n = 4;
int[,] SpiralArray = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= SpiralArray.GetLength(0) * SpiralArray.GetLength(1))
{
  SpiralArray[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < SpiralArray.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= SpiralArray.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > SpiralArray.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(SpiralArray);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");
      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
*/