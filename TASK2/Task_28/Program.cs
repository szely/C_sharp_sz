﻿// Задайте двумерный массив напишите программу которая поменяет первую и последнюю строку массива
using static System.Console;
using System.Linq;
Clear();
Write("Введите размеры массива, мин и макс значения через пробел: ");
int[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrixArray(matrix);
WriteLine();
ChangeString(matrix);
PrintMatrixArray(matrix);

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

void ChangeString(int[,] inArray)
{
    int i = 0;
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
            int item = inArray[inArray.GetLength(0) - 1, j];
            inArray[inArray.GetLength(0) - 1, j] = inArray[i, j];
            inArray[i, j] = item;
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

