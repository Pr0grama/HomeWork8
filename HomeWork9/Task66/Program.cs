Console.Write("Задайте число M = ");
int m = Convert.ToInt16(Console.ReadLine());
Console.Write("Задайте число N = ");
int n = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(Summa(m,n));

int Summa(int m, int n)
{
    int sum = m;
    if (m > n) return 0;
    else
    {
        sum = m + Summa(m+1,n);
        return sum;
    }
}