// Найдите произведение пар элементов в массиве если длина не четная то не умножаем

using static System.Console;

Clear();
int[] array = GetArray(9, 0, 10);
PrintArray(array);
PrintArray(GetPro(array));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int[] GetPro(int[] arr)
{
    int size = arr.Length % 2 == 0 ? arr.Length / 2 : arr.Length / 2 + 1;
    int[] result = new int[size];
    for (int j = 0; j < arr.Length / 2; j++)
    {
        result[j] = arr[j] * arr[arr.Length - j - 1];
    }
    if (arr.Length % 2 == 1)
    {
        result[size - 1] = arr[arr.Length / 2];
    }
    return result;
}

void PrintArray(int[] mass)
{
    WriteLine($"[{String.Join(",", mass)}]");
}
