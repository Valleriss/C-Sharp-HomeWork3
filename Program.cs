/* 
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

Console.Write("Введите пятизначное число:");
string s = Console.ReadLine();
if(s.Length >= 5){
    Console.WriteLine(CheckPalindrome(s));
}
else{
    Console.WriteLine("Число не пятизначное");
}


string CheckPalindrome(string text)
{
    if (text[0] == text[4] && text[1] == text[3])
    {
        return "Это палиндром";
    }
    else
    {
        return "Это не палиндром";
    }
}


