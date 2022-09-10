// 1. Показать натуральные числа от N до 1, N задано

int InputNumber (string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int NumbersLine(int n)
{
    Console.Write($"{n} ");
    if(n==1) return 1;
    else return NumbersLine(n-1);
}

Console.Clear();
int n = InputNumber("Введите число: ");
NumbersLine(n);
