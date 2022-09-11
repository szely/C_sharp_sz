// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using static System.Console;
using System.Linq;
Clear();
WriteLine("Введите размер массива, а так же минимальное и максимальное значени");
int[] parameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
WriteLine();
PrintMatrixArray(matrix);
WriteLine();
SortArray(matrix);
PrintMatrixArray(matrix);
WriteLine();

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

void SortArray(int[,] inArray)
{
    for (int k = 0; k < inArray.GetLength(0); k++)
    {
        for (int i = 0; i < inArray.GetLength(1); i++)
        {
            for (int j = i + 1; j < inArray.GetLength(1); j++)
            {
                if (inArray[k, i] < inArray[k, j])
                {
                    int temp = inArray[k, i];
                    inArray[k, i] = inArray[k, j];
                    inArray[k, j] = temp;
                }
            }
        }
    }
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



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using static System.Console;
using System.Linq;
Clear();
WriteLine("Введите размер массива, а так же минимальное и максимальное значени");
int[] parameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
WriteLine();
PrintMatrixArray(matrix);
WriteLine();
WriteLine($"Первая по порядку строка с нименьшей суммой элементов: {StringSumMax(matrix)} (нумерация с 1)");

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

int StringSumMax(int[,] inArray)
{
    int result = 1;
    int min = 0;
    int sum = 0;
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        min += inArray[result-1, j];
    }
    for (int i = 1; i < inArray.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i, j];
        }
        if (min > sum)
        {
            min = sum;
            result = i+1;
        }
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



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using static System.Console;
using System.Linq;
Clear();
WriteLine("Введите размер первого массива, а так же минимальное и максимальное значени");
int[] firstParameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
WriteLine("Введите размер второго массива, а так же минимальное и максимальное значени");
int[] secondParameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
if (firstParameters[0] != secondParameters[1])
{
    WriteLine("ОШИБКА!!! Чтобы можно было умножить две матрицы, количество столбцов первой матрицы должно быть равно количеству строк второй матрицы.");
    return;
}
else
{
    int[,] firstMatrix = GetMatrixArray(firstParameters[0], firstParameters[1], firstParameters[2], firstParameters[3]);
    int[,] secondMatrix = GetMatrixArray(secondParameters[0], secondParameters[1], secondParameters[2], secondParameters[3]);

    WriteLine();
    PrintMatrixArray(firstMatrix);
    WriteLine();
    PrintMatrixArray(secondMatrix);
    int[,] productMatrix = GetProductMatrix(firstMatrix, secondMatrix);
    WriteLine();
    PrintMatrixArray(productMatrix);
}

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

int[,] GetProductMatrix(int[,] inArrayFirst, int[,] inArraySecond)
{
    int[,] result = new int[inArrayFirst.GetLength(0), inArraySecond.GetLength(1)];
    int sum = 0;
    for (int i = 0; i < inArrayFirst.GetLength(0); i++)
    {
        for (int k = 0; k < inArraySecond.GetLength(1); k++)
        {
            for (int j = 0; j < inArrayFirst.GetLength(1); j++)
            {
                sum += (inArrayFirst[i, j] * inArraySecond[j, k]);
            }
            result[i, k] = sum;
            sum = 0;
        }
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



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using static System.Console;
using System.Linq;
Clear();
WriteLine("Введите размер массива, а так же минимальное и максимальное значени");
int[] parameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int[,,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2]);
WriteLine();
PrintMatrixArray(matrix);
WriteLine();

int[,,] GetMatrixArray(int rows, int columns,int depths)
{
    int[,,] result = new int[depths, rows, columns];
    int n = 1;
    int m = new Random().Next(10, 13);
    for (int k = 0; k < depths; k++)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j, k] = m * n + (i + j + k);
                n++;
            }
        }
    }
    return result;
}

void PrintMatrixArray(int[,,] inArray)
{
    for (int k = 0; k < inArray.GetLength(2); k++)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Write($"{inArray[i, j, k]} ({i},{j},{k}) ");
            }
            WriteLine();
        }
    }
}



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using static System.Console;
using System.Linq;
Clear();
WriteLine("Введите стартовое число: ");
int parameter = int.Parse(ReadLine());
int[,] matrix = GetMatrixArray(4, 4, parameter);
WriteLine();
PrintMatrixArray(matrix);
WriteLine();

int[,] GetMatrixArray(int rows, int columns, int n)
{
    int[,] result = new int[rows, columns];
    int m = 0;
    int i = 0;
    int j = 0;
    while (i < columns)
    {
        result[j, i] = n + m;
        i++;
        m++;
    }
    i -= 1;
    j++;
    while (j < rows)
    {
        result[j, i] = n + m;
        j++;
        m++;
    }
    j -= 1;
    i -= 1;
    while (i >= 0)
    {
        result[j, i] = n + m;
        i -= 1;
        m++;
    }
    j -= 1;
    i += 1;
    while (j > 0)
    {
        result[j, i] = n + m;
        j -= 1;
        m++;
    }
    j += 1;
    i++;
    while (i < columns - 1)
    {
        result[j, i] = n + m;
        i++;
        m++;
    }
    j += 1;
    i -= 1;
    while (i > 0)
    {
        result[j, i] = n + m;
        i -= 1;
        m++;
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
