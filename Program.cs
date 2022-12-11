// Написать программу, которая из имеюшегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
using static System.Console;
using System;

WriteLine("Введите размер массива");
int n = int.Parse(ReadLine());
string[] arr = new string[n];
string[] newarr = new string[n];
WriteLine("Вводите элементы массива массива нажимая Enter");
for (int i = 0; i < n; i++)
{
    arr[i] = ReadLine(); // заполнение массива
}
void SecondArrayWithIF(string[] arr, string[] newarr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
    if(arr[i].Length <= 3)
        {
        newarr[count] = arr[i];
        count++;
        }
    }
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(arr, newarr);
PrintArray(newarr);