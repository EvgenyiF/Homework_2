// Выяснить, кратно ли число заданному, если нет, вывести остаток
Console.Write("Введите число для проверки кратности: ");
int N = Convert.ToInt16(Console.ReadLine());
//Console.Write("Введите кратность: ");
//int M = Convert.ToInt16(Console.ReadLine());
int M = 5; // Если не вводить кратность с терминала строки 4,5
int result = N % M;
if (result == 0)
{
    Console.Write($"Число {N} кратно {M}");
}
else
{
    Console.WriteLine($"Число {N} не кратно {M}");
    Console.WriteLine($"Остаток = {result}");
}