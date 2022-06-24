// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.

int[] CreateRandomArray(int size, int min, int max) // int[] возвращаем массив
{
    int[] newArray = new int[size]; // объявлен массив

    for(int i = 0; i < size; i++) // запускаем цикл
    {
        newArray[i] = new Random().Next(min, max + 1); // заполняем конкретный элемент
        Console.Write(newArray[i] + " "); // выводим массив через пробел
    }
    Console.WriteLine(); // попускаем строку

    return newArray; // увидим массив, из каких элементов он состоит
}

/* int FindPositiveSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sum += array[i];
    }
    return sum;
}

int FindNegativeSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sum += array[i];
    }
    return sum;
}

int[] myArray = CreateRandomArray(12,-9,9);

Console.WriteLine("Sum of positive numbers is " + FindPositiveSum(myArray));
Console.WriteLine("Sum of negative numbers is " + FindNegativeSum(myArray)); */

// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные,
// и наоборот.


/* Console.WriteLine("Input size array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min array");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max array");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);

int[] ChangeArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= (-1);
    }
    return myArray;
}

string OutputArray(int[] array)
{
    string ss = "";
    for(int i = 0; i < array.Length; i++)
    {
        ss += array[i] + ", ";
    }
    return ss;
}

Console.WriteLine("reverse array " + OutputArray(ChangeArray(myArray))); */


// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

/* bool FindNumberInArray(int[] array, int num)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == num) return true;
    }
    return false;
}

int[] myArray = CreateRandomArray(20,-20,20);
int find = 16;
Console.WriteLine("В массиве число "+ find + ((FindNumberInArray(myArray,find)) ? " присутствует" : " не присутствует" ));*/

// Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат
// в отрезке [10,99].

/* int FindCountElemensInRange( int[] array, int min, int max)
{
    int count = 0;
    for( int i=0; i < array.Length; i++)
    {
        if( array[i] >= min && array[i] <= max)
        count++;
    }
    return count;
}

int[] myArray = CreateRandomArray(12,-20,20);
int minnum = 10;
int maxnum = 99;
Console.WriteLine("Количество цифр в отрезке " + minnum + " до " + maxnum + " = " + FindCountElemensInRange(myArray, minnum, maxnum));*/

// ДОМАШНЕЕ ЗАДАНИЕ
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int EvenNumber(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        count++;
    }
    return count;
}

int min = 100;
int max = 999;
Console.WriteLine("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(a, min, max);
Console.WriteLine("Количество четных чисел в массиве " + EvenNumber(myArray));

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных
// позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/* int OddIndex(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0) sum += array[i];
    }
    return sum;
}

Console.WriteLine("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите min массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите max массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
Console.WriteLine("Сумма чисел стоящих на нечетных позициях " + OddIndex(myArray)); */


// Задача 38: Задайте массив вещественных(дробных, см. Random().NextDouble()) чисел. Найдите разницу между максимальным
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double a = Math.Round((new Random().NextDouble())*10, 2);
// Console.WriteLine(a);

// double newArray = Math.Round(new Random().Next(20, 50) + new Random().NextDouble(), 2);
// Console.WriteLine(newArray);

/* double[] CreateRandomArray(int size, int min, int max)
{
    double[] newArray = new double[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = Math.Round(new Random().Next(min, max) + new Random().NextDouble(), 2);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}

double SearchDif(double[] array)
{
    double maxnum = array[0];
    double minnum = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(maxnum < array[i]) maxnum = array[i];
        else
        {
            if(minnum > array[i]) minnum = array[i];
        }
    }
    double dif = Math.Round(maxnum - minnum, 2);
    return dif;
}

Console.WriteLine("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 20;
int max = 50;

double[] myArray = CreateRandomArray(size, min, max);
Console.WriteLine("Разница между максимальным и минимальным элементами cмассива " + SearchDif(myArray)); */
