// Задача 25: 
// Напишите цикл, который принимает на вход два числа (a и b) 
// и возводит число a в натуральную степень b.
// Примеры:
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



// Вариант решения мой:
Console.WriteLine("Введите число a и его степень b: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
double degree = 0;
Console.WriteLine($"Число {a} в степени {b} равно {degree = Math.Pow(a, b)}");



// Идеальный вариант решения
int Prompt(string message)
{
    Console.Write(message); // Выводим приглашение ко вводу
    string readInput = Console.ReadLine(); // Вводим значение
    int result = int.Parse(readInput); // приводим к числу
    return result;
}

int Power(int powerBase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power *= powerBase;
    }
    return power;
}

bool ValidateExponent(int exponent)
{
    if (exponent < 0)
    {
        Console.WriteLine("Показатель не должен быть меньше нуля");
        return false;
    }
    return true;
}

int powerBase = Prompt("Введите основание: ");
int exponent = Prompt("Введите показатель степени: ");
if (ValidateExponent(exponent))
{
    Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
}