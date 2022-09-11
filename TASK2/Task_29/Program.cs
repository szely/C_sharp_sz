// Задайте двумерный массив напишите программу которая меняет строки на столбцы в случаи если это возможно либо вывести сообщение об ошибке

using static System.Console;
using System.Linq;
Clear();

WriteLine("Введите размер массива, а так же минимальное и максимальное значени");
int[] parameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
WriteLine();
PrintMatrixArray(matrix);
WriteLine();
if (parameters[0] == parameters[1])
{
    int[,] changeMatrix = ChangeMatrix(matrix);
    PrintMatrixArray(changeMatrix);
}
else
{
    WriteLine("Трансформация строк в столбцы в данном массиве не возможна!");
    return;
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

int[,] ChangeMatrix(int[,] inArray)
{
    int[,] result = new int[inArray.GetLength(0), inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[i,j] = inArray[j,i];
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
