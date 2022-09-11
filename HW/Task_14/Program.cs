//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using static System.Console;

Clear();
int[] array = GetArray(10, 100, 1000);
PrintArray(array);
WriteLine($"Количество четных чисел в массиве равно: {CountPositive(array)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue+1);
    }
    return result;
}

int CountPositive(int[] arr)
{
 int count = 0;
for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
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
