Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (x > 0)
{
    x /= 10;
    count++;
}
Console.WriteLine($"Количество цифр = {count}");
