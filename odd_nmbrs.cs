int[] array = {7, 4, 6, 9, 10, 12, 18};
int n = array.Length;

int index = 0;

while (index < n)
{
    if(array[index]%2==0)
    {
        Console.WriteLine(array[index]);
        index ++;
    }
    else
    {
        index ++;
    }
}
