// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
using static System.Console;
Clear();

WriteLine("Введите колличество чисел в ряду: ");
int n = int.Parse(ReadLine());
PrintArray(Fibonacci(n));

int[] Fibonacci(int m)
{
    int[] arr = new int[m];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < m; i++)
    {
        arr[i] = arr[i - 2] + arr[i - 1];
    }
    return arr;
}

void PrintArray(int[] mass)
{
    WriteLine($"[{String.Join(",", mass)}]");
}
