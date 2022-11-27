// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите натуральное число (N): ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];

void FillArray(int[] coll)
{
    int i = 0;
    while (i < coll.Length)
    {
        coll[i] = new Random().Next(1, 100);
        i++;
    }
}
void PrintArray(int[] coll)
{
    int i = 0;
    Console.Write($"{num}->[");
    while (i < coll.Length - 1)
    {
        Console.Write($"{coll[i]},");
        i++;
    }
    Console.Write($"{coll[i]}]");
}

FillArray(array);
PrintArray(array);
