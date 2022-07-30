// Написать программу преобразования десятичного числа в двоичное

int n=16;
System.Console.WriteLine(DecToBin(n));
string DecToBin(int n)
{
    string s="";
    while (n!=0)
    {
        s=(n%2).ToString()+s;
        n=n/2;
    }
    return s;
}
