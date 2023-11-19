double ReadData(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToDouble(Console.ReadLine() ?? "0");
}

double xVolume(double b1, double k1, double b2, double k2)
{
    double xVol = (b2 - b1) / (k1 - k2);
    return xVol;
}

double yVolume(double b1, double k1, double x)
{
    double y = k1 * x + b1;
    return y;
}

double b1 = ReadData("Введите b1: ");
double k1 = ReadData("Введите k1: ");
double b2 = ReadData("Введите b2: ");
double k2 = ReadData("Введите k2: ");

double x = xVolume(b1, k1, b2, k2);
double y = yVolume(b1, k1, x);

Console.WriteLine("Значение Х = " + x);
Console.WriteLine("Значение Y = " + y);