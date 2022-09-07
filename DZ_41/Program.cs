// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

Console.WriteLine("Задача 41: Cколько чисел больше 0 ввёл пользователь.");
Console.WriteLine("Введите число M(Количесво чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arrNumbers = new int[m];

FillArrNumbers(m);
Console.WriteLine();
Console.Write(String.Join(",", arrNumbers));
Console.WriteLine(" -> "+ PrintArrNumbers(arrNumbers));
Console.WriteLine($"Введино чисел больше 0: {PrintArrNumbers(arrNumbers)} ");
Console.WriteLine();

void FillArrNumbers(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"Введите {i+1} число: ");
        arrNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int PrintArrNumbers(int[] arrNumbers)
{
    int count = 0;
    for (int i = 0; i < arrNumbers.Length; i++)
    {
        if(arrNumbers[i] > 0) count++;
    }
    return count;
}
