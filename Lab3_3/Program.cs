using System;

class Program
{
    static void Main()
    {
        // Инициализация массива
        int[] array = { 1, 2, 3, 4, 5, 6, 7 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Количество позиций для сдвига
        int k = 3;

        // Выполнение циклического сдвига
        ShiftLeft(array, k);

        Console.WriteLine($"Массив после циклического сдвига на {k} позиции(й) влево:");
        PrintArray(array);
    }

    static void ShiftLeft(int[] array, int k)
    {
        int size = array.Length;

        // Убедимся, что k не больше размера массива
        k = k % size;

        // Создание временного массива для хранения сдвинутых элементов
        int[] temp = new int[k];

        // Сохраняем первые k элементов во временный массив
        for (int i = 0; i < k; i++)
        {
            temp[i] = array[i];
        }

        // Сдвигаем оставшиеся элементы влево
        for (int i = 0; i < size - k; i++)
        {
            array[i] = array[i + k];
        }

        // Переносим элементы из временного массива в конец
        for (int i = 0; i < k; i++)
        {
            array[size - k + i] = temp[i];
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + "\t");
        }
        Console.WriteLine();
    }
}