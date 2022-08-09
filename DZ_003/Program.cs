// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// ВОПРОС!!! (Почему код работает с фигурными скобками и без них?)

// Без скобок
//Console.Write("Введи цифру, обозначающую день недели: ");
//int day_number = Convert.ToInt32(Console.ReadLine());
//if (day_number < 0 || day_number > 7) Console.WriteLine("Это не день недели!");
//else if (day_number == 6 || day_number == 7) Console.WriteLine("Этот день - выходной");
//else Console.WriteLine("Этот день - не выходной");

// С фигурными скобками
Console.Write("Введи цифру, обозначающую день недели: ");
int day_number = Convert.ToInt32(Console.ReadLine());
if (day_number < 0 || day_number > 7) 
{
    Console.WriteLine("Это не день недели!");
}
else if (day_number == 6 || day_number == 7) 
{
    Console.WriteLine("Этот день - выходной :)");
}
else 
{
    Console.WriteLine("Этот день - не выходной :(");
}
