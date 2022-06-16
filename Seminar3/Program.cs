

// Необходимо программу принимает на вход координаты точки (x, y), причем x, y не равны 0
// и выдает номер четверть точки, в которой она находится

/* 

int FindQuard(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;

    return -1;
}

int result = FindQuard(2,4);

if(result == -1)
{
    Console.WriteLine("Данная точка расположена на осях");
}
else Console.WriteLine($"Точка находится в {result} точках");

*/

/* // НЕ ДОДЕЛНА!!!// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой
// четверти (x и y).

void FindDiap(int quart)
{
    if(quart == 1) Console.WriteLine("Координаты x>0, y>0");
    if(quart == 2) Console.WriteLine("Координаты x<0, y>0");
    if(quart == 3) Console.WriteLine("Координаты x<0, y<0");
    if(quart == 4) Console.WriteLine("Координаты x>0, y<0");
    if(quart > 4 && quart <0)
    {
        Console.WriteLine("Неправильно выбрана четверть, введите четверть от 1 до 4");
    }
}

Console.WriteLine("Введите номер четверти");
int num = Convert.ToInt32(Console.ReadLine());

FindDiap(num); */


/*

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N (включительно) 

void Quad(int num)
{
    int current = 1;
    while(current <= num)
    {
        Console.Write((current * current) + " ");
        current++;
    }
}

Console.WriteLine("Ввести число");
int num = Convert.ToInt32(Console.ReadLine());

Quad(num);

*/

/*

// Нахождение расстояния между точками. 

double FindLenth(double xA, double yA, double xB, double yB)
{
    return Math.Sqrt((xB - xA) * (xB - yA) + Math.Pow((yB - yA),2));
}

*/

// ДОМАШНЕЕ ЗАДАНИЕ

/* // Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Polindrom(int num)
{
    if(num < 10000 || num > 99999)
    {
        return -1;
    }
    else
    {
        int dectis, tis, dec, ed;
        dectis = num / 10000; // 56765 - 5
        tis = num / 1000 % 10; // 56765 - 56
        dec = num / 10 % 10; // 56765 - 5676
        ed = num % 10; 
        if(dectis == ed && tis == dec)
        {
            Console.WriteLine("да");
        }
        else
        {
            Console.WriteLine("нет");
        }
        return 1;
    }

}

Console.WriteLine("Введите пятизначное число");
int a = Convert.ToInt32(Console.ReadLine());

int result = Polindrom(a);

if(result == -1) Console.WriteLine("Введено не пятизначное число, введите правильное число!");*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D
// пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// xa = 3  ya = 6  za = 8
// xb = 2  yb = 1  zb = -7

/* double FindDistance(double xA, double yA, double zA, double xB, double yB, double zB)
{
    return Math.Sqrt(Math.Pow((xB - xA),2) + Math.Pow((yB - yA),2) + Math.Pow((zB - zA),2));
}

Console.WriteLine("Введите координаты точки A - x: ");
double xA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки A - y: ");
double yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки A - z: ");
double zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B - x: ");
double xB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B - y: ");
double yB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B - z: ");
double zB = Convert.ToInt32(Console.ReadLine());

double result = FindDistance(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Расстояние между точками равно {Math.Round(result,2)}"); */

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void CubeNum(int num)
{
    int current = 1;
        if(num > 0)
        {
            while(current <= num)
            {
                Console.Write(Math.Pow(current, 3) + " ");
                current++;
            }
        }
        else
        {
           Console.WriteLine("Введено отрицательное число, введите число больше 0");
        }
}

Console.WriteLine("Введите число: ");
int current = Convert.ToInt32(Console.ReadLine());

CubeNum(current);