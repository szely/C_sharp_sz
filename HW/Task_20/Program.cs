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

