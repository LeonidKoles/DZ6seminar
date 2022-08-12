
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
// ввёл пользователь.

void Zadacha41()
{
    Console.WriteLine("Сколько чисел хотите ввести?");
    int m = Convert.ToInt32(Console.ReadLine());
    int count = 0;

    for (int i = 0; i < m; i++)
    {
        Console.Write("Введите число ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        if (num > 0) count++;
    }
    Console.WriteLine($"Было введено {count} чисел больше нуля");


}
Zadacha41();