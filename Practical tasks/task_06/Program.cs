// 6. Написать программу возведения числа А в целую стень B

int InputNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int Degree(int a, int b)
{
    int count;
    if(b==1) return a;
    else return Degree(a, b-1)*a;
}
Console.Clear();
int a = InputNumber("Введите число: ");
int b = InputNumber("Введите степень числа: ");
Console.WriteLine(Degree(a, b));