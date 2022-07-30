// Вывести на экран таблицу квадратов чисел от 1 до N

int i=1;
int N=30;
int k;

while(i<N)
{
    k=i*i;
    System.Console.Write($"{i}  {k} ");
    System.Console.WriteLine();
    i++;
}
