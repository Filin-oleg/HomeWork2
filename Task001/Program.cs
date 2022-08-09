//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число ");
int num = int.Parse(Console.ReadLine());
String str = num.ToString();
if (str.Length != 3){Console.WriteLine("Вы ввели не трёхзначное число ");} 
else{Console.WriteLine("Вторая цифра введенного Вами числа " + str[1]);}