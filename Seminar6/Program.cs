/* int[] ReserseArray(int[] array)
{
    int temp;
    int j = array.Length - 1; // записали в j индекс последнего элемента

    for(int i = 0; i < array.Length / 2; i++)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}

int[] myArray = {2, 4, 6, 8};

myArray = ReserseArray(myArray);

for(int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
} */

// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник
// с сторонами такой длины.

/* void Triangle(int a, int b, int c)
{
    if(a + b > c && a + c > b && c + b > a) Console.WriteLine("Такой теругольник возможен");
    else Console.WriteLine("Таккой треугольник невозможен");
}

int a = 3;
int b = 5;
int c = 6;
Triangle(a,b,c); */


// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// 5 чисел (0, 1, 1, 2, 3, 5)

/* void Fibonachchi(int n)
{
    int[] array = new int(n);
    array[0] = 0;
    array[1] = 1;
    Console.Write(array[0] + " " + array[1] + " ");
    for(int i = 2; i < n, i++)
    {
        array[i] = array[i-1] + array[i-2];
        Console.Write(array[i] + " ");
    }
} 
int n = 7;
Fibonachchi(n); */

// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

/* string BinaryNumber(int num)
{
    string result = string.Empty;
    while(num > 0)
    {
        result = num % 2 + result;
        num /= 2;
    }
    return result;
}

Console.WriteLine(BinaryNumber(41)); */


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/* Console.Write($"Input amount of numbers (M): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arrayNum = new int[m];

void newArray(int m)
{
    for(int i = 0; i < m; i ++)
    {
        Console.WriteLine($"Input {i+1} number: ");
        arrayNum[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int SearchPositieveNum(int[] arrayNum)
{
  int count = 0;
  for (int i = 0; i < arrayNum.Length; i++)
    if(arrayNum[i] > 0 ) count += 1;
  return count;
}

newArray(m);
Console.WriteLine($"Input numbers greater than 0.: {SearchPositieveNum(arrayNum)} "); */


// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}

int[] array = CreateRandomArray(9,-9,9);

int[] CopyArray(int[] array)
{
    int[] copyArray = array;
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(copyArray[i] + " ");
    }
    return copyArray;
    
}

CopyArray(array);