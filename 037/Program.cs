// Задать массив, заполнить случайными положительными трехзначными числами. 
// показать количество нечетных/четных чисел

int N=20;
int[] array=new int[N];
Random random=new Random();
for(int i=0;i<array.Length;i++)
    array[i]=random.Next(100,1000);


for(int i=0;i<array.Length;i++)
    System.Console.Write($"{array[i],4}");

Console.WriteLine();
int sumEven=0;
for(int i=0;i<array.Length;i++)
    if (array[i]%2==0)
        sumEven=sumEven+1;
System.Console.WriteLine($"количество четных чисел {sumEven}");

Console.WriteLine();
int sumOdd=0;
for(int i=0;i<array.Length;i++)
    if (array[i]%2!=0)
        sumOdd=sumOdd+1;
System.Console.WriteLine($"количество нечетных чисел {sumOdd}");