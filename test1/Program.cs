Console.Clear();
int inputNumber(string str)
{
    int number;
    string text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}
int myArr = inputNumber("Введите сколько чисел будет проверяться: ");
int[] arr = new int[myArr];
int res = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = inputNumber("\nВведите число : ");

}
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        res++;
    }
}
System.Console.WriteLine();
Console.WriteLine(string.Join(" | ", arr));
System.Console.WriteLine($"Чисел > 0 = {res}");
