// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел: ");
int M = int.Parse(Console.ReadLine());

int[] array = new int[M];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    array[i] = int.Parse(Console.ReadLine());
    if (array[i] > 0) count++;
}

Console.Write($"Количество чисел > 0 = {count}");