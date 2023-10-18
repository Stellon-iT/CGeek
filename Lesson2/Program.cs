// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

//int minNumber = 10;
//int maxNumber = 99;

//int randomNumber = new Random().Next(minNumber, maxNumber + 1);
//int firstDigit = randomNumber / 10;
//int secondDigit = randomNumber % 10;

//int max = firstDigit;
//if(max < secondDigit)
//{
//    max = secondDigit;
//}

//Console.WriteLine($"{randomNumber} -> {max}");

//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

//456 -> 46
//782 -> 72
//918 -> 98

//Console.Write("Введи трёхзначное число: ");

//int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
//string stringNumber = Convert.ToString(threeDigitNumber);

//Console.WriteLine($"{threeDigitNumber} -> " + stringNumber[0] + stringNumber[2]);

//второе решение
//Random randomizer = new Random();
//int minNumber = 100;
//int maxNumber = 999;

//int randomNumber = randomizer.Next(minNumber, maxNumber + 1);
//int firstDigit = randomNumber / 100;
//int thirdDigit = randomNumber % 10;

//int result = firstDigit * 10 + thirdDigit;

//Console.WriteLine($"{randomNumber} -> {result}");

//третье решение
//Random randomizer = new Random();
//int minNumber = 100;
//int maxNumber = 999;

//int randomNumber = randomizer.Next(minNumber, maxNumber + 1);
//int firstDigit = randomNumber / 100;
//int thirdDigit = randomNumber % 10;

//int result = firstDigit * 10 + thirdDigit;

//Console.WriteLine($"{randomNumber} -> {result}");

//ВТОРАЯ ЗАДАЧА
//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

//Console.Write("Введите первое число: ");
//int firstNumber = int.Parse(Console.ReadLine());
//Console.Write("Введите второе число: ");
//int secondNumber = int.Parse(Console.ReadLine());

//int remainder = firstNumber % secondNumber;

//if(remainder == 0)
//{
//    Console.WriteLine("Кратно");
//}
//else
//{
//    Console.WriteLine($"Не кратны -> остаток {remainder}");
//}


