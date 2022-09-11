// Посчитать сумму элементов находящихся на главной диогонале эта диогональ где номера индексов совпадают

using static System.Console;
using System.Linq;
Clear();
Write("Введите размеры массива, мин и макс значения через пробел: ");
int[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrixArray(matrix);
WriteLine();
WriteLine($"Сумма элементов по главнной диогонали равно {SumMatrixArray(matrix)}");

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

int SumMatrixArray(int[,] inArray)
{
    int result = 0;
    // for (int i = 0; i < inArray.GetLength(0); i++)
    // {
    //     for (int j = 0; j < inArray.GetLength(1); j++)
    //     {
    //         if (i==j)
    //         {
    //             result += inArray[i, j];
    //         }
    //     }
    // }
    int size = inArray.GetLength(0)<inArray.GetLength(1)? inArray.GetLength(0) : inArray.GetLength(1);
    for (int i = 0; i < size; i++)
    {
        result += inArray[i, i];
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

