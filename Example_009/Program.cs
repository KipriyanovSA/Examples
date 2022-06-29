int[] array = { 4, 8, 15, 16, 23, 41, 21, 77, 99, 41 };
int n = array.Length;
int find = 41;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}