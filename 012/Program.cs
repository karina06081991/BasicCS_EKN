// С клавиатуры вводится целое число из диапазона [10,99]. Показать наибольшую цифру числа

int a;
int b,c;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
b=a/10;
c=a%10;
if (b>c)
{
    Console.WriteLine($"{b}");
}
else
{
    Console.WriteLine($"{c}");
}