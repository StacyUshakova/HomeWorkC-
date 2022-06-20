/* // На вход принимаем число и выводим сумму чисел этого числа(45678 = 4+5+6+7+8)
int FindSumOgDigits(int num)
{
    int sum = 0;

    while(num>0)
    {
        sum = sum + num % 10; // sum += num % 10 (+= увеличить)
        num = num / 10;
    }

    return sum;
}

// Console.WriteLine("Введите число: ");
// int sum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(FindSumOgDigits(sum));

int n = 234;
int result = FindSumOgDigits(n);
Console.WriteLine($"Сумма цифр в числе {n} равна {result}"); */

/* // Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int Sum(int num)
{
    int current = 1;
    int sum = 0;
    while(current <= num)
    {
        sum = sum + current; // 
        current++;
    }
    return sum;
}

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int res = Sum(a);
Console.WriteLine(res); */


/* // Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int Proizv(int num)
{
    int current = 1;
    int proizv = 1;
    while(current <= num)
    {
        proizv = proizv * current; // 
        current++;
    }
    return proizv;
}

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int res = Proizv(a);
Console.WriteLine(res);*/


/* // Напишите программу, которая принимает на вход число и выдаёт кол-во цифр в числе.

int KolNum(int num)
{
    int current = 0;
    while(num / 10 > 0)
    {
        current++;
    }
    return current;
}
int n = 4;
int result = KolNum(n);
Console.WriteLine(n); */

/* // Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int size = 8;
int[] array = new int [size];

for(int i = 0; i < size; i++)
{
    array[i] = new Random().Next(0,2);
}

for(int i = 0; i < size; i++)
{
    Console.Write(array[i] + " ");
} */

// ДОМАШНЕЕ ЗАДАНИЕ
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/* //1 вариант
int num, k, proizv;
proizv = 1;

Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
k = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < k; i++ )
{
    proizv *= num;
}

Console.WriteLine($"Число {num} в степени {k} равно {proizv}"); */

/* // 2 вариант:
double QuadNum(double num, double step)
{
    return Math.Pow(num,step);
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
int step = Convert.ToInt32(Console.ReadLine());

double result = QuadNum(num, step);
Console.WriteLine($"Число {num} в степени {step} равно {result}"); */

/* // 3 вариант
int QuadNum(int num, int k)
{
    int proizv = 1;
    for(int i = 0; i < k; i++)
    {
        proizv *= num;
    }
    return proizv;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
int k = Convert.ToInt32(Console.ReadLine());

int proizv = QuadNum(num, k);
Console.WriteLine($"Число {num} в степени {k} равно {proizv}"); */

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int size = 8;
int[] array = new int [size];

for(int i = 0; i<size; i++)
{
    array[i] = new Random().Next(0, 30);
}

for(int i = 0; i<size; i++)
{
    Console.Write(array[i] + " ");
}