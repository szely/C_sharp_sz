int [] array = {1,2,3,12,5,4,7,4};
int n = array.Length;
int find = 4;
int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
