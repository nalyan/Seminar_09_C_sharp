// 3. Найти сумму элементов от M до N, N и M заданы

int InputNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int SumNumbers(int m, int  n)
{
    if(m==n) return n;
    else if(m<n) return m + SumNumbers(m+1, n);
    else return n + SumNumbers(m, n+1);

}
Console.Clear();
int M = InputNumber("Введите M: ");
int N = InputNumber("Введите N: ");
Console.WriteLine($"Сумма элементов от M до N = {SumNumbers(M, N)}");