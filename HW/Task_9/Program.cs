// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
using static System.Console;
Clear();
WriteLine("Введите координаты первой точки в пространстве A: ");
int x1 = int.Parse(ReadLine());
int y1 = int.Parse(ReadLine());
int z1 = int.Parse(ReadLine());
WriteLine("Введите координаты второй точки в пространстве B: ");
int x2 = int.Parse(ReadLine());
int y2 = int.Parse(ReadLine());
int z2 = int.Parse(ReadLine());
double distance = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1));
WriteLine($"Расстояние между точками A({x1},{y1},{z1}) и B({x2},{y2},{z2}) равно {distance:f2}");