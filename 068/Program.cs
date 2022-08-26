// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

int P(int M, int N)
{
    if (M==0) return N+1;
    else if (N==0) return P(M-1,1);
    else return P(M-1, P(M, N-1));
}
System.Console.WriteLine(P(3,2));
