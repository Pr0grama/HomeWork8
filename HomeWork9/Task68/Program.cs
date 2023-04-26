Console.Write("Задайте число M = ");
int m = Convert.ToInt16(Console.ReadLine());
Console.Write("Задайте число N = ");
int n = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(Akerman(m,n));

int Akerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akerman(m-1,1);
    else return Akerman(m-1, Akerman(m,n-1));
}
