using System;

class Program
{
    static void Main()
    {
        // Вводим массив строк с клавиатуры
        Console.WriteLine("Введите элементы массива, разделяя их пробелами:");
        string[] inputArray = Console.ReadLine().Split();

        // Создаем новый массив для хранения строк длиной меньше или равной 3 символам
        string[] shorterArray = new string[inputArray.Length];
        int shorterArrayIndex = 0;

        // Перебираем все элементы исходного массива
        for (int i = 0; i < inputArray.Length; i++)
        {
            // Если длина строки меньше или равна 3 символам
            if (inputArray[i].Length <= 3)
            {
                // Добавляем эту строку в новый массив
                shorterArray[shorterArrayIndex] = inputArray[i];
                shorterArrayIndex++;
            }
        }

        // Выводим новый массив
        Console.WriteLine("Новый массив из строк длиной меньше или равной 3 символам:");
        for (int i = 0; i < shorterArrayIndex; i++)
        {
            Console.WriteLine(shorterArray[i]);
        }
    }
}
