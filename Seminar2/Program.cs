/* 
// Программа будет принимать на вход двузначное число и будет выводить большую из его цифр

int FindMaxPart(int num)
{
    int dec, ed;
    if(num >= 10 && num <= 99)
    {
        dec = num / 10;
        ed = num % 10;
        if(dec > ed)
        {
            return dec;
        }
        else
        {
            return ed;
        }
    }
    else
    {
        return -1;
    }
}

Console.WriteLine("Input two-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = FindMaxPart(a);

if(result == -1)
{
    Console.WriteLine("Your number is not two-digit");
}
else
{
    Console.WriteLine($"Bigger number of {a} is {result}");
}

*/

/*// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 123 -> 13

int FindNum()
{
    int num = new Random().Next(100, 1000);
    Console.WriteLine($"Current number is {num}");

    int sot = num / 100;
    int ed = num % 10;

    int result = sot * 10 + ed;
    return result;
}

int b = FindNum();
Console.WriteLine(b); */

/* // Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если второе число не кратно числу первому, то программа выводит остаток от деления.

string IsAliquot(int num1, int num2)
{
    if(num2 % num1 == 0)
    {
        return "True";
    }
    else
    {
        int result = num2 % num1;
        return ($"False, rest num is {result}");
    }
}

int num1, num2;

Console.WriteLine("Input first number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

*/


/*// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

int MethodKratnoe(int num)
{
    if(num % (7*23) == 0)
    {
        return 1;
    }
    else
    {
        return -1;
    }
}

Console.WriteLine("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = MethodKratnoe(a);

if(result == 1)
{
    Console.WriteLine($"Число {a} кратно 7 и 23");
}
else
{
    Console.WriteLine($"Число {a} некратно 7 и 23");
}
*/

/* //или

bool MethodKratnoe(int num)
{
    if(num % (23*7) == 0) return true;
    else return false;
}

*/

//ДОМАШНЕЕ ЗАДАНИЕ

/*//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int CutNumber(int num)
{
    if(num < 100 || num >= 1000)
    {
        Console.WriteLine("Введено не трехзначное число, введите правильное число!");
        return -1;
    }
    else
    {
        int num1 = num / 10; //456  45
        int result = num1 % 10;
        return result;
    }
}

Console.WriteLine("Input three-digit number: ");
int result = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CutNumber(result)); */

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

/*
// без учета отрицательных чисел

int ThirdNum(int num)
{
   if(num < 100)
   {
        Console.WriteLine("Третьей цифры нет");
        return -1;
   }
   else
   {
        while(num > 999)
        {
            num = num / 10;
        }
        int result = num % 10;
        return result;
   }
}

Console.WriteLine("Input integer number: ");
int result = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ThirdNum(result)); */

// с учетом отрицательных чисел

/* int ThirdNum(int num)
{
   if(num > 0)
   {
        if(num < 100)
        {
            return -1;
        }
        else
        {
            while(num > 999)
            {
                num = num / 10;
            }
            int result = num % 10;
            return result;
        }
    }
    else
    {
        if(num > (-100))
        {
            Console.WriteLine("Третьей цифры нет");
            return -1;
        }
        else
        {
            while(num < -999)
            {
                num = num / 10;
            }
            num = num * (-1);
            int result = num % 10;
            return result;
        }
    }
}

Console.WriteLine("Input integer number: ");
int result = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ThirdNum(result)); */

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли
// этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void DayWeek(int day)
{
    if(day == 1) Console.WriteLine("Нет");
    if(day == 2) Console.WriteLine("Нет");
    if(day == 3) Console.WriteLine("Нет");
    if(day == 4) Console.WriteLine("Нет");
    if(day == 5) Console.WriteLine("Нет");
    if(day == 6) Console.WriteLine("Да");
    if(day == 7) Console.WriteLine("Да");
    if(day < 1 || day > 7) Console.WriteLine("Введено неверный день недели, введите циифры от 1 до 7");
}

Console.WriteLine("Веедите цифру дня недели: ");
int vih = Convert.ToInt32(Console.ReadLine());

DayWeek(vih); 