// Показать натуральные числа от 1 до N, N задан

string Numbers(int a, int b)
{
    if(a<=b) return $"{a} " + Numbers(a+1, b);
    else return String.Empty;
}
Console.WriteLine(Numbers(1,10));
