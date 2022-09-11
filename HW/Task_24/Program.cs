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

