// Создать массив из 12 чисел заполнить случайными числами из промежутка от -9 до 9 найти сумму положительных и отрицательных чисел

using static System.Console;
int[] array = GetArray(12,-9,9);
WriteLine($"{String.Join(" ", array)}");
int positiveSum = 0;
int negativeSum = 0;
foreach(int item in array)
{
    positiveSum += item > 0 ? item : 0;
    negativeSum += item < 0 ? item : 0;
}

WriteLine($"Сумма положительных элементов равна: {positiveSum}");
WriteLine($"Сумма отрицательных элементов равна: {negativeSum}");


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue+1);
    }
    return result;
}