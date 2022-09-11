// Задайте массив в диапазоне от 0 до 1000 надите колличество элементов которые лежат в отрезке от 10 до 99

using static System.Console;

Clear();
int[] array = GetArray(10, 0, 1000);
int n = 10;
int m = 99;
PrintArray(array);
int res = FindCount(array, n, m);
WriteLine($"В массиве количество элементов  в диапазоне от {n} до {m} равно: {res}");


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue+1);
    }
    return result;
}

int FindCount(int[] mass, int start, int end)
{
    int count = 0;
    foreach(int item in mass)
    {
            if(item >= start && item <= end) 
            {
                count++;
            }
    }
return count;
}

void PrintArray(int[] mass)
{
    WriteLine($"[{String.Join(",",mass)}]");
}