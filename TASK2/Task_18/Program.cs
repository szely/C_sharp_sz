// // Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// using static System.Console;
// Clear();

// WriteLine("Введите сторону A: ");
// int a = int.Parse(ReadLine());
// WriteLine("Введите сторону B: ");
// int b = int.Parse(ReadLine());
// WriteLine("Введите сторону C: ");
// int c = int.Parse(ReadLine());

// if(a + b > c && a + c > b && c + b > a)
// {
//     WriteLine("Треугольник существует");
// }
// else
// {
//      WriteLine("Треугольника не существует");
// }

/*Задача 40: Напишите программу, которая принимает на вход три
 числа и проверяет, может ли существовать треугольник с сторонами
 такой длины*/
using static System.Console;
using System.Linq;
Clear();

WriteLine("Enter the sides of the triangle");

int[] array = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x=>Convert.ToInt32(x)).ToArray();

WriteLine(Triangle(array)?"Yes":"No");

bool Triangle(int[] arra)
{
    return (arra[0]+arra[1] > arra[2] && arra[1]+arra[2] > arra[0] && arra[0]+arra[2] > arra[1]);
    
}