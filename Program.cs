// Задача 50. Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого элемента или
// же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите индекс строки: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс столбца: ");
int y = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[3, 4];
FillArray(numbers);
PrintArray(numbers);

if (x < numbers.GetLength(0) && y < numbers.GetLength(1)) Console.WriteLine(numbers[x, y]);
else Console.WriteLine($"{x}, {y} -> такого числа в массиве нет");

void FillArray(int[,] array)// Заполнение массива рандомными числами от 1 до 9
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array) //  Функция вывода массива в терминал
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}