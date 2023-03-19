// Задача 29: 
// Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// Примеры:
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Prompt(string message)
{
    Console.Write(message); // Выводим приглашение ко вводу
    string readInput = Console.ReadLine(); // Вводим значение
    int result = int.Parse(readInput); // приводим к числу
    return result;
}

int[] GenerateArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(minValue, maxValue +1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i =0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}

int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение диапазона случайных чисел ");
int max = Prompt("Конечное значение диапазона случайных чисел ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);