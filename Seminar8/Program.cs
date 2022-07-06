int[,] CreateTwoDimArray(int m, int n, int min, int max)
{
    int[,] array = new int[m,n];

    for(int i = 0; i < m; i++)
        for(int j = 0; j < n; j++)
            array[i,j] = new Random().Next(min, max + 1);

    return array;
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

// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива

/* int[,] ChangeLines(int[,] array, int strIndex1, int strIndex2) // 
{
    int temp;

    for(int j = 0; j < array.GetLength(1); j++) // проходимся по столбцам
    {
        temp = array[strIndex1, j];
        array[strIndex1, j] = array[strIndex2, j];
        array[strIndex2, j] = temp;
    }

    return array;
}

int[,] myArray = CreateTwoDimArray(4, 5, 1, 9);
ShowArray(myArray);
myArray = ChangeLines(myArray, 0, myArray.GetLength(0) - 1);
Console.WriteLine();
ShowArray(myArray); */

// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.
// 1 2 3        1 4 7
// 4 5 6    ->  2 5 8
// 7 8 9        3 6 9
// матрица квадратная!!! проверку на квадратность

/* int[,] ChangeRowsToColumns(int[,] array)
{
    for(int i = 0; i < array.GetLength(0) - 1; i++) // -1 потому что мы не берем самый последний элемент [3, 3]
        {
        for(int j = i + 1; j < array.GetLength(1); j++) // не нужно трогать главную диагональ
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
    return array;
} 

int m, n, min, max;
do
{
    Console.WriteLine("Введите данные. Число строк и столбцов должны быть одинаковыми: ");
    m = Convert.ToInt32(Console.ReadLine());
    n = Convert.ToInt32(Console.ReadLine());
    min = Convert.ToInt32(Console.ReadLine());
    max = Convert.ToInt32(Console.ReadLine());
}
while(m != n);

int[,] myArray = CreateTwoDimArray(m, n, min, max);

ShowArray(myArray);
Console.WriteLine();
myArray = ChangeRowsToColumns(myArray);
ShowArray(myArray); */

// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// 4 2 6 3
// 8 3 5 7
// 7 3 4 5

// 0 0 0 0
// 8 0 5 7
// 7 0 4 5
// Найти наименьший элемент массива
// занулить все строки и столбцы, содержащий этот элемент

/* int[,] DeleteMinElement(int[,] array)
{
    int minRow = 0;
    int minColumn = 0;
    int min = array[minRow, minColumn];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < min)
            {
                min = array[i,j];
                minRow = i;
                minColumn = j;
            }
        }
    }

    for(int i = 0; i < array.GetLength(0); i++)
        array[i, minColumn] = 0;

    for (int j = 0; j < array.GetLength(1); j++)
        array[minRow, j] = 0;

    return array;
}

int[,] myArray = CreateTwoDimArray(4,6,1,9);
ShowArray(myArray);
Console.WriteLine();
myArray = DeleteMinElement(myArray);
ShowArray(myArray); */

// ДОМАШНЕЕ ЗАДАНИЕ
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

/* int[,] FromMinToMaxElement(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(1)-1; k++)
            if(array[i,k] > array[i, k+1]) 
            {
                int temp = array[i,k];
                array[i,k] = array[i, k+1];
                array[i, k+1] = temp;
            }
        }
    }
    return array;
}

int[,] myArray = CreateTwoDimArray(4, 4, 1, 10);
ShowArray(myArray);
Console.WriteLine();
ShowArray(FromMinToMaxElement(myArray)); */

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/* int[] SumOfMinString (int[,] array)
{ 
    int[] newArray = new int [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        newArray[i] = sum;
    }
    return newArray;
}

void SearchMinLine (int[] array)
{
    int min = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[min] > array[i]) min = i;
    }
    Console.WriteLine($"Строка с минимальной суммой равно {min+1}");
}

Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input minimum value of an array element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input maximum value of an array element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateTwoDimArray(m, n, min, max);
ShowArray(myArray);
SearchMinLine(SumOfMinString(myArray)); */


// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int n = 4;
int[,] squareMassieve = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= squareMassieve.GetLength(0) * squareMassieve.GetLength(1))
{
  squareMassieve[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < squareMassieve.GetLength(1) - 1) j++;
  else if (i < j && i + j >= squareMassieve.GetLength(0) - 1) i++;
       else if (i >= j && i + j > squareMassieve.GetLength(1) - 1) j--;
            else i--;
}

ShowSquareArray(squareMassieve);

void ShowSquareArray (int[,] array)
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