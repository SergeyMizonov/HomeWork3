// // Задача 3 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Console.Write("Введи число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// for (int i=1; i<=x; i++)
// {
//     Console.WriteLine(Math.Pow(i,3));
// }

// Задача 2 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Console.Write("Введи координату x точки A: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введи координату y точки A: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введи координату z точки A: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введи координату x точки B: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введи координату y точки B: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введи координату z точки A: ");
// int z2 = Convert.ToInt32(Console.ReadLine());
// double result=Math.Round(Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)+Math.Pow((z1-z2),2)),2);
// Console.WriteLine($"Расстояние между двумя точками:{result}");

// Задача 1 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} Данное число является палиндромом");
    }
    else
    {
        Console.WriteLine($"{number} Данное число не является палиндромом");
    }
}
else
{
    Console.WriteLine("Число должно содержать пять знаков");
}