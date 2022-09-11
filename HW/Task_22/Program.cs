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

