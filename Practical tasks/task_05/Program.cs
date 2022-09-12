// 5. Написать программу вычисления функции Аккермана
int InputNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int Akker(int m, int n)
{
    if(m==0) return n+1;
    else if(n==0 && m>0) return Akker(m-1, 1);
    else if(n>0 && m>0) return Akker(m-1, Akker(m, n-1));
    else return 0;
}
Console.Clear();
int m = InputNumber("Enter m: ");
int n = InputNumber("Enter n: ");
Console.WriteLine(Akker(m, n) != 0 ? Akker(m,n) : "Значения m и n должны быть >= 0");
