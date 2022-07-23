// Проверка, является ли пятизначное число палиндромом
Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine());

int a1 = number%10;
int a2 = number/10%10;
int a3 = number/100%10;
int a4 = number/1000%10;
int a5 = number/10000;
int numberReverse = int.Parse($"{a1}{a2}{a3}{a4}{a5}");
System.Console.WriteLine($"Обратное число = {numberReverse}");

if(numberReverse == number)
{
    System.Console.WriteLine("Обратное число является палиндромом");
}
else System.Console.WriteLine("Обратное число не является палиндромом");
