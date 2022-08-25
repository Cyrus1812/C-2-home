Console.WriteLine("Введите трёхзначное число ");
int num = Convert.ToInt32(Console.ReadLine());


int CalculationSekondNumber(int result)
{
    result = Math.Abs(num)% 100 /10;
    return result;
}

int n = CalculationSekondNumber(num);

if(num > 999 || num < 100 && num >0)
{
    Console.WriteLine("Вы ввели не трёхзначное число");
}
else{
Console.WriteLine($"Вторая цифра = {n}");
}





