Console.WriteLine("Введите число ");
string? num = Console.ReadLine();

int CheckingTherdNumber(int result)
{
    result = Convert.ToInt32(new string(num[2], 1));
    return result;

}


if (num.Length < 3)
{
    Console.WriteLine("нет 3 цифры");
}
else
{
    int n = CheckingTherdNumber(num[2]);
    Console.WriteLine($"Третья цифра = {n}");
}


