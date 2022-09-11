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