// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
System.Console.WriteLine("Введите числа через запятую ( 1, 2, 3, 4, ...): ");
string[] numbers = Console.ReadLine().Split(", ");
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if ( int.Parse(numbers[i]) > 0)
        count++;
}
System.Console.WriteLine(count);