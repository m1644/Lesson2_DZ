// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
string new_number = Convert.ToString(number);
if (new_number.Length > 2)
{
  Console.WriteLine("Третья цифра: " + new_number[2]);
}
else 
{
  Console.WriteLine("Третьей цифры нет!");
}
