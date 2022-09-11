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

