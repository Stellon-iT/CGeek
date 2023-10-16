// Напишите метод CompareNumbers, который на вход принимает два числа и выводит, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
 
if(number1 > number2)
{
    Console.WriteLine($"Первое число {number1} больше второго {number2}");
}
else if (number1 < number2)
{
    Console.WriteLine($"Первое число {number1} меньше второго {number2}");
}
else
{
    Console.WriteLine($"Оба числа равны {number1}");
}
