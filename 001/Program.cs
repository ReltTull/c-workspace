int [] a = {1,2,3,4,5,6,7,8,9};
int [] b = new int [a.Length];

int c = 0;
for (int i = 0; i < a.Length; i++)
{
    if (a[i] % 2 == 0)
    {
        b[c++] = a[i];
    }
}
Console.WriteLine("b ");
for (int i = 0; i < c; i++)
{
    Console.WriteLine($"{b[i]}");
}