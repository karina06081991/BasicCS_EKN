//с клавиатуры вводятся два вещественных числа. Проверить, является ли одно из них квадратом второго

int a,b;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);
if (a*a==b)
{
    Console.WriteLine("b является квадратом a");
}
else
{
    if (b*b==a)
    {
        Console.WriteLine("a является квадратом b");
    }
    else 
    {
        Console.WriteLine("числа не являются квадратами друг друга");
    }
}
