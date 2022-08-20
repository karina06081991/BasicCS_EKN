// Дана квадратная матрица. Проверить, является ли она симметричной относительно главной диагонали



int[,] a;
a=Init(4,4);
Print(a);

bool flag = false;
for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++) 
    {
        if (a[i,j]!=a[j,i])
            flag = false;
        else   
            flag = true;  
    } 
}
if (flag)
System.Console.WriteLine("матрица несимметрична относительно главной диагонали");
else
System.Console.WriteLine("матрица симметрична относительно главной диагонали");

            
System.Console.WriteLine();



void Print(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++) System.Console.Write($"{a[i,j],4} ");
            System.Console.WriteLine();
    }
}

int[,] Init(int N, int M)
{
    a=new int[N,M];
    Random random=new Random();

    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        {
            a[i,j]=random.Next(1,3);
        }
    }
    return a;
}