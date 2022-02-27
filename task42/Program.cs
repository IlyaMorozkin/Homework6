// Определить, сколько чисел больше 0 введено с клавиатуры.

string getNumberStr = String.Empty;
int getNumber = 1;
int i = 0;
Console.WriteLine("Введите число, для выхода нажать 0 ");
while (getNumber != 0 && getNumber > 0)
{
    getNumberStr = Console.ReadLine();
    int.TryParse(getNumberStr, out getNumber);
    i++;
    if(getNumber == 0 || getNumber < 0)
    i--;
}
Console.WriteLine($"Вы ввели {i} числа");