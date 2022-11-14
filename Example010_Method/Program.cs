int [] array = {1, 2, 95, 15, 56, 78, 95, 86};

int n = array.Length;
int find = 95;

int index = 0;

while (index < n)
{
    if (array [index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}