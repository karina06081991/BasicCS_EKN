// С клавиатуры вводятся три числа. Найти максимальное из трёх чисел

int a;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
int b;
s=Console.ReadLine();
b=Convert.ToInt32(s);
int c;
s=Console.ReadLine();
c=Convert.ToInt32(s);
if (a>b)
{
    if (a>c)
    Console.WriteLine($"{a}");
    else 
    Console.WriteLine($"{c}");
}
else 
{
    if (b>c)
    Console.WriteLine($"{b}");
    else 
    Console.WriteLine($"{c}");
}