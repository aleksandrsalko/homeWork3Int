/*Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да*/


Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int var = n;
int rev = 0;
int rem = 0;

while(n > 0)
{
    rem = n % 10;
    rev = rev * 10 + rem;
    n = n / 10;
}    
if(var == rev)
{
   Console.WriteLine("Это палиндром!");
}    
else
{
   Console.WriteLine("Это не палиндром!");
}
