// int - целое число
// string - строка (текст)
// double (float) - число с плавающей точкой
// bool - true/false

//Console.Write("Введите число: ");
//string input = Console.Readline();
//int number = Convert.ToInt32(input);
//int sqrtNumber = number * number;
//Console.Write("Число " + number + " в квадрате равно ");
//Console.WriteLine(sqrtNumber);




//Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет

//Console.WriteLine("Введите число 1 ");
//Console.WriteLine("Введите число 2 ");

//int number1 = Convert.ToInt32(Console.ReadLine());
//int number2 = Convert.ToInt32(Console.ReadLine());

//int resultNumber2 = number2 * number2;

//if (number1 == resultNumber2)
//{
//    Console.WriteLine("Da");
//}
//else
//{
//    Console.WriteLine("Net");
//}




//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница

//Console.WriteLine("Введите число с 1-7 и вам выведтся день недели: ");
//int number = Convert.ToInt32(Console.ReadLine());

//if (number == 1)
//{
//    Console.WriteLine("Понедельник");
//}
//else if (number == 2)
//{
//    Console.WriteLine("Вторник");
//}
//else if (number == 3)
//{
//    Console.WriteLine("Среда");
//}
//else if (number == 4)
//{
//    Console.WriteLine("Четверг");
//}
//else if (number == 5)
//{
//    Console.WriteLine("Пятница");
//}
//else if (number == 6)
//{
//    Console.WriteLine("Суббота");
//}
//else if (number == 7)
//{
//    Console.WriteLine("Воскресенье");
//}




//Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
//2 -> " -2, -1, 0, 1, 2"

//Console.WriteLine("Введите число");
//int input = Convert.ToInt32(Console.ReadLine());
//int minusInput = -input;

//while (input >= minusInput)
//{
//    Console.Write(minusInput + " ");
//
//    minusInput += 1;
//}




//Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//	456 -> 6
//	782 -> 2
//	918 -> 8

//Console.WriteLine("Введите число");
//int input = Convert.ToInt32(Console.ReadLine());

//string str = Convert.ToString(input);
//Console.WriteLine(str[str.Length - 1]);

//@deniust - Денис Хабибуллин

  