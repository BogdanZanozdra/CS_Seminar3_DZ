
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число");
string num = Console.ReadLine();

if (num.Length != 5)
{
    Console.WriteLine("Число не пятизначное!");
}

Console.WriteLine(num);
bool IsPalindrome(string num)
{
    for (int i = 0; i < num.Length / 2; i++)
    if(num[i] != num[num.Length - 1 - i]) return false;
    return true;
}    
    Console.WriteLine($"Число является палиндромом {IsPalindrome(num)}");

