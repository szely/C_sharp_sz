// Создать массив размерностью  m на n элемант которого находиться по формуле n+m 
using static System.Console;
using System.Linq;
Clear();
WriteLine("Ведите размер матрицы через пробел");
int[] parameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int[,] matrix = ChangeMatrixArray(parameters[0], parameters[1]);
PrintMatrixArray(matrix);

int[,] GetMatrixArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = i + j;
        }
    }

    return result;
}

int[,] ChangeMatrixArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = (rows-1-i) + (columns-1-j);
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
