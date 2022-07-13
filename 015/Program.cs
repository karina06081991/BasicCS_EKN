// С клавиатуры вводится целое число. Вывести тертью цифру числа или сообщить, что ее нет

int a;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
int b;
b=a/10/10%10;
Console.WriteLine($"{b}");
if (a<100)
{
    System.Console.WriteLine("третьей цифры в числе нет");
}