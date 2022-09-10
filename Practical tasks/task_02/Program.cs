// Показать натуральные числа от M до N, N и M заданы

int InputNumber (string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int NaturalNumbers(int m, int n)
{
    Console.Write($"{m} ");
    if(m==n) return n;
    else if (m<n) return NaturalNumbers(m+1, n);
    else return NaturalNumbers(m-1, n);
}

Console.Clear();
int M = InputNumber("Введите M: ");
int N = InputNumber("Введите N: ");
NaturalNumbers(M,N);