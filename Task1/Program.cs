Console.WriteLine("Введите трёхзначное число ");
int num = Convert.ToInt32(Console.ReadLine());

int CalculationSekondNumber(int result)
{
    result = num% 100 /10;
    return result;
}


int n = CalculationSekondNumber(num);

Console.WriteLine(n);





