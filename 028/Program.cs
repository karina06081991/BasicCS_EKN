// Определить количество цифр в числе


int CountDigits(int N)
{
    if (N==0) return 1;
    int k=0;
    while(N!=0)
    {
       k++;
       N=N/10;
    }
    return k;
}

System.Console.WriteLine(CountDigits(0));