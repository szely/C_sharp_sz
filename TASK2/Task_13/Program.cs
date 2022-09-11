// Напишите программу замены элементов массива положительные на отрицательные и наоборот сгенерировать рандомный массив в диапозоне от -10 до 10

using static System.Console;

Clear();
int[] array = GetArray(10, -10, 10);
PrintArray(array);
ChangeArray(array);
PrintArray(array);


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue+1);
    }
    return result;
}

void ChangeArray(int[] arr)
{
    for(int j = 0; j < arr.Length; j++)
    {
            arr[j] *= -1;
    }
}

void PrintArray(int[] mass)
{
    WriteLine($"[{String.Join(",",mass)}]");
}

