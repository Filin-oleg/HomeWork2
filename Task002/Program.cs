//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
string str = num.ToString();
if (str.Length >= 3){Console.WriteLine("Третья цифра введенного Вами числа " + str[2]);}
else{Console.WriteLine("Третьей цифры в введенном Вами числе нет");}