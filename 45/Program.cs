/*Задача 45: Напишите программу,
 которая будет создавать копию заданного массива с помощью поэлементного копирования.*/

Console.Clear();

int[] array = { 1, 2, 3, 4, 5 };

System.Console.WriteLine($"Задан следующий массив {array} со значениями: ");
System.Console.WriteLine(String.Join(' ', array));
int[] copy = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
    copy[i] = array[i];
}
System.Console.WriteLine("А вот его копия: ");
System.Console.WriteLine(String.Join(' ', copy));