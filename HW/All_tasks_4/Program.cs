// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine());
int c = CalculateDegree(a,b);
PrintDegree(a,b,c);




int CalculateDegree(int x, int y)
{
    int degree = Convert.ToInt32(Math.Pow(x,y));
    return degree;
}

void PrintDegree(int i, int j, int deg)
{
    Console.WriteLine($"Число {i} в степени {j} равно: {deg}");
}




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintSum(number, SumNumbers(number));

int SumNumbers(int n)
{
    int sum = 0;
    while(n/10 > 0)
    {
        int m = n % 10;
        sum = sum + m;
        n = n/10;
    }
    sum = sum + n;
    return sum;
}

void PrintSum(int i, int s)
{
    Console.WriteLine($"Суммма цифр в числе {i} равна: {s}");
}




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();
int[] newArray = new int[8];
GetArray(newArray);
PrintArray(newArray);




void GetArray(int [] array)
{
    int length = array.Length;
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0,100);
    }
}

void PrintArray(int [] arr)
{ 
    Console.WriteLine($"{String.Join(",",arr)}");
    Console.WriteLine($"[{String.Join(",",arr)}]");
}