// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool Palindrom (int N)
{
    if(N % 10 == N / 10000 && (N % 100) / 10 == (N / 1000) % 10)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Введите пятизначное число - ");
int N = Convert.ToInt32(Console.ReadLine());

bool result = Palindrom(N);

if(N < 10000 || N > 99999)
{
    Console.Write("Error");
}
else
{
    Console.WriteLine($"Число является палиндромом? - {result}");
}
*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Dystans (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double x = x2 - x1;
    double y = y2 - y1;
    double z = z2 - z1;
    double dst = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
    return dst;
}

Console.Write("Введите координату x1 - ");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y1 - ");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату z1 - ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату x2 - ");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y2 - ");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату z2 - ");
double z2 = Convert.ToInt32(Console.ReadLine());

double result = Dystans(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками равно {result}");
*/

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cub (int N)
{
    int count = 1;
    while (count <= N)
    {
        Console.WriteLine(Math.Pow(count, 3));
        count++;
    }
}

Console.Write("Введите число N - ");
int N = Convert.ToInt32(Console.ReadLine());

Cub(N);
*/

