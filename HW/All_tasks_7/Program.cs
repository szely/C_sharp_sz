// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using static System.Console;
using System.Linq;
Clear();
WriteLine("Введите количество строк и столбцов, а так же диапозон генерации чисел: ");
int[] parameters = ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
double[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
WriteLine();
PrintMatrixArray(matrix);


double[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] result = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = Math.Round((new Random().Next(minValue, maxValue) + new Random().NextDouble()),1);
        }
    }
    return result;
}


void PrintMatrixArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using static System.Console;
using System.Linq;
Clear();
Write("Введите строку: ");
int m = int.Parse(ReadLine());
Write("Введите столбец: ");
int n = int.Parse(ReadLine());
int[,] matrix = { { 3, 4, 5 }, { 4, 6, 1 }, { 7, 9, 9 }, { 5, 1, 4 } };
PrintMatrixArray(matrix);
WriteLine();
if (CheckPosition(matrix, m, n) == true)
{
    WriteLine($"{GetNumber(matrix, m, n)}");
}
else
{
    WriteLine("Такого элемента в массиве нет");
}


int GetNumber(int[,] inArray, int a, int b)
{
    int result = inArray[a, b];
    return result;
}


bool CheckPosition(int[,] inArray, int a, int b)
{
    bool result = (a < inArray.GetLength(0) && b < inArray.GetLength(1)) ? true : false;
    return result;
}


void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static System.Console;
using System.Linq;
Clear();

Write("Введите размеры массива, мин и макс значения через пробел: ");
int[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrixArray(matrix);
double[] average = GetAverage(matrix);
WriteLine($"Среднее арифмитическое каждого столбца: {String.Join(";", average)}");


int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}


double[] GetAverage(int[,] inArray)
{
    double[] result = new double[inArray.GetLength(1)];
    int j = 0;
    while (j < inArray.GetLength(1))
    {
        int sum = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            sum += inArray[i, j];
            result[j] = Math.Round((double)sum / inArray.GetLength(0), 1);
        }
        j++;
    }
    return result;
}


void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

