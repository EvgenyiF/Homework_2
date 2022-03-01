// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Усложнил для себя задачу: Берем любое число в пределах 32 бит с терминала или рандомно любое число, выбираем с какой стороны считать
// и вводим номер цифры, которую хочем найти.

//Console.Write("Введите число:  ");          // Строки 3,4 сделаны для ручного ввода числа
//int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int N = new Random().Next();                //Строки 5,6,7 для генератора случайных чисел.
Console.WriteLine($"Сгенерированное число = {N}");
N = Math.Abs(N);
int i = 0;
int B = N;
while (N != 0) //Цикл подсчета разрядов числа
{
    N /= 10;
    i++;
}
int count = i - 1; // счетчик для перевода числа в массив
M: Console.Write("Введите Слева или Справа искать цифру в числе:  ");
String? str = Console.ReadLine();
if (String.IsNullOrEmpty(str)) goto M; // Проверка строки на пустоту
if (str.ToLower() == "слева" || str.ToLower() == "справа") // проверка правильносьти ввода слова
{
K: Console.Write($"Введите номер цифры из числа {B} от 1 до {i}, который нужно найти:  ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > i) // проверка попадает ли цифра в диапазон числа
    {
        int s = number - i;
        Console.WriteLine($"Число {B} меньше на {s} разряда, поиск невозможен. Введите число от 1 до {i}");
        goto K;
    }
    int d = i - 1;
    int[] array = new int[i];
    i = 0;
    N = B;
    while (count >= 0) // цикл перевода числа в массив
    {
        i = N % 10;

        array[count] = i;
        count--;
        N /= 10;
    }
    Console.WriteLine("[{0}]", string.Join("",array));
    if (str.ToLower() == "слева")
    {
        Console.Write($"Вторая цифра слева числа {B} = {array[number - 1]}");
    }
    else
    {
        if (str.ToLower() == "справа")
        {
            Console.Write($"Вторая цифра справа числа {B} = {array[d - (number - 1)]}");
        }
    }
}
else
{
    Console.WriteLine("Попробуйте сменить раскладку клавиатуры или правильность написания!!!");
    goto M;
}