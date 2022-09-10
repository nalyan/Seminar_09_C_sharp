// 7. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

int InputNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void Sum(int number1, int number2, int n)
{
    void SumPart(int number1, int number2, int n)
    {
        int numberEnd = number1+number2;
        if(n>0)
        {
            Console.Write($"{numberEnd} ");
            number1 = number2;
            number2 = numberEnd;
            SumPart(number1, number2, n-1);
        }
    }
    Console.Write($"{number1} {number2} ");
    SumPart(number1, number2, n-2);
}

Console.Clear();
int number1 = InputNumber("Введите число 1: ");
int number2 = InputNumber("Введите число 2: ");
int n = InputNumber("Введите количество чисел последовательности: ");
Sum(number1, number2, n);