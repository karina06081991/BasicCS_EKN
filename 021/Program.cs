// Задать номер четверти, показать диапазоны для возможных координат

Console.Write("введите номер четверти (от 1 до 4)  ");
int a=Convert.ToInt32(Console.ReadLine());
if(a==1)
{
    System.Console.WriteLine("x>0 & y>0");
}
if(a==2)
{
    System.Console.WriteLine("x<0 & y>0");
}
if(a==3)
{
    System.Console.WriteLine("x<0 & y<0");
}
if(a==4)
{
    System.Console.WriteLine("x>0 & y<0");
}
