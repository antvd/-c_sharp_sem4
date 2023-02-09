// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// System.Console.WriteLine("Введите первое число");
// int numberA = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите второе число");
// int numberB = int.Parse(Console.ReadLine());
// int sum = numberA;

// for(int i = 0; i < numberB; i++)
// {
//     sum = numberA * numberA;
// }
// System.Console.WriteLine(sum);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// System.Console.WriteLine("Введите число:");
// string number = System.Console.ReadLine();
// int numberlength = number.Length;
// int sum = 0;
// for(int i = 0; i < numberlength; i++)
// {
//     sum = sum + Convert.ToInt32(Convert.ToString(number[i]));
// }
// System.Console.WriteLine(sum);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
Random rand = new Random();

for(int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
}
System.Console.WriteLine(string.Join(", ", array));