Console.WriteLine("Введите число");
int numberUser1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int numberUser2 = int.Parse(Console.ReadLine());

System.Console.WriteLine(GasNumber(numberUser1, numberUser2));

int GasNumber(int num1, int num2)
{
    if (num1 != num2 + 1)
    {
        return GasNumber(Math.Min(num1, num2)+1, Math.Max(num1, num2)) +  Math.Min(num1, num2);
    }
    else 
        return 0;

}