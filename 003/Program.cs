//с клавиатуры вводятся два числа a и b. Найти максимальное из них
int a;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
int b;
s=Console.ReadLine();
b=Convert.ToInt32(s);
if (a>b)
{
    Console.WriteLine($"{a}");
}
else
{
    Console.WriteLine($"{b}");
}