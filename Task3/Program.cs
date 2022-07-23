// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
Console.WriteLine("Введите число ");
double number = Convert.ToInt32(Console.ReadLine());
double j = 1;

while(j <= number)
{
    double result = Math.Pow(j, 3);
    System.Console.WriteLine(result);
    j++;
}