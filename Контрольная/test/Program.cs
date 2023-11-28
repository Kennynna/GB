using System;

class Program
{
    static void Main()
    {
        // Введите строки через запятую или задайте массив в коде
        Console.WriteLine("Введите строки через запятую:");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(',');

        // Формируем новый массив из строк, длина которых <= 3 символам
        string[] resultArray = FilterStrings(inputArray);

        // Выводим результат
        Console.WriteLine("Результат:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }

        Console.ReadLine();
    }

    static string[] FilterStrings(string[] inputArray)
    {
        // Счетчик для отслеживания количества подходящих строк
        int count = 0;

        // Проходим по исходному массиву, считаем подходящие строки
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив нужного размера
        string[] resultArray = new string[count];

        // Заполняем новый массив подходящими строками
        int index = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                resultArray[index] = str;
                index++;
            }
        }

        return resultArray;
    }
}