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
