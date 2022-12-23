Console.Clear();
double inputNumber(string str)
{
    double number;
    string text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (double.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}
N:
double k1 = inputNumber("\nВведите значение k1: ");
double k2 = inputNumber("\nВведите значение k2: ");
if (k1==k2)
{
    System.Console.WriteLine("Значения k1 и k2 не могут быть одинаковыми!!! Попробуйте еще раз:");
    goto N;
}
double b1 = inputNumber("\nВведите значение b1: ");
double b2 = inputNumber("\nВведите значение b2: ");
RecXY(out double x, out double y);
System.Console.WriteLine($"Точки пересечения прямых Х: {x}  Y: {y}");

void RecXY(out double x, out double y)
{
    x=Math.Round((b2-b1) / (k1-k2),2);
    y=Math.Round(k1 * x +b1,2);
}