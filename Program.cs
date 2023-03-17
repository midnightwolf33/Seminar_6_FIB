// Задача НЕГАФИБОНАЧЧИ. Задайте число. Составьте список чисел НегаФибоначчи, в том числе для отрицательных индексов.
// *Пример:*
// - для k = 9 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]


void FillArray(int[] negaFib, int coint)
{
    int midle = coint - 1;
    for (int i = 0; i < coint; i++)
    {
        if (i < 2)
        {
            negaFib[midle + i] = i;
            negaFib[midle - i] = i;
        }
        else
        {
            negaFib[midle + i] = negaFib[midle + i - 2] + negaFib[midle + i - 1];
            negaFib[midle - i] = negaFib[midle - i + 2] - negaFib[midle - i + 1];
        }
    }
}

void PrintArray(int[] negaFib)
{
    Console.Write("[ ");
    for (int i = 0; i < negaFib.Length - 1; i++)
        Console.Write($"{negaFib[i]}, ");
    Console.WriteLine($"{negaFib[negaFib.Length - 1]} ]");
}


Console.Write("Введите количество чисел Фибоначчи k = ");
int coint = int.Parse(Console.ReadLine());
int[] negaFib = new int[2 * coint - 1];
FillArray(negaFib, coint);
PrintArray(negaFib);