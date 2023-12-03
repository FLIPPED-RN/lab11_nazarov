//Высокий уровень, Вариант 8 (Назаров Руслан)

try
{
    Console.Write("Введите массив из 9 элементов (восьмеричные числа): ");
    string[] octalArray = Console.ReadLine().Split(' ');

    if (octalArray.Length != 9)
    {
        Console.WriteLine("Упс! Нужно ввести 9 элементов :) Сегодня без Random, нужно почувствовать программу, поэтому пишем вручную, пасиба :)");
        return;
    }

    int[] decimalArray = new int[9];

    for (int i = 0; i < 9; i++)
    {
        decimalArray[i] = Convert.ToInt32(octalArray[i], 8);
    }

    Console.WriteLine("Исходный массив в десятичной системе счисления:");
    foreach (int number in decimalArray)
    {
        Console.Write($"{number} ");
    }
    Console.WriteLine(" <= вот ваши числа переведенные в десятичную систему счисления, удачи :)");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}