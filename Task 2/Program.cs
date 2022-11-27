// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = Convert.ToString(number).Length;
int summ = 0;
if (number < 0)
{
    number *= -1;
}
while (count > 0)
{
    summ = summ + number % 10;
    number /= 10;
    count--;
}

Console.WriteLine(summ);