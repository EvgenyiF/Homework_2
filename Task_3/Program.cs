// Дано число. Проверить кратно ли оно 7 и 23
Console.Write("Введите число для проверки кратности: ");
int N = Convert.ToInt16(Console.ReadLine());
int M = 7;
int S = 23;
int result_1 = N % M;
int result_2 = N % S;
if (result_1 == 0 & result_2 == 0)
{
    Console.WriteLine($"Число {N} кратно {M} и {S}");
}
else
{
    if (result_1 == 0 & result_2 != 0)
    {
        Console.WriteLine($"Число {N} кратно {M} и не кратно {S}");
    }
    else
    {
        Console.WriteLine($"Число {N}  не кратно {M} и кратно {S}");
    }
}