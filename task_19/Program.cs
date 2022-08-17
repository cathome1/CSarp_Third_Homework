// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите проверяемое число");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int rev = 0;
int num2 = num;
while (0 < num )
{
    int dig = num % 10;
    rev = rev * 10 + dig;
    num = num / 10;
}
string GetPal() {
    if (num2 == rev) return "ДА";
    return "НЕТ";
}
Console.WriteLine(GetPal());