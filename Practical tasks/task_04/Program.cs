// 4. Найти сумму цифр числа

int InputNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int SumNumbers(int n)
{
    if(n/10 < 1) return n;
    else return n%10 + SumNumbers(n/10);
}
Console.Clear();
int n = InputNumber("Введите число: ");
Console.WriteLine(SumNumbers(n));