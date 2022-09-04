int[] array = { 0, 11, 22, 31, 14, 45, 61, 17, 38 };

int n = array.Length;
int find = 3;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}
