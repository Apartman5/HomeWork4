// Задача 27: 
// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// Примеры:
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    Console.Write(message); // Выводим приглашение ко вводу
    string readInput = Console.ReadLine(); // Вводим значение
    int result = int.Parse(readInput); // приводим к числу
    return result;
}

int SumAllDigit(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    return sum;
}

int number = Prompt("введите число: ");
Console.WriteLine($"Сумма всех чисел числа {number} равна {SumAllDigit(number)}");