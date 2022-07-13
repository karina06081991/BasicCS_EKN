// Выяснить, является ли число четным

int a;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
if (a%2==0)
{
    Console.WriteLine("a четное число");
}
else
{
    Console.WriteLine("a нечетное число");
}