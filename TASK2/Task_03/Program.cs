// Найти расстояние между двумя точками по координатам
using static System.Console;
Clear();
WriteLine("Введите коордтинаты первой точки:");
int x1 = Convert.ToInt32(ReadLine());
int y1 = Convert.ToInt32(ReadLine());
WriteLine("Введите координаты второй точки:");
int x2 = Convert.ToInt32(ReadLine());
int y2 = Convert.ToInt32(ReadLine());
double leght = Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2));
WriteLine($"Расстояние между точками равно {leght:f2}");
