// Написать программу, которая выведет все нат числа от 1 до N

/* void ShowNums(int n)
{
    if(n != 1) // != не равно
        ShowNums(n - 1);

    Console.Write(n + " ");
}

Console.Write("Input integer positieve number: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowNums(num); */

// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

/* void ShowNumsMToN (int m, int n)
{
    if(n != m)
        ShowNumsMToN(m, n - 1);

    Console.Write(n + " ");
}

Console.Write("Input integer min number: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input integer max number: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNumsMToN(m, n); */

// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// целочисленное деление на 10, пока есть что поделить на 10

/* int SumOfNum(int num)
{
    if(num == 0)
        return 0;
    return num % 10 + SumOfNum(num / 10);
}

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumOfNum(num)); */

// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// 1 вариант
/* int Degree(int a, int b)
{
    if(b != 0)
        return a *= Degree(a, b - 1);
    else return 1
}

Console.Write("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input integer degree: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Degree(a, b)); */

// 2 вариант
/* double Degree(int a, int b)
{
    if(b > 0)
        return a * Degree(a, b - 1);
    else if(b < 0)
             return 1 / (a * Degree(a, - b - 1));
    else return 1;
}

Console.Write("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input integer degree: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Degree(a, b)); */

// ДОМАШНЕЕ ЗАДАНИЕ
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/* int ShowSumBetweenMN (int m, int n)
{
    if(n == m) return n;
    else return n + ShowSumBetweenMN(m, n -1);
}

Console.Write("Input integer min number: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input integer max number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ShowSumBetweenMN(m, n)); */

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать кол-во его цифр.
// 453 -> 3
// 45 -> 2

int KolNums(int num)
{
    if(num / 10 != 0)
        return 1 + KolNums(num / 10);
    else return 1;
}

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(KolNums(num));