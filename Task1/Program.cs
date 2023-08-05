Console.WriteLine("Введите число с которого начать отсчет");

int numberUser = int.Parse(Console.ReadLine());

GapNumber(numberUser);

void GapNumber(int number)
{
    Console.WriteLine(" " + number);
    if (number != 1)
        GapNumber(number - 1);
}

