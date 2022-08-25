Console.WriteLine("Введите число от 1 до 7");
string? num = Console.ReadLine();

int s(int n)
{
    n = Convert.ToInt32(new string(num[0], 1));
    return n;
}

int n = s(num[0]);

if (n >= 6)
{
    Console.WriteLine("Цифра соответствует выходному дню");
}
else
{
    Console.WriteLine("Цифра не соответствует выходному дню");
}