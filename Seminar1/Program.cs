﻿/*

// Написать программу, которая запрашивает у пользователя целое число, после чего вернет пользователю квадрат этого числа

int num, result;

Console.Write("Input integer number: ");
num = Convert.ToInt32(Console.ReadLine());

result = num * num;

Console.WriteLine("Result is " + result);

*/

/*

// Написать программу, которая принимает на вход два целых числа и проверяет, является ли первое число
// квадратом второго числа

int num1, num2, quad;

Console.WriteLine("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

quad = num2 * num2;

if(num1 == quad)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}

*/

/* 

// Написать программу, которая на вход принимает натуральное число и в качестве резальтата выводит все числа
// от отрицательной его версии до положительной: например 4, программа выводит -4,-3,-2,-1,0,1,2,3,4

int num;

Console.WriteLine("Input integer number: ");
num = Convert.ToInt32(Console.ReadLine());

int current = num *(-1);

while(current <= num)
{
    Console.Write(current + " ");
    current++; // current = current + 1;
}

*/

/*

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int num1, num2;

Console.WriteLine("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("max = " + num1);
}
else
{
    Console.WriteLine("max = " + num2);
}

*/

/*

!!!!!!!!!! // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int num1, num2, num3, max;

Console.WriteLine("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input third input number: ");
num3 = Convert.ToInt32(Console.ReadLine());

max = num1;

if(max < num2)
{
    max = num2;
}
else
{
   if(max < num3)

}

Console.Write("max = " + max);

*/

/*

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

int num;

Console.WriteLine("Input integer number: ");
num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int num, i, current;

Console.WriteLine("Input integer number: ");
num = Convert.ToInt32(Console.ReadLine());