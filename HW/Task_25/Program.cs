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

