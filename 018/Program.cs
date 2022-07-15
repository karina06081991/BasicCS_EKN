// По двум заданным числам проверить является ли одно квадратом другого. Используйте подпрограмму.

bool Check(int a, int b)
{
    return a*a==b;
}

int a,b;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);
if (Check(a,b))
{
    Console.WriteLine("b является квадратом a");
}
else
{
    if (Check(b,a))
    {
        Console.WriteLine("a является квадратом b");
    }
    else 
    {
        Console.WriteLine("числа не являются квадратами друг друга");
    }
}

