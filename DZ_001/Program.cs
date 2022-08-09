// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int new_number = (number % 100) / 10;
System.Console.WriteLine(new_number);

// Строчное решение!
//Console.WriteLine("Введите трёхзначное число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//string str_number = number.ToString();
//char digit1 = str_number[0];
//char digit2 = str_number[1];
//char digit3 = str_number[2];
//string new_number = digit2.ToString();
//System.Console.WriteLine(new_number);
