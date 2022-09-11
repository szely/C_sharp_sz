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
