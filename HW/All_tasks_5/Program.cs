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


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using static System.Console;

Clear();
int[] array = GetArray(10, -100, 100);
PrintArray(array);
WriteLine($"Сумма элементов, стоящих на нечетных позициях равна: {SumNegativePos(array)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue+1);
    }
    return result;
}

int SumNegativePos(int[] arr)
{
 int sum = 0;
for(int i = 0; i < arr.Length; i++)
    {
        if((i +1) % 2 != 0)
        {
            sum += arr[i];
        }
    }
 return sum;
}


void PrintArray(int[] mass)
{
    WriteLine($"[{String.Join(",",mass)}]");
}


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

using static System.Console;

Clear();
double[] array = GetArray(5, -10, 10);
PrintArray(array);
WriteLine($"Разница между максимальным и минимальным элементом массива равна: {FindMax(array)-FindMin(array)}");

double[] GetArray(int size, int minimumValue, int maximumValue)

{
    double[] arr = new double[size];
    for(int i = 0; i < size; i++)
    {
        arr[i] = new Random().NextDouble() + new Random().Next(minimumValue,maximumValue);

    }
return arr;
}


double FindMax(double[] arrA) 
{
   int j = 0;
   double max = arrA[j];
while (j < arrA.Length) 
{
   if(max<arrA[j])
    {
        max = arrA[j];
        j++;
    }
    else 
    {
    j++;
    }
}
return max;
}

double FindMin(double[] arrB) 
{
   int k = 0;
   double min = arrB[k];
while (k < arrB.Length) 
{
   if(min > arrB[k])
    {
        min = arrB[k];
        k++;
    }
    else 
    {
    k++;
    }
}
return min;
}


void PrintArray(double[] mass)
{
    WriteLine($"[{String.Join(",",mass)}]");
}


