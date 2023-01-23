// Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int a = Prompt("Введите число: ");
Math.Pow(a, 3);
int index = 1;
while (index <= a)
{
    double r = Math.Pow(index, 3);
    System.Console.WriteLine($"Куб числа {index} от 1 до введенного равен: " + r);
    index++;

}
