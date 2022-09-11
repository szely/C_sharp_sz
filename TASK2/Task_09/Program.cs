using static System.Console;
Clear();
WriteLine("Введите число: ");
int [] array = new int [3];
for(int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(ReadLine());
}
WriteLine($"[{String.Join(",",array)}]");

