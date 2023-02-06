// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int GetNumberByUser()
{
    Console.Write("Введите размерность: ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateArray(int size1, int size2)
{
    return new int[size1, size2];
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"Введите элемент массива ({i},{j}) = ");
            matr[i, j] = Convert.ToInt32(Console.ReadLine());

        }
    }
}

void MinSum(int[,] matr)
{
    int summa1 = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        summa1 = summa1 + matr[i, 0];
    }
    int minSumma = summa1;
    int minLine = 1;

    for (int i = 1; i < matr.GetLength(0); i++)
    {
        int summa = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            summa = summa + matr[i, j];
        }
        if (summa < minSumma)
        {
            minSumma = summa;
            minLine = i + 1;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой элементов = {minLine}");
}

int number1 = GetNumberByUser();
int number2 = GetNumberByUser();
int[,] array = CreateArray(number1, number2);
Console.WriteLine();
FillArray(array);
Console.WriteLine();
MinSum(array);
