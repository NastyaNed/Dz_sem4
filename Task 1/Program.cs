// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int numA = ReadInt("Введите первое число A: ");
int numB = ReadInt("Введите второе число B: ");
int degree = numA;
for (int count = 1; count < numB; count++)
{
    degree = degree * numA;

}
Console.WriteLine(degree);
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}