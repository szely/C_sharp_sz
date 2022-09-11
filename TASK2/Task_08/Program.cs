// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
using static System.Console;
Clear();

int [] newArray = new int [10];
WriteLine(newArray);

int [] GetArrey (int N)
{
int [] array = new int[N];
for (int i = 0;  i<N; i++)
    {
       array [i]= new Random().Next (0,2);  
    }
       return array;
}

// void PrintArray(int[] Mass)
// {
//     Write("[ ");
//     for (int i = 0;  i < Mass.Length; i++)
//     {
//       Write (Mass[i] + " ");
//     }
//     Write(" ]");
// }