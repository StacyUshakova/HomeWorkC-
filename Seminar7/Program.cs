int[,] CreateRandomTwoDemArray(int m, int n, int min, int max)
{
    int[,] newMatrix = new int[m, n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max + 1);
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
           Console.Write(array[i, j] + " "); 

        Console.WriteLine();
    }
}

/* int[,] array = CreateRandomTwoDemArray(4, 5, 1, 9); */

// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив
// на экран. newMatrix[i,j] 

// 1 Вариант
/* int[,] CreateArray(int m, int n) // метод создания массива
{
    int[,] newMatrix = new int[m,n];

    for(int i = 0; i < m; i++)
        for(int j = 0; j < n; j++)
            newMatrix[i,j] = i + j;
            
    return newMatrix;
}

void ShowTwoDimArray(int[,] array) // метод вывода массива на экран
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = CreateRandomTwoDemArray(4, 5, 1, 9);*/

// 2 Вариант

/* int[,] CreateArray(int m, int n) // метод создания массива
{
    int[,] newMatrix = new int[m,n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            newMatrix[i,j] = i + j;
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();  
    } 
    return newMatrix;
}

int[,] array = CreateArray(4, 5); */

// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// 1 Вариант
/* int[,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a,b];

    for(int i = 0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max + 1);
            if(i % 2 == 0 && j % 2 == 0)
            {
                newMatrix[i,j] = newMatrix[i,j] * newMatrix[i,j];
            }
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}

int[,] array = CreateRandomTwoDemArray(4, 5, 1, 9); */

// 2 Вариант
/* int[,] UpdateArrayEvenIndexQuad(int[,] array)
{
    int step = 2;
    for(int i = 0; i < array.GetLength(0); i+= step)
        for(int j = 0; j < array.GetLength(1); j+=step)
                array[i,j] *= array[i,j];

    return array;
}

int[,] myArray = CreateRandomTwoDemArray(4, 5, 2, 15);

Console.WriteLine();

UpdateArrayEvenIndexQuad(myArray); */

// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// 1 Вариант
/* int Diagonal(int a, int min, int max)
{
    int[,] newMatr = new int[a,a];
    int sum = 0;
    for(int i = 0; i < a; i++)
    {
        for(int j = 0; j < a; j++)
        {
            newMatr[i,j] = new Random().Next(min, max + 1);
            if(i == j)
            {
                sum += newMatr[i,j];
            }
            Console.Write(newMatr[i,j] + " ");
        }
        Console.WriteLine();
    }
    return sum;
}

Console.Write(Diagonal(5, 1, 9)); */

// 2 Вариант
/* int SumOfDiagonal(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
        sum += array[i,i];
    
    return sum;
}

int[,] myArray = CreateRandomDemArraySquare(7, 2, 15);
Console.WriteLine(SumOfDiagonal(myArray)); */

// ДОМАШНЕЕ ЗАДАНИЕ
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/* double[,] CreateRandomTwoDemArray(int m, int n, int min, int max)
{
    double[,] newMatrix = new double[m, n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            newMatrix[i,j] = Math.Round(new Random().Next(min, max) + new Random().NextDouble(), 2);
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}

Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input minimum value of an array element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input maximum value of an array element: ");
int max = Convert.ToInt32(Console.ReadLine());

CreateRandomTwoDemArray(m, n, min, max); */


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого
// элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

/* void SearchNumOfPosition(int[,] array, int x, int y)
{
    if(x < 1 || y < 1 || x > array.GetLength(0) || y > array.GetLength(1))
        Console.WriteLine("Element in that position was not found");
    else Console.WriteLine($"Number at the position i = {x} and j = {y} is {array[x - 1, y - 1]}");
}

Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input minimum value of an array element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input maximum value of an array element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandomTwoDemArray(m, n, min, max);

Console.WriteLine("Input index a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input index b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
SearchNumOfPosition(myArray, a, b); */



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. //0,0  1,0  2,0

void ArithmeticMean(int[,] array)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        double average = Math.Round(sum / array.GetLength(0), 2);
        Console.Write(average + " ");
    }
}

Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input minimum value of an array element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input maximum value of an array element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandomTwoDemArray(m, n, min, max);
ArithmeticMean(myArray);
