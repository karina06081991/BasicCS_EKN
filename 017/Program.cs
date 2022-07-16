// Дано число обозначающее день недели. Выяснить является номер дня недели выходным


System.Console.Write("введите день недели (от 1 до 7) ");
int a;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
if (a==6 || a==7)
{
    System.Console.WriteLine("да, это выходной день");
}
else
{
    System.Console.WriteLine("это не выходной день");
}