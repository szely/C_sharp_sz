// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using static System.Console;
Clear();
WriteLine("Введите числа:");
int[] array = GetArrayFromString(ReadLine());
WriteLine($"[{String.Join(",",array)}]");
WriteLine($"Количество введенных числел больше 0 равно {CountNoNull(array)}");


int[] GetArrayFromString(string arrayString)
{
    string[] masString = arrayString.Split(" ",StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int [masString.Length];
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(masString[i]);
    }
    return result;
}

int CountNoNull(int[] arr)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(arr[i] > 0)
        {
            result++;
        }
    }
    return result;
}


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using static System.Console;
Clear();
WriteLine("Введите число k1: ");
int k1 = int.Parse(ReadLine());
WriteLine("Введите число k2: ");
int k2 = int.Parse(ReadLine());
WriteLine("Введите число b1: ");
int b1 = int.Parse(ReadLine());
WriteLine("Введите число b2: ");
int b2 = int.Parse(ReadLine());
if(k1 == k2)
{
    WriteLine("Прямые параллельны, точек перечечения нет");
}
else
{
    PrintArray(GeneralPoint(k1, k2, b1, b2));
}


double[] GeneralPoint(int n1, int n2, int m1, int m2)
{
    double[] arr = new double[2];
    arr[0] = (double)(m2 -m1)/(n1-n2);
    arr[1] = (double)(n1*arr[0] + m1);
    return arr;
}

void PrintArray(double[] mass)
{
    WriteLine($"({String.Join(",",mass)})");
}
