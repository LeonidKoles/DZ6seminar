void Zadacha43 ()
{
    int k1 = 0;
    int b1 = 2;
    int k2 = 1;
    int b2 = 1;
    if (k1 == k2)
    {
        Console.WriteLine("Нет точки пересечения, прямые  параллельны");
    }
    else
    {
        double x = (b2 -b1) / (k1 - k2);
        double y = k1 * x + b1;
        double y2 = k2 * x + b2;
        Console.WriteLine($"Координаты точки пересечения A ({Math.Round(x, 2)}), {Math.Round(y)}) ");
        Console.WriteLine($"Координаты точки пересечения A ({Math.Round(x, 2)}), {Math.Round(y2)}) ");

    }
}Zadacha43();