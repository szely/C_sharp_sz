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

