Console.Write("Задайте число M = ");
int m = Convert.ToInt16(Console.ReadLine());
Console.Write("Задайте число N = ");
int n = Convert.ToInt16(Console.ReadLine());
Account(m,n);

void Account(int m, int n)
{
    if (m > n) return;
    else
    {
        Console.Write($"{m} ");
        m++;
        Account(m,n);
    }
}