// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

using static System.Console;
Clear();

// WriteLine("Введите числа массива");
int[] array = new int[10].Select(x=> new Random().Next(0,100)).ToArray();
PrintArray(array);
int[] array2 = CopyArray(array);
PrintArray(array2);

int[] CopyArray(int[] arr)
{
    int[] copy = new int[arr.Length];
    for(int i = 0; i < arr.Length; i++)
    {
        copy[i]= arr[i];
    }
return copy;
}

void PrintArray(int[] mass)
{
    WriteLine($"[{String.Join(",",mass)}]");
}
