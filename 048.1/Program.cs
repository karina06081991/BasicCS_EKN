// Показать двумерный массив размером m*n заполненный целыми случайными числами

int N=3;
int M=2;

int[,] a;

a=new int[N,M];

Random random=new Random();

for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++)
    {
        a[i,j]=random.Next(1,11);
    }
}

for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++) System.Console.Write($"{a[i,j]} ");
        System.Console.WriteLine();
}