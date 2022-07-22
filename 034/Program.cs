// Задать массив из 12 элементов, заполненных числами [-9;9]. Найти сумму положительных/отрицательных элементов массива 

int N=12;
int[] array=new int[N];
Random random=new Random();
for(int i=0;i<array.Length;i++)
    array[i]=random.Next(-9,10);



int sumPositive=0;
for(int i=0;i<array.Length;i++)
    if (array[i]>0)
        sumPositive=sumPositive+array[i];
System.Console.WriteLine(sumPositive);

int sumNegative=0;
for(int i=0;i<array.Length;i++)
    if (array[i]<0)
        sumNegative=sumNegative+array[i];
System.Console.WriteLine(sumNegative);

for(int i=0;i<array.Length;i++)
    System.Console.Write($"{array[i],4}");


