/* string[] names = {"Ivan", "Anna", "Max", "Denis"};
Console.WriteLine(names[0][1]); // 0 строка, 1 симфол, те Ivan это 0, 1 символ - это буква v */

// метод, который посличтает кол-во слов больше чем 5 символов

string[] CreateStringArray(int size)
{
    string[] words = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} word: ");
        words[i] = Console.ReadLine();
    }
    return words;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

/* int NumberOfLongWords(string[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
        if(array[i].Length >= 5)
            count++;
    
    return count;
}

Console.Write("Input number of names: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] names = CreateStringArray(size);

Console.WriteLine("Number of long words is " + NumberOfLongWords(names)); */

// 1. Написать программу, которая принимает на вход два массива строк и возвращает массив из попарно объединенных исходных элементов.

/* string[] MergeTwoArrays(int size, string[] array1, string[] array2)
{
    string[] words = new string[size];

    for (int i = 0; i < size; i++)
    {
        words[i] = array1[i] + " " + array2[i];
    }
    return words;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input the size of arrays: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] myarray1 = CreateStringArray(size);
string[] myarray2 = CreateStringArray(size);
ShowArray(MergeTwoArrays(size, myarray1, myArray2)); */

/*
string[] CreateStringArray(int size)
{
    string[] words = new string [size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} word: ");
        words [i]= Console.ReadLine();
    }

    return words;
}

string[] MatchTwoArrays(int size, string[] array1, string[] array2)
{
    string[] words = new string [size];

    for(int i = 0; i < size; i++)
    {
        words [i]= array1[i] + " " + array2[i];
    }

    return words;
}

void ShowArray(string[] array)
{
   for(int i = 0; i < array.Length; i++)
      Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Input the size of arrays: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] myarray1 = CreateStringArray(size);
string[] myarray2 = CreateStringArray(size);
ShowArray(MatchTwoArrays(size, myarray1,myarray2));
*/

// 2. Написать программу, которая считает кол-во слов, начинающихся на букву Y или W.

/* int SymbolsOfWords(string[] array, char a, char b)
{
    int count = 0;

     for(int i = 0; i < array.Length; i++)
         if (array[i][0] == a|| array[i][0] ==b)
            count ++;

    return count;        
}
Console.Write("Input the size of arrays: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input First Symbol: ");
char a = Convert.ToChar(Console.ReadLine());

Console.Write("Input Second Symbol: ");
char b = Convert.ToChar(Console.ReadLine());

string[] names = CreateStringArray(size);
Console.WriteLine(" " + SymbolsOfWords(names, a,b));
Console.WriteLine(names[1].ToLower()); */


// ДОМАШНЕЕ ЗАДАНИЕ
// Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
// Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1
// aeyuio

/* int VowelLetter(string[] array)
{
    int count = 0;

     for(int i = 0; i < array.Length; i++)
         if (array[i][0] == 'a' || array[i][0] == 'e' || array[i][0] == 'y' || array[i][0] == 'u'||
         array[i][0] == 'i' || array[i][0] == 'o')
            count ++;

    return count; 
}

Console.Write("Input the size of arrays: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] words = CreateStringArray(size);
Console.WriteLine(VowelLetter(words)); */


// Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.
// Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}

string[] MergeString(int size, string[] array)
{
    string[] words = new string [size];

    for(int i = 0; i < size; i += 2)
    {
        words [i]= array[i] + array[i+1];
    }

    return words;
}

void ShowArrays(string[] array)
{
   for(int i = 0; i < array.Length; i++)
      Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Input the size of arrays: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] myarray = CreateStringArray(size);
ShowArray(MergeString(size, myarray));